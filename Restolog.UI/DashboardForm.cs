using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Restolog.DataAccess;

namespace Restolog.UI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            InitializeOrderReportFilter();
            ApplyOrderReportStyle();
            LoadOrderReport();
        }

        private void InitializeOrderReportFilter()
        {
            cmbOrderFilter.Items.Clear();
            cmbOrderFilter.Items.Add("Tümü");
            cmbOrderFilter.Items.Add("Bugün");
            cmbOrderFilter.Items.Add("Bu Hafta");
            cmbOrderFilter.Items.Add("Bu Ay");
            cmbOrderFilter.Items.Add("Bu Yıl");
            cmbOrderFilter.SelectedIndex = 0;
            cmbOrderFilter.SelectedIndexChanged += (s, e) => LoadOrderReport();

            using (var context = new RestologContext())
            {
                var users = context.Users.OrderBy(u => u.Name).ToList();
                cmbUserFilter.Items.Clear();
                cmbUserFilter.Items.Add(new { Id = Guid.Empty, Name = "Tümü" });
                foreach (var user in users)
                {
                    cmbUserFilter.Items.Add(new { user.Id, user.Name });
                }
                var tables = context.Tables.OrderBy(t => t.Name).ToList();
                cmbTableFilter.Items.Clear();
                cmbTableFilter.Items.Add(new { Id = Guid.Empty, Name = "Tümü" });
                foreach (var table in tables)
                {
                    cmbTableFilter.Items.Add(new { table.Id, table.Name });
                }
            }
            cmbUserFilter.DisplayMember = "Name";
            cmbUserFilter.ValueMember = "Id";
            cmbUserFilter.SelectedIndex = 0;
            cmbUserFilter.SelectedIndexChanged += (s, e) => LoadOrderReport();

            cmbTableFilter.DisplayMember = "Name";
            cmbTableFilter.ValueMember = "Id";
            cmbTableFilter.SelectedIndex = 0;
            cmbTableFilter.SelectedIndexChanged += (s, e) => LoadOrderReport();
        }

        private void ApplyOrderReportStyle()
        {
            DataGridViewStyle.ApplyStyle(dgvOrderReports, DataGridViewStyle.GridStyle.SleekBlue);

            lblTotalOrders.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblTotalRevenue.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPaidOrders.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void LoadOrderReport()
        {
            using var context = new RestologContext();
            var ordersQuery = context.Orders.AsQueryable();

            // Tarih filtresi
            if (cmbOrderFilter.SelectedItem != null)
            {
                var filter = cmbOrderFilter.SelectedItem.ToString();
                if (filter == "Bugün")
                {
                    var today = DateTime.Today;
                    ordersQuery = ordersQuery.Where(o => o.CreatedAt.Date == today);
                }
                else if (filter == "Bu Hafta")
                {
                    var today = DateTime.Today;
                    var diff = (int)today.DayOfWeek - (int)DayOfWeek.Monday;
                    if (diff < 0) diff += 7;
                    var weekStart = today.AddDays(-diff);
                    var weekEnd = weekStart.AddDays(7);
                    ordersQuery = ordersQuery.Where(o => o.CreatedAt.Date >= weekStart && o.CreatedAt.Date < weekEnd);
                }
                else if (filter == "Bu Ay")
                {
                    var now = DateTime.Now;
                    ordersQuery = ordersQuery.Where(o => o.CreatedAt.Year == now.Year && o.CreatedAt.Month == now.Month);
                }
                else if (filter == "Bu Yıl")
                {
                    var now = DateTime.Now;
                    ordersQuery = ordersQuery.Where(o => o.CreatedAt.Year == now.Year);
                }
            }

            if (cmbUserFilter.SelectedIndex > 0)
            {
                dynamic selectedUser = cmbUserFilter.SelectedItem;
                Guid selectedUserId = selectedUser.Id;
                ordersQuery = ordersQuery.Where(o => o.UserId == selectedUserId);
            }

            if (cmbTableFilter.SelectedIndex > 0)
            {
                dynamic selectedTable = cmbTableFilter.SelectedItem;
                Guid selectedTableId = selectedTable.Id;
                if (selectedTableId != Guid.Empty)
                    ordersQuery = ordersQuery.Where(o => o.TableId == selectedTableId);
            }

            var orders = ordersQuery
                .Select(o => new
                {
                    Masa = o.Table.Name,
                    Kullanıcı = o.User.Name,
                    Tarih = o.CreatedAt,
                    Tutar = o.TotalPrice,
                    Durum = o.IsPaid ? "Ödendi" : "Bekliyor"
                })
                .OrderByDescending(o => o.Tarih)
                .ToList();

            dgvOrderReports.DataSource = orders;

            lblTotalOrders.Text = $"Toplam Sipariş: {orders.Count}";
            lblTotalRevenue.Text = $"Toplam Ciro: ₺{orders.Sum(x => x.Tutar):0.00}";
            lblPaidOrders.Text = $"Ödenen Sipariş: {orders.Count(x => x.Durum == "Ödendi")}";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}