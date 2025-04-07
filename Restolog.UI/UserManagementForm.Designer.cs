namespace Restolog.UI
{
    partial class UserManagementForm
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
            label7 = new Label();
            textBox1 = new TextBox();
            btnLogin = new Button();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label3 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(181, 21);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Yönetim Paneli";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(btnLogin);
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(188, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(834, 72);
            panel3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(121, 13);
            label7.Name = "label7";
            label7.Size = new Size(35, 21);
            label7.TabIndex = 29;
            label7.Text = "Ara";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(121, 39);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 28;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(309, 39);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(71, 23);
            btnLogin.TabIndex = 27;
            btnLogin.Text = "Uygula";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 46);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 19);
            checkBox2.TabIndex = 26;
            checkBox2.Text = "Pasif Kullanıcılar";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 21);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Aktif Kullanıcılar";
            checkBox1.UseVisualStyleBackColor = true;
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
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(188, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(834, 399);
            panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(827, 391);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(13, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 477);
            panel1.TabIndex = 6;
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
            // button5
            // 
            button5.BackColor = Color.Peru;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(3, 180);
            button5.Name = "button5";
            button5.Size = new Size(161, 41);
            button5.TabIndex = 10;
            button5.Text = "Kullanıcı Düzenle";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(3, 133);
            button4.Name = "button4";
            button4.Size = new Size(161, 41);
            button4.TabIndex = 9;
            button4.Text = "Kullanıcı Sil";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(3, 86);
            button3.Name = "button3";
            button3.Size = new Size(161, 41);
            button3.TabIndex = 8;
            button3.Text = "Kullanıcı Ekle";
            button3.UseVisualStyleBackColor = false;
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
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1034, 521);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserManagementForm";
            Text = "Kullanıcı Yönetimi ";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label3;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label7;
        private TextBox textBox1;
        private Button btnLogin;
    }
}