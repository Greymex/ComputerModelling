namespace Controller_Estimator
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
            this.output_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.output_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.best_lb = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.output_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // output_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.output_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.output_chart.Legends.Add(legend2);
            this.output_chart.Location = new System.Drawing.Point(488, 12);
            this.output_chart.Name = "output_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.output_chart.Series.Add(series2);
            this.output_chart.Size = new System.Drawing.Size(401, 300);
            this.output_chart.TabIndex = 0;
            this.output_chart.Text = "chart1";
            // 
            // output_grid
            // 
            this.output_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_grid.Location = new System.Drawing.Point(12, 12);
            this.output_grid.Name = "output_grid";
            this.output_grid.Size = new System.Drawing.Size(461, 300);
            this.output_grid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(267, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Лучший контроллер:";
            // 
            // best_lb
            // 
            this.best_lb.AutoSize = true;
            this.best_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.best_lb.Location = new System.Drawing.Point(465, 336);
            this.best_lb.Name = "best_lb";
            this.best_lb.Size = new System.Drawing.Size(76, 25);
            this.best_lb.TabIndex = 3;
            this.best_lb.Text = "label2";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(814, 340);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 384);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.best_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.output_grid);
            this.Controls.Add(this.output_chart);
            this.Name = "Output";
            this.Text = "Результат";
            ((System.ComponentModel.ISupportInitialize)(this.output_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart output_chart;
        private System.Windows.Forms.DataGridView output_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label best_lb;
        private System.Windows.Forms.Button save_btn;
    }
}