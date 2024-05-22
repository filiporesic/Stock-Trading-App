using System.Drawing;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    partial class WalletForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            this.walletBalance = new System.Windows.Forms.Label();
            this.buyStocksGridView = new System.Windows.Forms.DataGridView();
            this.stockSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buyAmountSelector = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.costLabel = new System.Windows.Forms.Label();
            this.buyResultLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sellStocksGridView = new System.Windows.Forms.DataGridView();
            this.stockSymbolSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockPriceSell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueOwned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sellComboBox = new System.Windows.Forms.ComboBox();
            this.sellAmountSelector = new System.Windows.Forms.NumericUpDown();
            this.sellValueLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.sellResultLabel = new System.Windows.Forms.Label();
            this.transactionComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.depositButton = new System.Windows.Forms.Button();
            this.FrontPageButton = new System.Windows.Forms.Button();
            this.PortfolioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyStocksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyAmountSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellStocksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAmountSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTransactions
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransactions.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactions.Location = new System.Drawing.Point(363, 200);
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.RowHeadersVisible = false;
            this.dataGridTransactions.RowHeadersWidth = 62;
            this.dataGridTransactions.Size = new System.Drawing.Size(1268, 173);
            this.dataGridTransactions.TabIndex = 0;
            // 
            // walletBalance
            // 
            this.walletBalance.AutoSize = true;
            this.walletBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.walletBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletBalance.Location = new System.Drawing.Point(1492, 174);
            this.walletBalance.Name = "walletBalance";
            this.walletBalance.Size = new System.Drawing.Size(130, 20);
            this.walletBalance.TabIndex = 2;
            this.walletBalance.Text = "Wallet balance: ";
            // 
            // buyStocksGridView
            // 
            this.buyStocksGridView.AllowUserToAddRows = false;
            this.buyStocksGridView.AllowUserToDeleteRows = false;
            this.buyStocksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buyStocksGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buyStocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyStocksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockSymbol,
            this.stockPrice});
            this.buyStocksGridView.Location = new System.Drawing.Point(363, 435);
            this.buyStocksGridView.Name = "buyStocksGridView";
            this.buyStocksGridView.ReadOnly = true;
            this.buyStocksGridView.RowHeadersVisible = false;
            this.buyStocksGridView.RowHeadersWidth = 62;
            this.buyStocksGridView.RowTemplate.Height = 28;
            this.buyStocksGridView.Size = new System.Drawing.Size(507, 201);
            this.buyStocksGridView.TabIndex = 3;
            // 
            // stockSymbol
            // 
            this.stockSymbol.HeaderText = "Stock Symbol";
            this.stockSymbol.MinimumWidth = 8;
            this.stockSymbol.Name = "stockSymbol";
            this.stockSymbol.ReadOnly = true;
            // 
            // stockPrice
            // 
            this.stockPrice.HeaderText = "Stock Price";
            this.stockPrice.MinimumWidth = 8;
            this.stockPrice.Name = "stockPrice";
            this.stockPrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stocks available for purchase:";
            // 
            // buyAmountSelector
            // 
            this.buyAmountSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buyAmountSelector.Location = new System.Drawing.Point(1089, 466);
            this.buyAmountSelector.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.buyAmountSelector.Name = "buyAmountSelector";
            this.buyAmountSelector.Size = new System.Drawing.Size(107, 22);
            this.buyAmountSelector.TabIndex = 5;
            this.buyAmountSelector.ValueChanged += new System.EventHandler(this.BuyAmountSelector_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(916, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select share to buy";
            // 
            // buyComboBox
            // 
            this.buyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyComboBox.FormattingEnabled = true;
            this.buyComboBox.Location = new System.Drawing.Point(919, 466);
            this.buyComboBox.Name = "buyComboBox";
            this.buyComboBox.Size = new System.Drawing.Size(125, 24);
            this.buyComboBox.TabIndex = 8;
            this.buyComboBox.SelectedIndexChanged += new System.EventHandler(this.BuyComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1085, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select amount";
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(919, 516);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(125, 40);
            this.buyButton.TabIndex = 10;
            this.buyButton.Text = "BUY";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(1221, 466);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(63, 18);
            this.costLabel.TabIndex = 11;
            this.costLabel.Text = "Cost: 0";
            // 
            // buyResultLabel
            // 
            this.buyResultLabel.AutoSize = true;
            this.buyResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyResultLabel.Location = new System.Drawing.Point(1100, 516);
            this.buyResultLabel.Name = "buyResultLabel";
            this.buyResultLabel.Size = new System.Drawing.Size(0, 18);
            this.buyResultLabel.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Stocks available for selling: ";
            // 
            // sellStocksGridView
            // 
            this.sellStocksGridView.AllowUserToAddRows = false;
            this.sellStocksGridView.AllowUserToDeleteRows = false;
            this.sellStocksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellStocksGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sellStocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellStocksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockSymbolSell,
            this.stockQuantity,
            this.stockPriceSell,
            this.valueOwned});
            this.sellStocksGridView.Location = new System.Drawing.Point(363, 696);
            this.sellStocksGridView.Name = "sellStocksGridView";
            this.sellStocksGridView.ReadOnly = true;
            this.sellStocksGridView.RowHeadersVisible = false;
            this.sellStocksGridView.RowHeadersWidth = 62;
            this.sellStocksGridView.RowTemplate.Height = 28;
            this.sellStocksGridView.Size = new System.Drawing.Size(507, 153);
            this.sellStocksGridView.TabIndex = 14;
            // 
            // stockSymbolSell
            // 
            this.stockSymbolSell.HeaderText = "Stock Symbol";
            this.stockSymbolSell.MinimumWidth = 8;
            this.stockSymbolSell.Name = "stockSymbolSell";
            this.stockSymbolSell.ReadOnly = true;
            // 
            // stockQuantity
            // 
            this.stockQuantity.HeaderText = "Stock Quantity";
            this.stockQuantity.MinimumWidth = 8;
            this.stockQuantity.Name = "stockQuantity";
            this.stockQuantity.ReadOnly = true;
            // 
            // stockPriceSell
            // 
            this.stockPriceSell.HeaderText = "Stock Price";
            this.stockPriceSell.MinimumWidth = 8;
            this.stockPriceSell.Name = "stockPriceSell";
            this.stockPriceSell.ReadOnly = true;
            // 
            // valueOwned
            // 
            this.valueOwned.HeaderText = "Value Owned";
            this.valueOwned.MinimumWidth = 8;
            this.valueOwned.Name = "valueOwned";
            this.valueOwned.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(916, 696);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Select stock to sell ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1085, 696);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select amount";
            // 
            // sellComboBox
            // 
            this.sellComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sellComboBox.FormattingEnabled = true;
            this.sellComboBox.Location = new System.Drawing.Point(919, 736);
            this.sellComboBox.Name = "sellComboBox";
            this.sellComboBox.Size = new System.Drawing.Size(125, 24);
            this.sellComboBox.TabIndex = 17;
            this.sellComboBox.SelectedIndexChanged += new System.EventHandler(this.SellComboBox_SelectedIndexChanged);
            // 
            // sellAmountSelector
            // 
            this.sellAmountSelector.Location = new System.Drawing.Point(1089, 738);
            this.sellAmountSelector.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.sellAmountSelector.Name = "sellAmountSelector";
            this.sellAmountSelector.Size = new System.Drawing.Size(107, 22);
            this.sellAmountSelector.TabIndex = 18;
            this.sellAmountSelector.ValueChanged += new System.EventHandler(this.SellAmountSelector_ValueChanged);
            // 
            // sellValueLabel
            // 
            this.sellValueLabel.AutoSize = true;
            this.sellValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellValueLabel.Location = new System.Drawing.Point(1221, 738);
            this.sellValueLabel.Name = "sellValueLabel";
            this.sellValueLabel.Size = new System.Drawing.Size(68, 18);
            this.sellValueLabel.TabIndex = 19;
            this.sellValueLabel.Text = "Value: 0";
            // 
            // sellButton
            // 
            this.sellButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sellButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellButton.Location = new System.Drawing.Point(919, 786);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(125, 40);
            this.sellButton.TabIndex = 20;
            this.sellButton.Text = "SELL";
            this.sellButton.UseVisualStyleBackColor = false;
            this.sellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // sellResultLabel
            // 
            this.sellResultLabel.AutoSize = true;
            this.sellResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellResultLabel.Location = new System.Drawing.Point(1096, 798);
            this.sellResultLabel.Name = "sellResultLabel";
            this.sellResultLabel.Size = new System.Drawing.Size(0, 18);
            this.sellResultLabel.TabIndex = 21;
            // 
            // transactionComboBox
            // 
            this.transactionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactionComboBox.FormattingEnabled = true;
            this.transactionComboBox.Items.AddRange(new object[] {
            "All",
            "Buy",
            "Sell"});
            this.transactionComboBox.Location = new System.Drawing.Point(215, 200);
            this.transactionComboBox.Name = "transactionComboBox";
            this.transactionComboBox.Size = new System.Drawing.Size(128, 24);
            this.transactionComboBox.TabIndex = 22;
            this.transactionComboBox.SelectedIndexChanged += new System.EventHandler(this.TransactionComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Select type of transaction:";
            // 
            // depositButton
            // 
            this.depositButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.depositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositButton.Location = new System.Drawing.Point(363, 878);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(195, 53);
            this.depositButton.TabIndex = 24;
            this.depositButton.Text = "Deposit/Withdraw";
            this.depositButton.UseVisualStyleBackColor = false;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // FrontPageButton
            // 
            this.FrontPageButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FrontPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontPageButton.Location = new System.Drawing.Point(1224, 878);
            this.FrontPageButton.Name = "FrontPageButton";
            this.FrontPageButton.Size = new System.Drawing.Size(156, 53);
            this.FrontPageButton.TabIndex = 29;
            this.FrontPageButton.Text = "Front Page";
            this.FrontPageButton.UseVisualStyleBackColor = false;
            this.FrontPageButton.Click += new System.EventHandler(this.FrontPageButton_Click);
            // 
            // PortfolioButton
            // 
            this.PortfolioButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortfolioButton.Location = new System.Drawing.Point(1492, 878);
            this.PortfolioButton.Name = "PortfolioButton";
            this.PortfolioButton.Size = new System.Drawing.Size(139, 53);
            this.PortfolioButton.TabIndex = 30;
            this.PortfolioButton.Text = "Portfolio";
            this.PortfolioButton.UseVisualStyleBackColor = false;
            this.PortfolioButton.Click += new System.EventHandler(this.PortfolioButton_Click);
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2974, 1686);
            this.Controls.Add(this.PortfolioButton);
            this.Controls.Add(this.FrontPageButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transactionComboBox);
            this.Controls.Add(this.sellResultLabel);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.sellValueLabel);
            this.Controls.Add(this.sellAmountSelector);
            this.Controls.Add(this.sellComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sellStocksGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buyResultLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buyComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyAmountSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buyStocksGridView);
            this.Controls.Add(this.walletBalance);
            this.Controls.Add(this.dataGridTransactions);
            this.Name = "WalletForm";
            this.Text = "Wallet";
            this.Load += new System.EventHandler(this.WalletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyStocksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyAmountSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellStocksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellAmountSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransactions;
        private System.Windows.Forms.Label walletBalance;
        private System.Windows.Forms.DataGridView buyStocksGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPrice;
        private System.Windows.Forms.NumericUpDown buyAmountSelector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox buyComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label buyResultLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView sellStocksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockSymbolSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockPriceSell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sellComboBox;
        private System.Windows.Forms.NumericUpDown sellAmountSelector;
        private System.Windows.Forms.Label sellValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOwned;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label sellResultLabel;
        private System.Windows.Forms.ComboBox transactionComboBox;
        private System.Windows.Forms.Label label7;
        private Button depositButton;
        private Button FrontPageButton;
        private Button PortfolioButton;
    }
}

