namespace Estimator_v2._1
{
    partial class ControllersPanel
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
            this.controller_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.controllers_view = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controller_name
            // 
            this.controller_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.controller_name.Location = new System.Drawing.Point(222, 32);
            this.controller_name.Name = "controller_name";
            this.controller_name.Size = new System.Drawing.Size(120, 20);
            this.controller_name.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Введите название контроллера:";
            // 
            // controllers_view
            // 
            this.controllers_view.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controllers_view.Location = new System.Drawing.Point(441, 32);
            this.controllers_view.Name = "controllers_view";
            this.controllers_view.Size = new System.Drawing.Size(277, 201);
            this.controllers_view.TabIndex = 33;
            this.controllers_view.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.GetSelectedNode);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Все контроллеры в системе:";
            // 
            // ControllersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controllers_view);
            this.Controls.Add(this.controller_name);
            this.Controls.Add(this.label5);
            this.Name = "ControllersPanel";
            this.Size = new System.Drawing.Size(721, 244);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox controller_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView controllers_view;
        private System.Windows.Forms.Label label1;
    }
}
