namespace TrgovanjeDionicama
{
    partial class FrontPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.stocksGridView = new System.Windows.Forms.DataGridView();
            this.stockSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.HistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WalletButton = new System.Windows.Forms.Button();
            this.PortfolioButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).BeginInit();
            this.SuspendLayout();
            // 
            // stocksGridView
            // 
            this.stocksGridView.AllowUserToAddRows = false;
            this.stocksGridView.AllowUserToDeleteRows = false;
            this.stocksGridView.AllowUserToResizeColumns = false;
            this.stocksGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocksGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockSymbol,
            this.stockValue,
            this.valueChange});
            this.stocksGridView.Location = new System.Drawing.Point(1072, 100);
            this.stocksGridView.Name = "stocksGridView";
            this.stocksGridView.ReadOnly = true;
            this.stocksGridView.RowHeadersVisible = false;
            this.stocksGridView.RowHeadersWidth = 62;
            this.stocksGridView.RowTemplate.Height = 28;
            this.stocksGridView.Size = new System.Drawing.Size(418, 523);
            this.stocksGridView.TabIndex = 6;
            // 
            // stockSymbol
            // 
            this.stockSymbol.HeaderText = "Stock Symbol";
            this.stockSymbol.MinimumWidth = 8;
            this.stockSymbol.Name = "stockSymbol";
            this.stockSymbol.ReadOnly = true;
            // 
            // stockValue
            // 
            this.stockValue.HeaderText = "Stock Value";
            this.stockValue.MinimumWidth = 8;
            this.stockValue.Name = "stockValue";
            this.stockValue.ReadOnly = true;
            // 
            // valueChange
            // 
            this.valueChange.HeaderText = "Value Change";
            this.valueChange.MinimumWidth = 8;
            this.valueChange.Name = "valueChange";
            this.valueChange.ReadOnly = true;
            // 
            // dateComboBox
            // 
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Items.AddRange(new object[] {
            "One Day",
            "Two Days",
            "One Week",
            "Two Weeks",
            "One Month",
            "Two Months"});
            this.dateComboBox.Location = new System.Drawing.Point(1072, 661);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(166, 24);
            this.dateComboBox.TabIndex = 7;
            this.dateComboBox.SelectedIndexChanged += new System.EventHandler(this.dateComboBox_SelectedIndexChanged);
            // 
            // HistoryChart
            // 
            chartArea2.Name = "ChartArea1";
            this.HistoryChart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.HistoryChart.Legends.Add(legend2);
            this.HistoryChart.Location = new System.Drawing.Point(149, 100);
            this.HistoryChart.Name = "HistoryChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.HistoryChart.Series.Add(series2);
            this.HistoryChart.Size = new System.Drawing.Size(802, 541);
            this.HistoryChart.TabIndex = 8;
            this.HistoryChart.Text = "HistoryChart";
            title2.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Stock history";
            this.HistoryChart.Titles.Add(title2);
            // 
            // WalletButton
            // 
            this.WalletButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WalletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletButton.Location = new System.Drawing.Point(1072, 762);
            this.WalletButton.Name = "WalletButton";
            this.WalletButton.Size = new System.Drawing.Size(154, 52);
            this.WalletButton.TabIndex = 26;
            this.WalletButton.Text = "Wallet";
            this.WalletButton.UseVisualStyleBackColor = false;
            this.WalletButton.Click += new System.EventHandler(this.WalletButton_Click);
            // 
            // PortfolioButton
            // 
            this.PortfolioButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PortfolioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortfolioButton.Location = new System.Drawing.Point(1336, 762);
            this.PortfolioButton.Name = "PortfolioButton";
            this.PortfolioButton.Size = new System.Drawing.Size(154, 52);
            this.PortfolioButton.TabIndex = 27;
            this.PortfolioButton.Text = "Portfolio";
            this.PortfolioButton.UseVisualStyleBackColor = false;
            this.PortfolioButton.Click += new System.EventHandler(this.PortfolioButton_Click);
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(3322, 1423);
            this.Controls.Add(this.PortfolioButton);
            this.Controls.Add(this.WalletButton);
            this.Controls.Add(this.HistoryChart);
            this.Controls.Add(this.dateComboBox);
            this.Controls.Add(this.stocksGridView);
            this.Name = "FrontPage";
            this.Text = "Front Page";
            this.Load += new System.EventHandler(this.FrontPageV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView stocksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueChange;
        private System.Windows.Forms.ComboBox dateComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistoryChart;
        private System.Windows.Forms.Button WalletButton;
        private System.Windows.Forms.Button PortfolioButton;
    }
}