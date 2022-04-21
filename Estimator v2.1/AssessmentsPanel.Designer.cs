﻿namespace Estimator_v2._1
{
    partial class AssessmentsPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.experts_count = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.properties_groups_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.all_ctrl_cb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experts_count)).BeginInit();
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
            this.evaluation_grid.Location = new System.Drawing.Point(3, 73);
            this.evaluation_grid.Name = "evaluation_grid";
            this.evaluation_grid.Size = new System.Drawing.Size(887, 348);
            this.evaluation_grid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Количество экспертов";
            // 
            // experts_count
            // 
            this.experts_count.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.experts_count.Location = new System.Drawing.Point(467, 24);
            this.experts_count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.experts_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.experts_count.Name = "experts_count";
            this.experts_count.Size = new System.Drawing.Size(121, 20);
            this.experts_count.TabIndex = 34;
            this.experts_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Location = new System.Drawing.Point(34, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 57);
            this.label6.TabIndex = 33;
            this.label6.Text = "Выберите группу потребительских свойств, для которой необходимо добавить оценки:";
            // 
            // properties_groups_cb
            // 
            this.properties_groups_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.properties_groups_cb.FormattingEnabled = true;
            this.properties_groups_cb.Location = new System.Drawing.Point(193, 24);
            this.properties_groups_cb.Name = "properties_groups_cb";
            this.properties_groups_cb.Size = new System.Drawing.Size(121, 21);
            this.properties_groups_cb.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(34, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 57);
            this.label2.TabIndex = 36;
            this.label2.Text = "Выберите котроллер, которому нужно добавить данную группу:";
            // 
            // all_ctrl_cb
            // 
            this.all_ctrl_cb.FormattingEnabled = true;
            this.all_ctrl_cb.Location = new System.Drawing.Point(193, 437);
            this.all_ctrl_cb.Name = "all_ctrl_cb";
            this.all_ctrl_cb.Size = new System.Drawing.Size(121, 21);
            this.all_ctrl_cb.TabIndex = 37;
            // 
            // AssessmentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.all_ctrl_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.experts_count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.properties_groups_cb);
            this.Controls.Add(this.evaluation_grid);
            this.Name = "AssessmentsPanel";
            this.Size = new System.Drawing.Size(893, 482);
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experts_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView evaluation_grid;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown experts_count;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox properties_groups_cb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox all_ctrl_cb;
    }
}
