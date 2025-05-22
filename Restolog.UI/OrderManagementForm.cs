using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restolog.Entities.Concrete;
using Restolog.DataAccess;
using System.Drawing.Drawing2D;

namespace Restolog.UI
{
    public partial class OrderManagementForm : Form
    {
        private readonly RestologContext _context;
        private Dictionary<Guid, Panel> _tablePanels;

        public OrderManagementForm()
        {
            InitializeComponent();
            _context = new RestologContext();
            _tablePanels = new Dictionary<Guid, Panel>();

            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeOrderStatusComboBox();
            LoadTables();
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
                MessageBox.Show($"Masa: {table.Name}\nDurum: {table.Status}", "Masa Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Close();
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
    }
}
