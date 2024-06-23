using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    partial class addBook
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
            textBox11 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox33 = new TextBox();
            label3 = new Label();
            textBox22 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox11
            // 
            textBox11.Location = new Point(169, 12);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(359, 27);
            textBox11.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(79, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 1;
            label1.Text = "ISBN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(79, 150);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // textBox33
            // 
            textBox33.Location = new Point(169, 150);
            textBox33.Name = "textBox33";
            textBox33.Size = new Size(359, 27);
            textBox33.TabIndex = 2;
            textBox33.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(79, 79);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 5;
            label3.Text = "Title";
            label3.Click += label3_Click;
            // 
            // textBox22
            // 
            textBox22.Location = new Point(169, 79);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(359, 27);
            textBox22.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(4, 212);
            label6.Name = "label6";
            label6.Size = new Size(159, 28);
            label6.TabIndex = 7;
            label6.Text = "Publishing_Year";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(210, 313);
            button1.Name = "button1";
            button1.Size = new Size(133, 63);
            button1.TabIndex = 12;
            button1.Text = "Add Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(169, 212);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(359, 27);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(79, 270);
            label4.Name = "label4";
            label4.Size = new Size(53, 28);
            label4.TabIndex = 17;
            label4.Text = "P_ID";
            label4.Click += label4_Click_1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "77", "88" });
            comboBox1.Location = new Point(169, 270);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(359, 28);
            comboBox1.TabIndex = 18;
            // 
            // addBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(577, 388);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBox22);
            Controls.Add(label2);
            Controls.Add(textBox33);
            Controls.Add(label1);
            Controls.Add(textBox11);
            Name = "addBook";
            Text = "addBook";
            Load += addBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox11;
        private Label label1;
        private Label label2;
        private TextBox textBox33;
        private Label label3;
        private TextBox textBox22;
        private Label label6;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private ComboBox comboBox1;
    }
}