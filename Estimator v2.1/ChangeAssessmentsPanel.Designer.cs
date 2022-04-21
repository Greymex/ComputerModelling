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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.properties_groups_cb = new System.Windows.Forms.ComboBox();
            this.all_ctrls_cb = new System.Windows.Forms.ComboBox();
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
            this.evaluation_grid.Location = new System.Drawing.Point(0, 106);
            this.evaluation_grid.Name = "evaluation_grid";
            this.evaluation_grid.Size = new System.Drawing.Size(851, 301);
            this.evaluation_grid.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Location = new System.Drawing.Point(341, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 55);
            this.label7.TabIndex = 26;
            this.label7.Text = "Выберите группу потребительских свойств, данные которой требуется изменить:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 43);
            this.label8.TabIndex = 25;
            this.label8.Text = "Выберите контроллер, группу потребительских свойств которого требуется изменить:";
            // 
            // properties_groups_cb
            // 
            this.properties_groups_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.properties_groups_cb.FormattingEnabled = true;
            this.properties_groups_cb.Location = new System.Drawing.Point(514, 27);
            this.properties_groups_cb.Name = "properties_groups_cb";
            this.properties_groups_cb.Size = new System.Drawing.Size(121, 21);
            this.properties_groups_cb.TabIndex = 24;
            // 
            // all_ctrls_cb
            // 
            this.all_ctrls_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.all_ctrls_cb.FormattingEnabled = true;
            this.all_ctrls_cb.Location = new System.Drawing.Point(189, 27);
            this.all_ctrls_cb.Name = "all_ctrls_cb";
            this.all_ctrls_cb.Size = new System.Drawing.Size(121, 21);
            this.all_ctrls_cb.TabIndex = 23;
            this.all_ctrls_cb.SelectedIndexChanged += new System.EventHandler(this.UpdateGroupsForCurrentController);
            // 
            // ChangeAssessmentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.properties_groups_cb);
            this.Controls.Add(this.all_ctrls_cb);
            this.Controls.Add(this.evaluation_grid);
            this.Name = "ChangeAssessmentsPanel";
            this.Size = new System.Drawing.Size(854, 410);
            ((System.ComponentModel.ISupportInitialize)(this.evaluation_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView evaluation_grid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox properties_groups_cb;
        private System.Windows.Forms.ComboBox all_ctrls_cb;
    }
}
