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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // property_group_name
            // 
            this.property_group_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.property_group_name.Location = new System.Drawing.Point(187, 59);
            this.property_group_name.Name = "property_group_name";
            this.property_group_name.Size = new System.Drawing.Size(187, 20);
            this.property_group_name.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(464, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Критерий оценки ПЛК";
            // 
            // group_names_cb
            // 
            this.group_names_cb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_names_cb.FormattingEnabled = true;
            this.group_names_cb.Location = new System.Drawing.Point(187, 132);
            this.group_names_cb.Name = "group_names_cb";
            this.group_names_cb.Size = new System.Drawing.Size(187, 21);
            this.group_names_cb.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 43);
            this.label4.TabIndex = 28;
            this.label4.Text = "Группа основных характеристик ПЛК:";
            // 
            // property_name
            // 
            this.property_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.property_name.Location = new System.Drawing.Point(187, 177);
            this.property_name.Name = "property_name";
            this.property_name.Size = new System.Drawing.Size(187, 20);
            this.property_name.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(10, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "Название характеристики:";
            // 
            // IsReversedProperty
            // 
            this.IsReversedProperty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IsReversedProperty.AutoSize = true;
            this.IsReversedProperty.Location = new System.Drawing.Point(202, 212);
            this.IsReversedProperty.Name = "IsReversedProperty";
            this.IsReversedProperty.Size = new System.Drawing.Size(150, 17);
            this.IsReversedProperty.TabIndex = 31;
            this.IsReversedProperty.Text = "Прямая характеристика";
            this.IsReversedProperty.UseVisualStyleBackColor = true;
            // 
            // properties_view
            // 
            this.properties_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.properties_view.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.properties_view.Location = new System.Drawing.Point(0, 23);
            this.properties_view.Name = "properties_view";
            this.properties_view.Size = new System.Drawing.Size(439, 381);
            this.properties_view.TabIndex = 32;
            this.properties_view.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SelectItemFromTree);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Дерево потребительских свойств ПЛК:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(632, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Потребительские свойства";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 41);
            this.label5.TabIndex = 35;
            this.label5.Text = "Выберите группу основных характеристик ПЛК:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.property_name);
            this.groupBox1.Controls.Add(this.property_group_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.group_names_cb);
            this.groupBox1.Controls.Add(this.IsReversedProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(467, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 300);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление нового критерия оценки ПЛК";
            // 
            // GroupPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.properties_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GroupPanel";
            this.Size = new System.Drawing.Size(894, 419);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
