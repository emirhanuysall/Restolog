using Restolog.DataAccess;
using Restolog.DataAccess.Concrete;
using Restolog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restolog.UI
{
    public partial class OrderForm : Form
    {
        private readonly RestologContext _context;
        private readonly EfProductRepository _productRepo;
        private Order _activeOrder;
        private readonly TableEntity _table;
        private readonly User _currentUser;



        public OrderForm(TableEntity table, User currentUser)
        {
            InitializeComponent();
            _context = new RestologContext();
            _productRepo = new EfProductRepository(_context);
            _table = table;
            _currentUser = currentUser; 


            this.StartPosition = FormStartPosition.CenterScreen;

            lblTableName.Text = $"Masa: {_table.Name}";

            InitializeDataGridView();
            LoadProducts();
            LoadOrCreateOrder();
            LoadOrderDetails();
        }

        private void LoadProducts()
        {
            var products = _productRepo.GetAll();
            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";

            dgvOrderItems.DataSource = products.Select(p => new
            {
                Ürün = p.Name,
                Açıklama = p.Description,
                Fiyat = p.Price,
                Kategori = p.Category != null ? p.Category.Name : ""
            }).ToList();
        }

        private void LoadOrCreateOrder()
        {
            _activeOrder = _context.Orders
                .Where(o => o.TableId == _table.Id && o.IsPaid == false)
                .OrderByDescending(o => o.CreatedAt)
                .FirstOrDefault();

            if (_activeOrder == null)
            {
                _activeOrder = new Order
                {
                    Id = Guid.NewGuid(),
                    TableId = _table.Id,
                    UserId = _currentUser.Id, // Buraya dikkat
                    CreatedAt = DateTime.Now,
                    IsPaid = false,
                    TotalPrice = 0,
                    OrderStatusId = 1 // Örn: Yeni Sipariş
                };

                _context.Orders.Add(_activeOrder);
                _context.SaveChanges();
            }
        }


        private void LoadOrderDetails()
        {
            var details = _context.OrderDetails
                .Where(d => d.OrderId == _activeOrder.Id)
                .Select(d => new
                {
                    Ürün = d.Product!.Name,
                    Adet = d.Quantity,
                    Fiyat = d.UnitPrice,
                    Toplam = d.Subtotal
                })
                .ToList();

            dgvOrderItems.DataSource = details;

            dgvOrderItems.Columns[0].Width = 150;
            dgvOrderItems.Columns[1].Width = 60;
            dgvOrderItems.Columns[2].Width = 70;
            dgvOrderItems.Columns[3].Width = 80;

            lblTotal.Text = $"Toplam: {_activeOrder.TotalPrice:C2}";
        }

        private void InitializeDataGridView()
        {
            dgvOrderItems.EnableHeadersVisualStyles = false;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(34, 36, 49);
            dgvOrderItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrderItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrderItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrderItems.RowsDefaultCellStyle.BackColor = Color.FromArgb(40, 42, 54);
            dgvOrderItems.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvOrderItems.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(75, 75, 75);
            dgvOrderItems.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrderItems.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F);

            dgvOrderItems.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 52, 63);

            dgvOrderItems.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderItems.RowTemplate.Height = 40;
            dgvOrderItems.BackgroundColor = Color.FromArgb(48, 50, 61);

            foreach (DataGridViewColumn column in dgvOrderItems.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _context.Dispose();
            base.OnFormClosing(e);
        }
    }
}
