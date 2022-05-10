namespace Estimator_v2._1
{
    partial class ChangeAssessmentsPanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.evaluation_grid = new System.Windows.Forms.DataGridView();
            this.controller_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluation_grid
            // 
            this.evaluation_grid.AllowUserToAddRows = false;
            this.evaluation_grid.AllowUserToDeleteRows = false;
            this.evaluation_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evaluation_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.evaluation_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluation_grid.Location = new System.Drawing.Point(0, 3);
            this.evaluation_grid.Name = "evaluation_grid";
            this.evaluation_grid.Size = new System.Drawing.Size(851, 413);
            this.evaluation_grid.TabIndex = 3;
            this.evaluation_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Delete_Pressed);
            // 
            // controller_lb
            // 
            this.controller_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controller_lb.AutoSize = true;
            this.controller_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controller_lb.Location = new System.Drawing.Point(236, 505);
            this.controller_lb.Name = "controller_lb";
            this.controller_lb.Size = new System.Drawing.Size(52, 18);
            this.controller_lb.TabIndex = 8;
            this.controller_lb.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Экспертная оценка контроллера:";
            // 
            // ChangeAssessmentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controller_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evaluation_grid);
            this.Name = "ChangeAssessmentsPanel";
            this.Size = new System.Drawing.Size(852, 557);
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView evaluation_grid;
        private System.Windows.Forms.Label controller_lb;
        private System.Windows.Forms.Label label1;
    }
}
