namespace TrgovanjeDionicama
{
    partial class TransferForm
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
            this.depositSelector = new System.Windows.Forms.NumericUpDown();
            this.withdrawSelector = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depositSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // depositSelector
            // 
            this.depositSelector.Location = new System.Drawing.Point(27, 38);
            this.depositSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositSelector.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.depositSelector.Name = "depositSelector";
            this.depositSelector.Size = new System.Drawing.Size(139, 22);
            this.depositSelector.TabIndex = 0;
            // 
            // withdrawSelector
            // 
            this.withdrawSelector.Location = new System.Drawing.Point(347, 38);
            this.withdrawSelector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawSelector.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.withdrawSelector.Name = "withdrawSelector";
            this.withdrawSelector.Size = new System.Drawing.Size(139, 22);
            this.withdrawSelector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the amount to deposit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select the amount to withdraw:";
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(27, 162);
            this.depositButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(139, 39);
            this.depositButton.TabIndex = 21;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.withdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawButton.Location = new System.Drawing.Point(347, 162);
            this.withdrawButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(139, 39);
            this.withdrawButton.TabIndex = 22;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = false;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Enter IBAN:";
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Location = new System.Drawing.Point(347, 118);
            this.ibanTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(190, 22);
            this.ibanTextBox.TabIndex = 24;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(188, 209);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(139, 39);
            this.closeButton.TabIndex = 25;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 258);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.withdrawSelector);
            this.Controls.Add(this.depositSelector);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransferForm";
            this.Text = "Deposit/Withdrawal";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.depositSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.withdrawSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown depositSelector;
        private System.Windows.Forms.NumericUpDown withdrawSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}