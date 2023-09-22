namespace Basic_Queuing_Part2__TP_
{
    partial class QueuingForm
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
            label1 = new Label();
            lblQueue = new Label();
            btnCashier = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(169, 63);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 0;
            label1.Text = "Postion In Queue";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblQueue.Location = new Point(194, 103);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(109, 46);
            lblQueue.TabIndex = 1;
            lblQueue.Text = "label2";
            // 
            // btnCashier
            // 
            btnCashier.BackColor = SystemColors.ControlDarkDark;
            btnCashier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCashier.Location = new Point(12, 63);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(123, 100);
            btnCashier.TabIndex = 2;
            btnCashier.Text = "Cashier";
            btnCashier.UseVisualStyleBackColor = false;
            btnCashier.Click += btnCashier_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(3, 166);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(132, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "*Click To Get A Number";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // QueuingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(365, 273);
            Controls.Add(linkLabel1);
            Controls.Add(btnCashier);
            Controls.Add(lblQueue);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Name = "QueuingForm";
            Text = "Form1";
            Load += QueuingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblQueue;
        private Button btnCashier;
        private LinkLabel linkLabel1;
    }
}