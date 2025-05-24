using System;
using System.Drawing;
using System.Windows.Forms;

public class DataGridViewStyle
{
    public enum GridStyle
    {
        SleekBlue,
        MidnightPurple,
        MinimalistGray,
        VibrantTeal,
        SoftCoral
    }

    public static void ApplyStyle(DataGridView dgv, GridStyle style)
    {
        // Varsayılan ayarları sıfırla
        dgv.BackgroundColor = Color.White;
        dgv.DefaultCellStyle.BackColor = Color.White;
        dgv.DefaultCellStyle.ForeColor = Color.Black;
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        dgv.EnableHeadersVisualStyles = false;
        dgv.RowHeadersVisible = false; // Satır başlıklarını kaldır
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        dgv.GridColor = Color.LightSteelBlue; // Grid çizgilerini kaldır
        dgv.DefaultCellStyle.Font = new Font("Roboto", 10);
        dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Bold);

        switch (style)
        {
            case GridStyle.SleekBlue:
                // Şık Mavi Tema
                dgv.BackgroundColor = Color.FromArgb(238, 242, 255);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(17, 24, 39);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(59, 130, 246);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);
                break;

            case GridStyle.MidnightPurple:
                // Gece Moru Tema
                dgv.BackgroundColor = Color.FromArgb(30, 25, 43);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(49, 46, 129);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(224, 231, 255);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 70, 229);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(67, 56, 202);
                break;

            case GridStyle.MinimalistGray:
                // Minimalist Gri Tema
                dgv.BackgroundColor = Color.FromArgb(243, 244, 246);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(31, 41, 55);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(107, 114, 128);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(249, 250, 251);
                break;

            case GridStyle.VibrantTeal:
                // Canlı Turkuaz Tema
                dgv.BackgroundColor = Color.FromArgb(236, 254, 255);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(19, 78, 94);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 148, 136);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
                break;

            case GridStyle.SoftCoral:
                // Yumuşak Mercan Tema
                dgv.BackgroundColor = Color.FromArgb(255, 241, 242);
                dgv.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                dgv.DefaultCellStyle.ForeColor = Color.FromArgb(124, 45, 18);
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(244, 114, 182);
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 247, 237);
                break;
        }

        // Ortak ayarlar
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        dgv.ColumnHeadersHeight = 40;
        dgv.RowTemplate.Height = 35;
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(147, 197, 253);
        dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 24, 39);
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.BorderStyle = BorderStyle.None; // Kenarlıkları kaldır
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None; // Hücre kenarlıklarını kaldır
    }
}