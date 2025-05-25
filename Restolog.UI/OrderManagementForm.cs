using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restolog.Entities.Concrete;
using Restolog.DataAccess;
using System.Drawing.Drawing2D;
using Microsoft.EntityFrameworkCore;

namespace Restolog.UI
{
    public partial class OrderManagementForm : Form
    {
        private readonly RestologContext _context;
        private Dictionary<Guid, Panel> _tablePanels;
        private Order? CurrentOrder;
        private List<OrderDetail?>? CurrentOrderDetails;
        private int SelectedRowId = 0;
        public OrderManagementForm()
        {
            InitializeComponent();
            _context = new RestologContext();
            _tablePanels = new Dictionary<Guid, Panel>();

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeOrderStatusComboBox();
            LoadTables();
        }

        private void LoadProducts(string Category = "")
        {
            panelProduct.Controls.Clear();
            if (Category == "")
                LoadCategories();

            int panelWidth = 140, panelHeight = 100, spacing = 10;
            int availableWidth = panelProduct.ClientSize.Width > 0 ? panelProduct.ClientSize.Width : panelProduct.Width;
            int columns = Math.Max(1, (availableWidth + spacing) / (panelWidth + spacing));

            var products = _context.Products.Where(p => p.Category.Name == Category).ToList();
            int x = 10, y = 10, col = 0;

            panelProduct.AutoScroll = true;

            foreach (var product in products)
            {
                var productPanel = new Panel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Location = new Point(x, y)
                };

                productPanel.Paint += (s, e) =>
                {
                    using (GraphicsPath path = new GraphicsPath())
                    {
                        int radius = 12;
                        path.AddArc(0, 0, radius, radius, 180, 90);
                        path.AddArc(productPanel.Width - radius, 0, radius, radius, 270, 90);
                        path.AddArc(productPanel.Width - radius, productPanel.Height - radius, radius, radius, 0, 90);
                        path.AddArc(0, productPanel.Height - radius, radius, radius, 90, 90);
                        path.CloseAllFigures();
                        productPanel.Region = new Region(path);
                        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                        using (Pen pen = new Pen(Color.LightGray, 1))
                        {
                            e.Graphics.DrawPath(pen, path);
                        }
                    }
                };

                productPanel.MouseEnter += (s, e) => productPanel.BackColor = Color.AliceBlue;
                productPanel.MouseLeave += (s, e) => productPanel.BackColor = Color.White;

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Location = new Point(8, 8),
                    AutoSize = false,
                    Width = panelWidth - 16,
                    Height = 22,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.FromArgb(30, 30, 30),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                var priceLabel = new Label
                {
                    Text = $"₺ {product.Price:0.00}",
                    Location = new Point(8, 32),
                    AutoSize = false,
                    Width = panelWidth - 16,
                    Height = 18,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.DarkGreen,
                    TextAlign = ContentAlignment.MiddleLeft
                };

                var descLabel = new Label
                {
                    Text = string.IsNullOrWhiteSpace(product.Description) ? "" : product.Description,
                    Location = new Point(8, 54),
                    AutoSize = false,
                    Width = panelWidth - 16,
                    Height = 32,
                    Font = new Font("Segoe UI", 8, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.TopLeft
                };

                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(descLabel);

                productPanel.Tag = product;
                productPanel.Click += ProductPanel_Click;
                nameLabel.Click += ProductPanel_Click;
                priceLabel.Click += ProductPanel_Click;
                descLabel.Click += ProductPanel_Click;

                panelProduct.Controls.Add(productPanel);

                col++;
                if (col >= columns)
                {
                    col = 0;
                    x = 10;
                    y += panelHeight + spacing;
                }
                else
                {
                    x += panelWidth + spacing;
                }
            }
        }

        void ProductPanel_Click(object sender, EventArgs e)
        {
            var productPanel = sender as Control;
            if (productPanel == null) return;

            var product = productPanel.Tag as Product;
            if (product == null && productPanel.Parent != null)
                product = productPanel.Parent.Tag as Product;
            if (product == null) return;

            if (CurrentOrderDetails == null)
                CurrentOrderDetails = new List<OrderDetail>();

            var existingDetail = CurrentOrderDetails.FirstOrDefault(o => o.ProductId == product.Id);

            if (existingDetail != null)
            {
                existingDetail.Quantity += 1;
                existingDetail.Subtotal = existingDetail.Quantity * product.Price;
                _context.OrderDetails.Update(existingDetail);
            }
            else
            {
                var orderDetail = new OrderDetail
                {
                    ItemNo = CurrentOrderDetails.Count > 0 ? CurrentOrderDetails.Max(x => x.ItemNo) + 1 : 1,
                    ProductName = product.Name,
                    ProductId = product.Id,
                    Quantity = 1,
                    UnitPrice = product.Price,
                    Subtotal = product.Price,
                    OrderId = CurrentOrder.Id
                };
                _context.OrderDetails.Add(orderDetail);
                CurrentOrderDetails.Add(orderDetail);
            }


            var table = _context.Tables.FirstOrDefault(t => t.Id == CurrentOrder.TableId);
            if (table != null && table.Status != "Dolu")
            {
                table.Status = "Dolu";
                _context.Tables.Update(table);
            }

            _context.SaveChanges();

            if (_tablePanels.TryGetValue(CurrentOrder.TableId, out var tablePanel))
            {
                tablePanel.BackColor = GetPanelColor("Dolu");

                var statusLabel = tablePanel.Controls
                    .OfType<Label>()
                    .FirstOrDefault(l => l.Text.StartsWith("Durum:"));
                if (statusLabel != null)
                    statusLabel.Text = "Durum: Dolu";

                var statusDot = tablePanel.Controls
                    .OfType<Panel>()
                    .FirstOrDefault(p => p.Width == 16 && p.Height == 16);
                if (statusDot != null)
                    statusDot.Invalidate();
            }

            dgOrderItems.DataSource = null;
            dgOrderItems.DataSource = CurrentOrderDetails;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();
            OrderCalculate();
        }

        void OrderCalculate()
        {
            try
            {
                decimal total = 0;
                foreach (var item in CurrentOrderDetails)
                {
                    total += item.Subtotal;
                }
                lblTotal.Text = total.ToString();
                CurrentOrder.TotalPrice = total;
                _context.SaveChanges();

            }
            catch (Exception)
            {

                //throw;
            }

        }
        private void LoadCategories()
        {
            panelProductCaregory.Controls.Clear();
            panelProductCaregory.AutoScroll = true;

            panelProductCaregory.Height = 90;

            var categories = _context.Categories.ToList();
            int x = 0;
            int y = 5;
            int spacing = 10;
            int buttonWidth = 89;
            int buttonHeight = 50;

            foreach (var category in categories)
            {
                var btn = new Button()
                {
                    Size = new Size(buttonWidth, buttonHeight),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(59, 130, 246),
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.FromArgb(147, 197, 253) },
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.White,
                    Text = category.Name,

                };
                btn.Click += Btn_Click;
                panelProductCaregory.Controls.Add(btn);
                if (panelProductCaregory.Controls.Count == 1)
                {
                    Btn_Click(btn, null);
                }

            }

            panelProductCaregory.HorizontalScroll.Enabled = true;
            panelProductCaregory.HorizontalScroll.Visible = true;
            panelProductCaregory.VerticalScroll.Enabled = false;
            panelProductCaregory.VerticalScroll.Visible = false;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            LoadProducts(((Button)sender).Text);
        }

        private void LoadTables()
        {
            pnlTable.Controls.Clear();
            _tablePanels.Clear();

            var tables = _context.Tables.ToList();
            int panelWidth = 160;
            int panelHeight = 120;
            int margin = 12;
            int panelsPerRow = 4;

            for (int i = 0; i < tables.Count; i++)
            {
                var table = tables[i];
                var panel = CreateTablePanel(table, panelWidth, panelHeight);

                int row = i / panelsPerRow;
                int col = i % panelsPerRow;

                panel.Location = new Point(
                    margin + (col * (panelWidth + margin)),
                    margin + (row * (panelHeight + margin))
                );

                pnlTable.Controls.Add(panel);
                _tablePanels.Add(table.Id, panel);
            }
        }

        private Panel CreateTablePanel(TableEntity table, int width, int height)
        {
            var panel = new Panel
            {
                Width = width,
                Height = height,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = table.Id,
                BackColor = GetPanelColor(table.Status),
                Cursor = Cursors.Hand,
                Margin = new Padding(10)
            };

            // Table name
            var nameLabel = new Label
            {
                Text = $"Masa: {table.Name}",
                Location = new Point(10, 10),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            // Status
            var statusLabel = new Label
            {
                Text = $"Durum: {table.Status}",
                Location = new Point(10, 35),
                AutoSize = true,
                Font = new Font("Segoe UI", 9)
            };


            // Status indicator (dot)
            var statusDot = new Panel
            {
                Width = 16,
                Height = 16,
                BackColor = Color.Transparent,
                Location = new Point(panel.Width - 22, 6),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, statusDot.Width, statusDot.Height);
            statusDot.Region = new Region(path);

            statusDot.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (SolidBrush brush = new SolidBrush(GetDotColor(table.Status)))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, statusDot.Width - 1, statusDot.Height - 1);
                }
            };
            panel.Controls.Add(statusDot);


            panel.Click += (sender, e) =>
            {
                pnlFilter.Visible = false;
                pnlTableInfo.Visible = true;
                pnlMain.Panel1Collapsed = true;
                CurrentOrder = _context.Orders.Select(o => o).FirstOrDefault(o => o.TableId == table.Id && (o.OrderStatusId == 2 || o.OrderStatusId == 3));
                if (CurrentOrder == null)
                {
                    CurrentOrder = new Order { UserId = CurrentUser.User.Id, TableId = table.Id, CreatedAt = DateTime.Now, TotalPrice = 0, IsPaid = false, OrderStatusId = 2 };
                    _context.Orders.Add(CurrentOrder);
                    _context.SaveChanges();
                    CurrentOrderDetails = new List<OrderDetail>();
                }
                else
                {
                    CurrentOrderDetails = _context.OrderDetails.Where(o => o.OrderId == CurrentOrder.Id).ToList();
                }

                dgOrderItems.DataSource = null;
                dgOrderItems.DataSource = CurrentOrderDetails;
                OrderCalculate();
                pnlTable.Visible = false;

                LoadProducts();
                PanelProductMenu.Visible = true;
                lblCurrenTable.Text = $"{table.Name}";
            };

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(statusLabel);
            panel.Controls.Add(statusDot);

            return panel;
        }

        private Color GetPanelColor(string status)
        {
            return status switch
            {
                "Boş" => Color.LightGreen,
                "Dolu" => Color.LightCoral,
                "Rezerve" => Color.LightYellow,
                _ => Color.LightGray
            };
        }

        private Color GetDotColor(string status)
        {
            return status switch
            {
                "Boş" => Color.Green,
                "Dolu" => Color.Red,
                "Rezerve" => Color.Orange,
                _ => Color.Gray
            };
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CurrentOrder = null;
            dgOrderItems.DataSource = null;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();
            pnlTable.Visible = true;
            PanelProductMenu.Visible = false;
            pnlFilter.Visible = true;
            pnlTableInfo.Visible = false;
            pnlMain.Panel1Collapsed = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void InitializeOrderStatusComboBox()
        {
        
            cmbTableStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTableStatus.Items.Add("Tümü");
            cmbTableStatus.Items.Add("Boş");
            cmbTableStatus.Items.Add("Dolu");
            cmbTableStatus.Items.Add("Rezerve");
            cmbTableStatus.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            pnlTable.Controls.Clear();
            int panelWidth = 160;
            int panelHeight = 120;
            int margin = 12;
            int panelsPerRow = 4;
            int visiblePanelCount = 0;

            foreach (var panel in _tablePanels.Values)
            {
                var tableId = (Guid)panel.Tag;
                var table = _context.Tables.Find(tableId);

                if (table != null)
                {
                    bool shouldShow = true;

                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        string search = txtSearch.Text.Trim().ToLower();
                        if (!table.Name.ToLower().Contains(search))
                        {
                            shouldShow = false;
                        }
                    }

                    if (cmbTableStatus.SelectedIndex > 0)
                    {
                        var selectedTableStatus = cmbTableStatus.SelectedItem.ToString();
                        if (table.Status != selectedTableStatus)
                        {
                            shouldShow = false;
                        }
                    }

                    if (shouldShow)
                    {
                        int row = visiblePanelCount / panelsPerRow;
                        int col = visiblePanelCount % panelsPerRow;

                        panel.Location = new Point(
                            margin + (col * (panelWidth + margin)),
                            margin + (row * (panelHeight + margin))
                        );

                        pnlTable.Controls.Add(panel);
                        visiblePanelCount++;
                    }
                }
            }
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.User != null)
            {
                lblUsername.Text = CurrentUser.User.Name;
                lblRole.Text = CurrentUser.User.UserRole?.Name ?? "Rol Yok";
            }

            LoadTables();
            pnlTable.Dock = DockStyle.Fill;
            pnlTable.Visible = true;
            pnlTable.BringToFront();
            PanelProductMenu.Visible = false;
            dgOrderItems.AutoGenerateColumns = false;
            DataGridViewStyle.ApplyStyle(dgOrderItems, DataGridViewStyle.GridStyle.SleekBlue);

        }

        private void cmbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbTableStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void PanelProductMenu_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnOrderSave_Click(object sender, EventArgs e)
        {
            OrderCalculate();

            if (CurrentOrder == null || CurrentOrderDetails == null || !CurrentOrderDetails.Any())
            {
                MessageBox.Show("Tamamlanacak bir sipariş yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal total = CurrentOrderDetails.Sum(d => d.Subtotal);

            var table = _context.Tables.FirstOrDefault(t => t.Id == CurrentOrder.TableId);

            string summary = $"Sipariş Özeti\n\nMasa: {table?.Name}\nTutar: ₺{total:0.00}\n\nÜrünler:\n";
            foreach (var detail in CurrentOrderDetails)
            {
                summary += $"- {detail.ProductName} x{detail.Quantity} = ₺{detail.Subtotal:0.00}\n";
            }

            var result = MessageBox.Show(summary + "\nSiparişi tamamlamak istiyor musunuz?", "Sipariş Tamamla", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            CurrentOrder.TotalPrice = total;
            CurrentOrder.IsPaid = true;
            CurrentOrder.ClosedAt = DateTime.Now;
            CurrentOrder.OrderStatusId = 1001;

            if (table != null)
            {
                table.Status = "Boş";
                _context.Tables.Update(table);
            }

            _context.Database.ExecuteSqlRaw("DELETE FROM OrderDetails WHERE OrderId = {0}", CurrentOrder.Id);
            foreach (var item in CurrentOrderDetails)
            {
                item.Id = 0;
                item.OrderId = CurrentOrder.Id;
                _context.OrderDetails.Add(item);
            }

            _context.Orders.Update(CurrentOrder);
            _context.SaveChanges();

            CurrentOrder = null;
            CurrentOrderDetails.Clear();
            dgOrderItems.DataSource = null;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();

            pnlTable.Visible = true;
            PanelProductMenu.Visible = false;
            LoadTables();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var detailToRemove = CurrentOrderDetails.FirstOrDefault(x => x.ItemNo == SelectedRowId);
            if (detailToRemove != null)
            {
                if (detailToRemove.Id > 0)
                {
                    _context.OrderDetails.Remove(detailToRemove);
                    _context.SaveChanges();
                }
                CurrentOrderDetails.Remove(detailToRemove);
            }

            dgOrderItems.DataSource = null;
            dgOrderItems.DataSource = CurrentOrderDetails;

            if (CurrentOrderDetails.Count == 0 && CurrentOrder != null)
            {
                var table = _context.Tables.FirstOrDefault(t => t.Id == CurrentOrder.TableId);
                if (table != null && table.Status != "Boş")
                {
                    table.Status = "Boş";
                    _context.Tables.Update(table);
                    _context.SaveChanges();
                }

                if (_tablePanels.TryGetValue(CurrentOrder.TableId, out var tablePanel))
                {
                    tablePanel.BackColor = GetPanelColor("Boş");

                    var statusLabel = tablePanel.Controls
                        .OfType<Label>()
                        .FirstOrDefault(l => l.Text.StartsWith("Durum:"));
                    if (statusLabel != null)
                        statusLabel.Text = "Durum: Boş";

                    var statusDot = tablePanel.Controls
                        .OfType<Panel>()
                        .FirstOrDefault(p => p.Width == 16 && p.Height == 16);
                    if (statusDot != null)
                        statusDot.Invalidate();
                }
            }

            OrderCalculate();
        }

        private void btnOrderDelete_Click(object sender, EventArgs e)
        {
            if (CurrentOrder == null || CurrentOrderDetails == null || !CurrentOrderDetails.Any())
            {
                MessageBox.Show("Silinecek ürün yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Tüm ürünleri silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            foreach (var detail in CurrentOrderDetails.ToList())
            {
                if (detail.Id > 0)
                    _context.OrderDetails.Remove(detail);
            }
            _context.SaveChanges();

            CurrentOrderDetails.Clear();

            var table = _context.Tables.FirstOrDefault(t => t.Id == CurrentOrder.TableId);
            if (table != null && table.Status != "Boş")
            {
                table.Status = "Boş";
                _context.Tables.Update(table);
                _context.SaveChanges();
            }

            if (_tablePanels.TryGetValue(CurrentOrder.TableId, out var tablePanel))
            {
                tablePanel.BackColor = GetPanelColor("Boş");

                var statusLabel = tablePanel.Controls
                    .OfType<Label>()
                    .FirstOrDefault(l => l.Text.StartsWith("Durum:"));
                if (statusLabel != null)
                    statusLabel.Text = "Durum: Boş";

                var statusDot = tablePanel.Controls
                    .OfType<Panel>()
                    .FirstOrDefault(p => p.Width == 16 && p.Height == 16);
                if (statusDot != null)
                    statusDot.Invalidate();
            }

            dgOrderItems.DataSource = null;
            dgOrderItems.DataSource = CurrentOrderDetails;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();
            OrderCalculate();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (CurrentOrderDetails == null || !CurrentOrderDetails.Any())
            {
                MessageBox.Show("Silinecek ürün yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var detail = CurrentOrderDetails.FirstOrDefault(x => x.ItemNo == SelectedRowId);
            if (detail == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (detail.Quantity > 1)
            {
                detail.Quantity -= 1;
                detail.Subtotal = detail.Quantity * detail.UnitPrice;
                _context.OrderDetails.Update(detail);
            }
            else
            {
                if (detail.Id > 0)
                {
                    _context.OrderDetails.Remove(detail);
                }
                CurrentOrderDetails.Remove(detail);
            }

            _context.SaveChanges();

            dgOrderItems.DataSource = null;
            dgOrderItems.DataSource = CurrentOrderDetails;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();

            if (CurrentOrderDetails.Count == 0 && CurrentOrder != null)
            {
                var table = _context.Tables.FirstOrDefault(t => t.Id == CurrentOrder.TableId);
                if (table != null && table.Status != "Boş")
                {
                    table.Status = "Boş";
                    _context.Tables.Update(table);
                    _context.SaveChanges();
                }

                if (_tablePanels.TryGetValue(CurrentOrder.TableId, out var tablePanel))
                {
                    tablePanel.BackColor = GetPanelColor("Boş");

                    var statusLabel = tablePanel.Controls
                        .OfType<Label>()
                        .FirstOrDefault(l => l.Text.StartsWith("Durum:"));
                    if (statusLabel != null)
                        statusLabel.Text = "Durum: Boş";

                    var statusDot = tablePanel.Controls
                        .OfType<Panel>()
                        .FirstOrDefault(p => p.Width == 16 && p.Height == 16);
                    if (statusDot != null)
                        statusDot.Invalidate();
                }
            }

            OrderCalculate();
        }

        private void dgOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgOrderItems.Rows.Count)
                return;

            SelectedRowId = (int)dgOrderItems.Rows[e.RowIndex].Cells["ItemNo"].Value;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
