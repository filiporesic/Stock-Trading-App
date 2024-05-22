namespace TrgovanjeDionicama
{
    partial class Portfolio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HistoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WalletButton = new System.Windows.Forms.Button();
            this.FrontPageButton = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxYesterdayValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(600, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // HistoryChart
            // 
            this.HistoryChart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.Name = "ChartArea1";
            this.HistoryChart.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Portfolio value in last 30 days";
            this.HistoryChart.Legends.Add(legend5);
            this.HistoryChart.Location = new System.Drawing.Point(928, 182);
            this.HistoryChart.Name = "HistoryChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Portfolio value in last 30 days";
            series5.LegendText = "Portfolio value";
            series5.Name = "HistorySeries";
            this.HistoryChart.Series.Add(series5);
            this.HistoryChart.Size = new System.Drawing.Size(794, 550);
            this.HistoryChart.TabIndex = 1;
            this.HistoryChart.Text = "HistoryChart";
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PieChart.BorderlineColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            chartArea6.Name = "PieChartArea";
            this.PieChart.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.Name = "PieLegend";
            this.PieChart.Legends.Add(legend6);
            this.PieChart.Location = new System.Drawing.Point(167, 627);
            this.PieChart.Name = "PieChart";
            series6.ChartArea = "PieChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "PieLegend";
            series6.Name = "StocksDistribution";
            this.PieChart.Series.Add(series6);
            this.PieChart.Size = new System.Drawing.Size(600, 424);
            this.PieChart.TabIndex = 2;
            this.PieChart.Text = "PieChart";
            // 
            // WalletButton
            // 
            this.WalletButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.WalletButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WalletButton.Location = new System.Drawing.Point(1107, 876);
            this.WalletButton.Name = "WalletButton";
            this.WalletButton.Size = new System.Drawing.Size(154, 52);
            this.WalletButton.TabIndex = 27;
            this.WalletButton.Text = "Wallet";
            this.WalletButton.UseVisualStyleBackColor = false;
            this.WalletButton.Click += new System.EventHandler(this.WalletButton_Click);
            // 
            // FrontPageButton
            // 
            this.FrontPageButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FrontPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrontPageButton.Location = new System.Drawing.Point(1364, 876);
            this.FrontPageButton.Name = "FrontPageButton";
            this.FrontPageButton.Size = new System.Drawing.Size(154, 52);
            this.FrontPageButton.TabIndex = 28;
            this.FrontPageButton.Text = "Front Page";
            this.FrontPageButton.UseVisualStyleBackColor = false;
            this.FrontPageButton.Click += new System.EventHandler(this.FrontPageButton_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(167, 142);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(155, 22);
            this.textBoxValue.TabIndex = 29;
            this.textBoxValue.Text = "Portfolio value: 0";
            // 
            // textBoxYesterdayValue
            // 
            this.textBoxYesterdayValue.Location = new System.Drawing.Point(355, 142);
            this.textBoxYesterdayValue.Name = "textBoxYesterdayValue";
            this.textBoxYesterdayValue.Size = new System.Drawing.Size(210, 22);
            this.textBoxYesterdayValue.TabIndex = 30;
            this.textBoxYesterdayValue.Text = "Change from yesterday: 0";
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.textBoxYesterdayValue);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.FrontPageButton);
            this.Controls.Add(this.WalletButton);
            this.Controls.Add(this.PieChart);
            this.Controls.Add(this.HistoryChart);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Portfolio";
            this.Text = "Portfolio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart HistoryChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Button WalletButton;
        private System.Windows.Forms.Button FrontPageButton;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxYesterdayValue;
    }
}