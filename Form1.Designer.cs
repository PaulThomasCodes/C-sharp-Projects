namespace ClientSessionTracker
{
    partial class Form1
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

        private void InitializeComponent()
        {
            txtClientName = new TextBox();
            dtpSessionDate = new DateTimePicker();
            txtSessionNotes = new RichTextBox();
            UpDownFee = new NumericUpDown();
            checkBoxPaid = new CheckBox();
            listViewSessions = new ListView();
            btnAddSession = new Button();
            lblUnpaidBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)UpDownFee).BeginInit();
            SuspendLayout();
            // 
            // txtClientName
            // 
            txtClientName.Location = new Point(12, 32);
            txtClientName.Name = "txtClientName";
            txtClientName.Size = new Size(200, 23);
            txtClientName.TabIndex = 0;
            txtClientName.TextChanged += txtClientName_TextChanged;
            // 
            // dtpSessionDate
            // 
            dtpSessionDate.Location = new Point(12, 70);
            dtpSessionDate.Name = "dtpSessionDate";
            dtpSessionDate.Size = new Size(200, 23);
            dtpSessionDate.TabIndex = 1;
            // 
            // txtSessionNotes
            // 
            txtSessionNotes.Location = new Point(12, 108);
            txtSessionNotes.Name = "txtSessionNotes";
            txtSessionNotes.Size = new Size(200, 80);
            txtSessionNotes.TabIndex = 2;
            txtSessionNotes.Text = "";
            // 
            // UpDownFee
            // 
            UpDownFee.Location = new Point(12, 198);
            UpDownFee.Name = "UpDownFee";
            UpDownFee.Size = new Size(120, 23);
            UpDownFee.TabIndex = 3;
            // 
            // checkBoxPaid
            // 
            checkBoxPaid.AutoSize = true;
            checkBoxPaid.Location = new Point(12, 234);
            checkBoxPaid.Name = "checkBoxPaid";
            checkBoxPaid.Size = new Size(49, 19);
            checkBoxPaid.TabIndex = 4;
            checkBoxPaid.Text = "Paid";
            checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // listViewSessions
            // 
            listViewSessions.Location = new Point(250, 32);
            listViewSessions.Name = "listViewSessions";
            listViewSessions.Size = new Size(400, 200);
            listViewSessions.TabIndex = 5;
            listViewSessions.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddSession
            // 
            btnAddSession.Location = new Point(12, 270);
            btnAddSession.Name = "btnAddSession";
            btnAddSession.Size = new Size(120, 23);
            btnAddSession.TabIndex = 6;
            btnAddSession.Text = "Add Session";
            btnAddSession.UseVisualStyleBackColor = true;
            btnAddSession.Click += btnAddSession_Click;
            // 
            // lblUnpaidBalance
            // 
            lblUnpaidBalance.AutoSize = true;
            lblUnpaidBalance.Location = new Point(250, 270);
            lblUnpaidBalance.Name = "lblUnpaidBalance";
            lblUnpaidBalance.Size = new Size(107, 15);
            lblUnpaidBalance.TabIndex = 7;
            lblUnpaidBalance.Text = "Unpaid Balance: $0";
            // 
            // Form1
            // 
            ClientSize = new Size(664, 311);
            Controls.Add(lblUnpaidBalance);
            Controls.Add(btnAddSession);
            Controls.Add(listViewSessions);
            Controls.Add(checkBoxPaid);
            Controls.Add(UpDownFee);
            Controls.Add(txtSessionNotes);
            Controls.Add(dtpSessionDate);
            Controls.Add(txtClientName);
            Name = "Form1";
            Text = "Client Session Tracker";
            ((System.ComponentModel.ISupportInitialize)UpDownFee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.RichTextBox txtSessionNotes;
        private System.Windows.Forms.NumericUpDown UpDownFee;
        private System.Windows.Forms.CheckBox checkBoxPaid;
        private System.Windows.Forms.ListView listViewSessions;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Label lblUnpaidBalance;
    }
}
