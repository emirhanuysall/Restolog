namespace Restolog.UI;

partial class BaseForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        label1 = new Label();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.BackColor = Color.LightSkyBlue;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
        button1.Location = new Point(145, 161);
        button1.Name = "button1";
        button1.Size = new Size(157, 56);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
        label1.Location = new Point(114, 46);
        label1.Name = "label1";
        label1.Size = new Size(57, 21);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // textBox1
        // 
        textBox1.BackColor = SystemColors.ScrollBar;
        textBox1.BorderStyle = BorderStyle.None;
        textBox1.Location = new Point(387, 200);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 2;
        // 
        // BaseForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSteelBlue;
        ClientSize = new Size(800, 450);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "BaseForm";
        Text = "BaseForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private TextBox textBox1;
}
