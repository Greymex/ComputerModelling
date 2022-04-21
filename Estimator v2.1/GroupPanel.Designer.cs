namespace Estimator_v2
{
    partial class GroupPanel
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
            this.property_group_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.group_names_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.property_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IsReversedProperty = new System.Windows.Forms.CheckBox();
            this.properties_view = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // property_group_name
            // 
            this.property_group_name.Location = new System.Drawing.Point(194, 31);
            this.property_group_name.Name = "property_group_name";
            this.property_group_name.Size = new System.Drawing.Size(141, 20);
            this.property_group_name.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Название группы потребительских свойств:";
            // 
            // group_names_cb
            // 
            this.group_names_cb.FormattingEnabled = true;
            this.group_names_cb.Location = new System.Drawing.Point(194, 116);
            this.group_names_cb.Name = "group_names_cb";
            this.group_names_cb.Size = new System.Drawing.Size(141, 21);
            this.group_names_cb.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Группа потребительских свойств:";
            // 
            // property_name
            // 
            this.property_name.Location = new System.Drawing.Point(194, 161);
            this.property_name.Name = "property_name";
            this.property_name.Size = new System.Drawing.Size(141, 20);
            this.property_name.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Название потребительского свойства:";
            // 
            // IsReversedProperty
            // 
            this.IsReversedProperty.AutoSize = true;
            this.IsReversedProperty.Location = new System.Drawing.Point(185, 207);
            this.IsReversedProperty.Name = "IsReversedProperty";
            this.IsReversedProperty.Size = new System.Drawing.Size(159, 17);
            this.IsReversedProperty.TabIndex = 31;
            this.IsReversedProperty.Text = "Обратная характеристика";
            this.IsReversedProperty.UseVisualStyleBackColor = true;
            // 
            // properties_view
            // 
            this.properties_view.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.properties_view.Location = new System.Drawing.Point(378, 23);
            this.properties_view.Name = "properties_view";
            this.properties_view.Size = new System.Drawing.Size(310, 201);
            this.properties_view.TabIndex = 32;
            this.properties_view.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SelectItemFromTree);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Все группы и свойства в системе:";
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.properties_view);
            this.Controls.Add(this.property_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IsReversedProperty);
            this.Controls.Add(this.group_names_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.property_group_name);
            this.Controls.Add(this.label2);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(702, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox property_group_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox group_names_cb;
        private System.Windows.Forms.TextBox property_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox IsReversedProperty;
        private System.Windows.Forms.TreeView properties_view;
        private System.Windows.Forms.Label label1;
    }
}
