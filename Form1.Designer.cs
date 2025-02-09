namespace Converter_with_api
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Label lblToCurrency;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInput = new TextBox();
            comboBoxFromCurrency = new ComboBox();
            comboBoxToCurrency = new ComboBox();
            btnConvert = new Button();
            txtOutput = new TextBox();
            btnClear = new Button();
            lblAnnualSalary = new Label();
            lblToCurrency = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblResult = new Label();
            label5 = new Label();
            label6 = new Label();
            lblHomeCurrency = new Label();
            lblNewCurrency = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(430, 272);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(698, 31);
            txtInput.TabIndex = 0;
            txtInput.Text = "50";
            // 
            // comboBoxFromCurrency
            // 
            comboBoxFromCurrency.Location = new Point(430, 383);
            comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            comboBoxFromCurrency.Size = new Size(247, 33);
            comboBoxFromCurrency.TabIndex = 1;
            // 
            // comboBoxToCurrency
            // 
            comboBoxToCurrency.Location = new Point(888, 382);
            comboBoxToCurrency.Name = "comboBoxToCurrency";
            comboBoxToCurrency.Size = new Size(240, 33);
            comboBoxToCurrency.TabIndex = 2;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvert.Location = new Point(722, 458);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(142, 113);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert";
            btnConvert.Click += btnConvert_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(430, 631);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(698, 31);
            txtOutput.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(722, 683);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 70);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // lblAnnualSalary
            // 
            lblAnnualSalary.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnnualSalary.Location = new Point(722, 220);
            lblAnnualSalary.Name = "lblAnnualSalary";
            lblAnnualSalary.Size = new Size(203, 49);
            lblAnnualSalary.TabIndex = 6;
            lblAnnualSalary.Text = "Annual Salary";
            // 
            // lblToCurrency
            // 
            lblToCurrency.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblToCurrency.Location = new Point(722, 382);
            lblToCurrency.Name = "lblToCurrency";
            lblToCurrency.Size = new Size(132, 33);
            lblToCurrency.TabIndex = 8;
            lblToCurrency.Text = "To Currency";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(409, 785);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(409, 785);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(788, 391);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(409, 785);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(788, 391);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(753, 602);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(84, 26);
            lblResult.TabIndex = 12;
            lblResult.Text = "Result";
            // 
            // label5
            // 
            label5.Location = new Point(430, 102);
            label5.Name = "label5";
            label5.Size = new Size(725, 80);
            label5.TabIndex = 13;
            label5.Text = "So you got a remote job and you want to live the digital nomad life huh? Enter your annual salary and find out if you'll be living comfortably, lavishly, or if you'll be struggling in your new country";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(491, 23);
            label6.Name = "label6";
            label6.Size = new Size(544, 60);
            label6.TabIndex = 14;
            label6.Text = "Can You Survive The Move?";
            // 
            // lblHomeCurrency
            // 
            lblHomeCurrency.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblHomeCurrency.Location = new Point(455, 342);
            lblHomeCurrency.Name = "lblHomeCurrency";
            lblHomeCurrency.Size = new Size(170, 26);
            lblHomeCurrency.TabIndex = 15;
            lblHomeCurrency.Text = "Home Currency";
            // 
            // lblNewCurrency
            // 
            lblNewCurrency.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNewCurrency.Location = new Point(931, 342);
            lblNewCurrency.Name = "lblNewCurrency";
            lblNewCurrency.Size = new Size(170, 26);
            lblNewCurrency.TabIndex = 16;
            lblNewCurrency.Text = "New Currency";
            // 
            // Form1
            // 
            ClientSize = new Size(1533, 1190);
            Controls.Add(lblNewCurrency);
            Controls.Add(lblHomeCurrency);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(comboBoxFromCurrency);
            Controls.Add(comboBoxToCurrency);
            Controls.Add(btnConvert);
            Controls.Add(txtOutput);
            Controls.Add(btnClear);
            Controls.Add(lblAnnualSalary);
            Controls.Add(lblToCurrency);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Name = "Form1";
            Text = "Currency Converter";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblResult;
        private Label label5;
        private Label label6;
        private Label lblHomeCurrency;
        private Label lblNewCurrency;
    }
}
