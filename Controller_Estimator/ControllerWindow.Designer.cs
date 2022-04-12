namespace Controller_Estimator
{
    partial class ControllerWindow
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
            this.properties_groups_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.controller_name = new System.Windows.Forms.TextBox();
            this.add_value = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.experts_count = new System.Windows.Forms.NumericUpDown();
            this.add_controller_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.experts_count)).BeginInit();
            this.SuspendLayout();
            // 
            // properties_groups_cb
            // 
            this.properties_groups_cb.FormattingEnabled = true;
            this.properties_groups_cb.Location = new System.Drawing.Point(64, 170);
            this.properties_groups_cb.Name = "properties_groups_cb";
            this.properties_groups_cb.Size = new System.Drawing.Size(121, 21);
            this.properties_groups_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите группу свойств:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название контроллера:";
            // 
            // controller_name
            // 
            this.controller_name.Location = new System.Drawing.Point(73, 38);
            this.controller_name.Name = "controller_name";
            this.controller_name.Size = new System.Drawing.Size(100, 20);
            this.controller_name.TabIndex = 3;
            // 
            // add_value
            // 
            this.add_value.Location = new System.Drawing.Point(67, 353);
            this.add_value.Name = "add_value";
            this.add_value.Size = new System.Drawing.Size(124, 23);
            this.add_value.TabIndex = 6;
            this.add_value.Text = "Добавить оценки";
            this.add_value.UseVisualStyleBackColor = true;
            this.add_value.Click += new System.EventHandler(this.add_value_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество экспертов";
            // 
            // experts_count
            // 
            this.experts_count.Location = new System.Drawing.Point(71, 296);
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
            this.experts_count.Size = new System.Drawing.Size(120, 20);
            this.experts_count.TabIndex = 7;
            this.experts_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_controller_btn
            // 
            this.add_controller_btn.Location = new System.Drawing.Point(55, 398);
            this.add_controller_btn.Name = "add_controller_btn";
            this.add_controller_btn.Size = new System.Drawing.Size(146, 23);
            this.add_controller_btn.TabIndex = 9;
            this.add_controller_btn.Text = "Добавить контроллер";
            this.add_controller_btn.UseVisualStyleBackColor = true;
            this.add_controller_btn.Click += new System.EventHandler(this.add_controller_btn_Click);
            // 
            // ControllerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 433);
            this.Controls.Add(this.add_controller_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.experts_count);
            this.Controls.Add(this.add_value);
            this.Controls.Add(this.controller_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.properties_groups_cb);
            this.Name = "ControllerWindow";
            this.Text = "ControllerWindow";
            ((System.ComponentModel.ISupportInitialize)(this.experts_count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox properties_groups_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox controller_name;
        private System.Windows.Forms.Button add_value;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown experts_count;
        private System.Windows.Forms.Button add_controller_btn;
    }
}