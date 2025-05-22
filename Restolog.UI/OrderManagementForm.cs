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

        void AddOrderItem()
        {

        }

        private void LoadProducts(string Category = "")
        {
            panelProduct.Controls.Clear();
            LoadCategories();
            var products = _context.Products.Where(p => p.Category.Name == Category);
            foreach (var product in products)
            {
                var productPanel = new Panel
                {
                    Width = 160,
                    Height = 120,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = product.Id,
                    BackColor = Color.LightBlue,
                    Cursor = Cursors.Hand,
                    Margin = new Padding(10)
                };
                var nameLabel = new Label
                {
                    Text = $"Ürün: {product.Name}",
                    Location = new Point(10, 10),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                var priceLabel = new Label
                {
                    Text = $"Fiyat: {product.Price}",
                    Location = new Point(10, 35),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9)
                };
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(priceLabel);
                panelProduct.Controls.Add(productPanel);
                productPanel.Tag = product;
                productPanel.Click += (sender, e) =>
                {
                    var selectedProduct = (Product)((Panel)sender).Tag;

                    var SearcProduct = CurrentOrderDetails?.Where(o => o.ProductId == selectedProduct.Id).FirstOrDefault();
                    if (SearcProduct != null)
                    {
                        SearcProduct.Quantity += 1;
                        SearcProduct.Subtotal = SearcProduct.Quantity * selectedProduct.Price;
                        dgOrderItems.DataSource = null;
                        dgOrderItems.DataSource = CurrentOrderDetails;
                        dgOrderItems.Refresh();
                        dgOrderItems.Invalidate();

                    }
                    else
                    {

                        var orderDetail = new OrderDetail
                        {
                            Id = CurrentOrderDetails.Count + 1,
                            ProductName = selectedProduct.Name,
                            ProductId = selectedProduct.Id,
                            Quantity = 1,
                            UnitPrice = selectedProduct.Price,
                            Subtotal = selectedProduct.Price
                        };
                        CurrentOrderDetails.Add(orderDetail);
                        dgOrderItems.DataSource = null;
                        dgOrderItems.DataSource = CurrentOrderDetails;
                        dgOrderItems.Refresh();
                        dgOrderItems.Invalidate();
                    }
                    OrderCalculate();

                };
            }
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

            var categories = _context.Categories.ToList();
            foreach (var category in categories)
            {
                var btn = new Button()
                {
                    Size = new Size(150, 40),
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, BorderColor = Color.DarkRed },
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Text = category.Name
                };
                btn.Click += Btn_Click;
                panelProductCaregory.Controls.Add(btn);
            }
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
                CurrentOrder = _context.Orders.Select(o => o).FirstOrDefault(o => o.TableId == table.Id && (o.OrderStatusId == 2 || o.OrderStatusId == 3));
                if (CurrentOrder == null)
                {
                    CurrentOrder = new Order { UserId = CurrentUser.User.Id, TableId = table.Id, CreatedAt = DateTime.Now, TotalPrice = 0, IsPaid = false, OrderStatusId = 2 };
                    _context.Orders.Add(CurrentOrder);
                    table.Status = "Dolu";
                    _context.Tables.Update(table);
                    _context.SaveChanges();
                }
                else
                {
                    table.Status = "Dolu";
                    _context.SaveChanges();
                    CurrentOrderDetails = _context.OrderDetails.Where(o => o.OrderId == CurrentOrder.Id).ToList();

                    for (int i = 0; i < CurrentOrderDetails.Count; i++)
                    {
                        CurrentOrderDetails[i].Id = i;
                    }
                    dgOrderItems.DataSource = null;
                    dgOrderItems.DataSource = CurrentOrderDetails;
                    OrderCalculate();

                }
                LoadProducts();
                pnlTable.Visible = false;
                PanelProductMenu.Visible = true;

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

        private void OpenOrderForm(TableEntity table)
        {
            // TODO: Sipariş formunu aç
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CurrentOrder = null;
                      dgOrderItems.DataSource = null;
            dgOrderItems.Refresh();
            dgOrderItems.Invalidate();
            pnlTable.Visible = true;
            PanelProductMenu.Visible = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }

        private void InitializeOrderStatusComboBox()
        {
            cmbOrderStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            var orderStatuses = _context.OrderStatuses.ToList();
            cmbOrderStatus.Items.Add("Tümü");
            foreach (var status in orderStatuses)
            {
                cmbOrderStatus.Items.Add(status.StatusName);
            }
            cmbOrderStatus.SelectedIndex = 0;

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

                    if (cmbOrderStatus.SelectedIndex > 0)
                    {
                        var selectedStatus = cmbOrderStatus.SelectedItem.ToString();
                        var tableOrder = _context.Orders
                            .Where(o => o.TableId == table.Id)
                            .OrderByDescending(o => o.CreatedAt)
                            .FirstOrDefault();

                        if (tableOrder?.OrderStatus?.StatusName != selectedStatus)
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
            if (CurrentOrder != null)
            {
                CurrentOrder.OrderStatusId = 3; // Sipariş tamamlandı



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
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < CurrentOrderDetails.Count; i++)
            {
                if (CurrentOrderDetails[i].Id == SelectedRowId)
                {
                    CurrentOrderDetails.Remove(CurrentOrderDetails[i]);
                    break;
                }

            }
            for (int i = 0; i < CurrentOrderDetails.Count; i++)
            {
                CurrentOrderDetails[i].Id = i;
            }

            dgOrderItems.DataSource = null;
            dgOrderItems.DataSource = CurrentOrderDetails;
        }

        private void dgOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRowId = (int)dgOrderItems.Rows[e.RowIndex].Cells["ItemId"].Value;
        }
    }
}
