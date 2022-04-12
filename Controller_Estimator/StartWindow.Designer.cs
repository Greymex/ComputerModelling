namespace Controller_Estimator
{
    partial class StartWindow
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_controller_button = new System.Windows.Forms.Button();
            this.add_group_button = new System.Windows.Forms.Button();
            this.property_group_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.property_name = new System.Windows.Forms.TextBox();
            this.group_names_cb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_property = new System.Windows.Forms.Button();
            this.IsReversedProperty = new System.Windows.Forms.CheckBox();
            this.start_eval_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_controller_button
            // 
            this.add_controller_button.Location = new System.Drawing.Point(74, 325);
            this.add_controller_button.Name = "add_controller_button";
            this.add_controller_button.Size = new System.Drawing.Size(167, 23);
            this.add_controller_button.TabIndex = 4;
            this.add_controller_button.Text = "Добавить контроллер";
            this.add_controller_button.UseVisualStyleBackColor = true;
            this.add_controller_button.Click += new System.EventHandler(this.add_controller_button_Click);
            // 
            // add_group_button
            // 
            this.add_group_button.Location = new System.Drawing.Point(144, 56);
            this.add_group_button.Name = "add_group_button";
            this.add_group_button.Size = new System.Drawing.Size(155, 23);
            this.add_group_button.TabIndex = 5;
            this.add_group_button.Text = "Добавить группу свойств";
            this.add_group_button.UseVisualStyleBackColor = true;
            this.add_group_button.Click += new System.EventHandler(this.add_group_button_Click);
            // 
            // property_group_name
            // 
            this.property_group_name.Location = new System.Drawing.Point(158, 12);
            this.property_group_name.Name = "property_group_name";
            this.property_group_name.Size = new System.Drawing.Size(141, 20);
            this.property_group_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название группы свойств";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название свойства";
            // 
            // property_name
            // 
            this.property_name.Location = new System.Drawing.Point(158, 114);
            this.property_name.Name = "property_name";
            this.property_name.Size = new System.Drawing.Size(141, 20);
            this.property_name.TabIndex = 9;
            // 
            // group_names_cb
            // 
            this.group_names_cb.FormattingEnabled = true;
            this.group_names_cb.Location = new System.Drawing.Point(158, 155);
            this.group_names_cb.Name = "group_names_cb";
            this.group_names_cb.Size = new System.Drawing.Size(141, 21);
            this.group_names_cb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Группа свойств";
            // 
            // add_property
            // 
            this.add_property.Location = new System.Drawing.Point(144, 237);
            this.add_property.Name = "add_property";
            this.add_property.Size = new System.Drawing.Size(155, 23);
            this.add_property.TabIndex = 12;
            this.add_property.Text = "Добавить свойство";
            this.add_property.UseVisualStyleBackColor = true;
            this.add_property.Click += new System.EventHandler(this.add_property_Click);
            // 
            // IsReversedProperty
            // 
            this.IsReversedProperty.AutoSize = true;
            this.IsReversedProperty.Location = new System.Drawing.Point(181, 196);
            this.IsReversedProperty.Name = "IsReversedProperty";
            this.IsReversedProperty.Size = new System.Drawing.Size(75, 17);
            this.IsReversedProperty.TabIndex = 13;
            this.IsReversedProperty.Text = "Обратное";
            this.IsReversedProperty.UseVisualStyleBackColor = true;
            // 
            // start_eval_btn
            // 
            this.start_eval_btn.Location = new System.Drawing.Point(84, 415);
            this.start_eval_btn.Name = "start_eval_btn";
            this.start_eval_btn.Size = new System.Drawing.Size(148, 23);
            this.start_eval_btn.TabIndex = 15;
            this.start_eval_btn.Text = "Начать оценку";
            this.start_eval_btn.UseVisualStyleBackColor = true;
            this.start_eval_btn.Click += new System.EventHandler(this.start_eval_btn_Click);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(111, 364);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 23);
            this.test_btn.TabIndex = 16;
            this.test_btn.Text = "test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.start_eval_btn);
            this.Controls.Add(this.IsReversedProperty);
            this.Controls.Add(this.add_property);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.group_names_cb);
            this.Controls.Add(this.property_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.property_group_name);
            this.Controls.Add(this.add_group_button);
            this.Controls.Add(this.add_controller_button);
            this.Name = "StartWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button add_controller_button;
        private System.Windows.Forms.Button add_group_button;
        private System.Windows.Forms.TextBox property_group_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox property_name;
        private System.Windows.Forms.ComboBox group_names_cb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_property;
        private System.Windows.Forms.CheckBox IsReversedProperty;
        private System.Windows.Forms.Button start_eval_btn;
        private System.Windows.Forms.Button test_btn;
    }
}

