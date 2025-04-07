namespace Restolog.UI
{
    partial class MenuMangementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 17;
            label1.Text = "Menü Yönetim Paneli";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(188, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 72);
            panel3.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 7;
            label3.Text = "Filtreleme";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(188, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 399);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 477);
            panel1.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(3, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(161, 58);
            panel4.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(42, 37);
            label6.Name = "label6";
            label6.Size = new Size(37, 13);
            label6.TabIndex = 10;
            label6.Text = "Rolü :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(3, 19);
            label5.Name = "label5";
            label5.Size = new Size(76, 13);
            label5.TabIndex = 9;
            label5.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 13);
            label4.TabIndex = 7;
            label4.Text = "Aktif Kullanıcı Bilgiler";
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(3, 384);
            button2.Name = "button2";
            button2.Size = new Size(161, 41);
            button2.TabIndex = 7;
            button2.Text = "Önceki Sayfaya Dön";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(3, 431);
            button1.Name = "button1";
            button1.Size = new Size(161, 41);
            button1.TabIndex = 6;
            button1.Text = "Çıkış Yap";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(-1, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 6;
            label2.Text = "İşlemler";
            // 
            // MenuMangementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1034, 521);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuMangementForm";
            Text = "Menü Yönetimi";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label2;
    }
}