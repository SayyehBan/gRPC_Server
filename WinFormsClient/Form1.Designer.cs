namespace WinFormsClient
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            TxtPrice = new TextBox();
            label3 = new Label();
            TxtName = new TextBox();
            label2 = new Label();
            TxtBrand = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(TxtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtBrand);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(152, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(22, 25);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 6;
            button1.Text = "افزودن کالا به سرور";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtPrice
            // 
            TxtPrice.Location = new Point(180, 25);
            TxtPrice.Name = "TxtPrice";
            TxtPrice.Size = new Size(100, 23);
            TxtPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 29);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "قیمت:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(318, 25);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(100, 23);
            TxtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 29);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "نام :";
            // 
            // TxtBrand
            // 
            TxtBrand.Location = new Point(445, 25);
            TxtBrand.Name = "TxtBrand";
            TxtBrand.Size = new Size(100, 23);
            TxtBrand.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(545, 29);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "برند :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(191, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(537, 178);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(556, 90);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 7;
            button2.Text = "دریافت از سرور";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 325);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtPrice;
        private Label label3;
        private TextBox TxtName;
        private Label label2;
        private TextBox TxtBrand;
        private Label label1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Button button2;
    }
}
