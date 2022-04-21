namespace Estimator_v2._1
{
    partial class Output
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
            this.best_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.output_grid = new System.Windows.Forms.DataGridView();
            this.output_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // best_lb
            // 
            this.best_lb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.best_lb.AutoSize = true;
            this.best_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_lb.Location = new System.Drawing.Point(617, 332);
            this.best_lb.Name = "best_lb";
            this.best_lb.Size = new System.Drawing.Size(76, 25);
            this.best_lb.TabIndex = 6;
            this.best_lb.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(419, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Лучший контроллер:";
            // 
            // output_grid
            // 
            this.output_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_grid.Location = new System.Drawing.Point(12, 12);
            this.output_grid.Name = "output_grid";
            this.output_grid.Size = new System.Drawing.Size(536, 300);
            this.output_grid.TabIndex = 4;
            // 
            // output_chart
            // 
            this.output_chart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.output_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.output_chart.Legends.Add(legend2);
            this.output_chart.Location = new System.Drawing.Point(554, 12);
            this.output_chart.Name = "output_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.output_chart.Series.Add(series2);
            this.output_chart.Size = new System.Drawing.Size(541, 300);
            this.output_chart.TabIndex = 7;
            this.output_chart.Text = "chart1";
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 365);
            this.Controls.Add(this.output_chart);
            this.Controls.Add(this.best_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_grid);
            this.Name = "Output";
            this.Text = "Output";
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label best_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView output_grid;
        private System.Windows.Forms.DataVisualization.Charting.Chart output_chart;
    }
}