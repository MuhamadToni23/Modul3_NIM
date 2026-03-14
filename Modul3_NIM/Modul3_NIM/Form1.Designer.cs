namespace Modul3_NIM
{
    partial class Form1
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
            comboBoxAsal = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNilaiAwal = new TextBox();
            label3 = new Label();
            textBoxNilaiAkhir = new TextBox();
            Convert = new Button();
            label4 = new Label();
            comboBoxAkhir = new ComboBox();
            SuspendLayout();
            // 
            // comboBoxAsal
            // 
            comboBoxAsal.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAsal.FormattingEnabled = true;
            comboBoxAsal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxAsal.Location = new Point(70, 150);
            comboBoxAsal.Name = "comboBoxAsal";
            comboBoxAsal.Size = new Size(182, 33);
            comboBoxAsal.TabIndex = 0;
            comboBoxAsal.Tag = "";
            comboBoxAsal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 109);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 1;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 109);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 2;
            label2.Text = "Nilai Awal";
            // 
            // textBoxNilaiAwal
            // 
            textBoxNilaiAwal.Location = new Point(291, 152);
            textBoxNilaiAwal.Name = "textBoxNilaiAwal";
            textBoxNilaiAwal.Size = new Size(287, 31);
            textBoxNilaiAwal.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 196);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 4;
            label3.Text = "Nilai Akhir";
            // 
            // textBoxNilaiAkhir
            // 
            textBoxNilaiAkhir.Location = new Point(291, 233);
            textBoxNilaiAkhir.Name = "textBoxNilaiAkhir";
            textBoxNilaiAkhir.Size = new Size(287, 31);
            textBoxNilaiAkhir.TabIndex = 5;
            // 
            // Convert
            // 
            Convert.Location = new Point(606, 152);
            Convert.Name = "Convert";
            Convert.Size = new Size(112, 34);
            Convert.TabIndex = 7;
            Convert.Text = "Convert";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 196);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 8;
            label4.Text = "Satuan Akhir";
            // 
            // comboBoxAkhir
            // 
            comboBoxAkhir.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAkhir.FormattingEnabled = true;
            comboBoxAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            comboBoxAkhir.Location = new Point(70, 233);
            comboBoxAkhir.Name = "comboBoxAkhir";
            comboBoxAkhir.Size = new Size(182, 33);
            comboBoxAkhir.TabIndex = 9;
            comboBoxAkhir.Tag = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxAkhir);
            Controls.Add(label4);
            Controls.Add(Convert);
            Controls.Add(textBoxNilaiAkhir);
            Controls.Add(label3);
            Controls.Add(textBoxNilaiAwal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxAsal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxAsal;
        private Label label1;
        private Label label2;
        private TextBox textBoxNilaiAwal;
        private Label label3;
        private TextBox textBoxNilaiAkhir;
        private Button Convert;
        private Label label4;
        private ComboBox comboBoxAkhir;
    }
}
