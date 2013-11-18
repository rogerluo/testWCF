namespace testWCFSimpleClient
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxLhs = new System.Windows.Forms.TextBox();
            this.tbxRhs = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnActoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxLhs
            // 
            this.tbxLhs.Location = new System.Drawing.Point(21, 11);
            this.tbxLhs.Name = "tbxLhs";
            this.tbxLhs.Size = new System.Drawing.Size(100, 20);
            this.tbxLhs.TabIndex = 2;
            // 
            // tbxRhs
            // 
            this.tbxRhs.Location = new System.Drawing.Point(182, 11);
            this.tbxRhs.Name = "tbxRhs";
            this.tbxRhs.Size = new System.Drawing.Size(100, 20);
            this.tbxRhs.TabIndex = 3;
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperation.Location = new System.Drawing.Point(127, 11);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(49, 21);
            this.cmbOperation.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(368, 15);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(22, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "= ?";
            // 
            // btnActoin
            // 
            this.btnActoin.Location = new System.Drawing.Point(287, 10);
            this.btnActoin.Name = "btnActoin";
            this.btnActoin.Size = new System.Drawing.Size(75, 23);
            this.btnActoin.TabIndex = 6;
            this.btnActoin.Text = "Do It!";
            this.btnActoin.UseVisualStyleBackColor = true;
            this.btnActoin.Click += new System.EventHandler(this.btnActoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 47);
            this.Controls.Add(this.btnActoin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.tbxRhs);
            this.Controls.Add(this.tbxLhs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLhs;
        private System.Windows.Forms.TextBox tbxRhs;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnActoin;

    }
}

