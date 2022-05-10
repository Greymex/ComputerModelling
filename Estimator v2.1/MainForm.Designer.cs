namespace Estimator_v2._1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.controllers_tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Default_btn = new System.Windows.Forms.Button();
            this.DeleteChosenItem = new System.Windows.Forms.Button();
            this.add_property = new System.Windows.Forms.Button();
            this.add_group = new System.Windows.Forms.Button();
            this.group_panel = new Estimator_v2.GroupPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.change_group = new System.Windows.Forms.Button();
            this.RemoveChosenElement = new System.Windows.Forms.Button();
            this.add_controller_button = new System.Windows.Forms.Button();
            this.clear_ctrls_btn = new System.Windows.Forms.Button();
            this.add_group_to_controller = new System.Windows.Forms.Button();
            this.controllers_panel = new Estimator_v2._1.ControllersPanel();
            this.add_assessments_tab = new System.Windows.Forms.TabPage();
            this.save_values_to_ctrl = new System.Windows.Forms.Button();
            this.add_value = new System.Windows.Forms.Button();
            this.assessments_panel = new Estimator_v2._1.AssessmentsPanel();
            this.change_assessments_tab = new System.Windows.Forms.TabPage();
            this.save_new_values_btn = new System.Windows.Forms.Button();
            this.change_assessments_panel = new Estimator_v2._1.ChangeAssessmentsPanel();
            this.info_btn = new System.Windows.Forms.Button();
            this.test_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеКонтроллерамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьКонтроллерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьГруппуКонтроллеровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ctrl_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВсеКонтроллерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оценитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оценитьИСохранитьВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnLastDeleted_btn = new System.Windows.Forms.Button();
            this.controllers_tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.add_assessments_tab.SuspendLayout();
            this.change_assessments_tab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controllers_tab
            // 
            this.controllers_tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controllers_tab.Controls.Add(this.tabPage1);
            this.controllers_tab.Controls.Add(this.tabPage2);
            this.controllers_tab.Controls.Add(this.add_assessments_tab);
            this.controllers_tab.Controls.Add(this.change_assessments_tab);
            this.controllers_tab.Location = new System.Drawing.Point(0, 32);
            this.controllers_tab.Name = "controllers_tab";
            this.controllers_tab.SelectedIndex = 0;
            this.controllers_tab.Size = new System.Drawing.Size(913, 511);
            this.controllers_tab.TabIndex = 26;
            this.controllers_tab.Click += new System.EventHandler(this.Update_Groups_and_Ctrls);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Default_btn);
            this.tabPage1.Controls.Add(this.DeleteChosenItem);
            this.tabPage1.Controls.Add(this.add_property);
            this.tabPage1.Controls.Add(this.add_group);
            this.tabPage1.Controls.Add(this.group_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(905, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Критерий оценки и характеристики ПЛК";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Default_btn
            // 
            this.Default_btn.Location = new System.Drawing.Point(9, 446);
            this.Default_btn.Name = "Default_btn";
            this.Default_btn.Size = new System.Drawing.Size(175, 23);
            this.Default_btn.TabIndex = 31;
            this.Default_btn.Text = "Вернуть начальные значения";
            this.Default_btn.UseVisualStyleBackColor = true;
            this.Default_btn.Click += new System.EventHandler(this.Default_btn_Click);
            // 
            // DeleteChosenItem
            // 
            this.DeleteChosenItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteChosenItem.Location = new System.Drawing.Point(8, 416);
            this.DeleteChosenItem.Name = "DeleteChosenItem";
            this.DeleteChosenItem.Size = new System.Drawing.Size(176, 23);
            this.DeleteChosenItem.TabIndex = 29;
            this.DeleteChosenItem.Text = "Удалить выбранный элемент";
            this.DeleteChosenItem.UseVisualStyleBackColor = true;
            this.DeleteChosenItem.Click += new System.EventHandler(this.DeleteChosenItem_Click);
            // 
            // add_property
            // 
            this.add_property.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_property.Location = new System.Drawing.Point(679, 356);
            this.add_property.Name = "add_property";
            this.add_property.Size = new System.Drawing.Size(155, 24);
            this.add_property.TabIndex = 27;
            this.add_property.Text = "Добавить свойство";
            this.add_property.UseVisualStyleBackColor = true;
            this.add_property.Click += new System.EventHandler(this.add_property_Click);
            // 
            // add_group
            // 
            this.add_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_group.Location = new System.Drawing.Point(679, 199);
            this.add_group.Name = "add_group";
            this.add_group.Size = new System.Drawing.Size(155, 23);
            this.add_group.TabIndex = 6;
            this.add_group.Text = "Добавить группу свойств";
            this.add_group.UseVisualStyleBackColor = true;
            this.add_group.Click += new System.EventHandler(this.add_group_Click);
            // 
            // group_panel
            // 
            this.group_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_panel.Location = new System.Drawing.Point(8, 3);
            this.group_panel.Name = "group_panel";
            this.group_panel.Size = new System.Drawing.Size(894, 419);
            this.group_panel.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ReturnLastDeleted_btn);
            this.tabPage2.Controls.Add(this.change_group);
            this.tabPage2.Controls.Add(this.RemoveChosenElement);
            this.tabPage2.Controls.Add(this.add_controller_button);
            this.tabPage2.Controls.Add(this.clear_ctrls_btn);
            this.tabPage2.Controls.Add(this.add_group_to_controller);
            this.tabPage2.Controls.Add(this.controllers_panel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(905, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контроллеры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // change_group
            // 
            this.change_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.change_group.Location = new System.Drawing.Point(602, 254);
            this.change_group.Name = "change_group";
            this.change_group.Size = new System.Drawing.Size(228, 23);
            this.change_group.TabIndex = 30;
            this.change_group.Text = "Изменить экспертные оценки в группе";
            this.change_group.UseVisualStyleBackColor = true;
            this.change_group.Click += new System.EventHandler(this.change_group_Click);
            // 
            // RemoveChosenElement
            // 
            this.RemoveChosenElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveChosenElement.Location = new System.Drawing.Point(602, 351);
            this.RemoveChosenElement.Name = "RemoveChosenElement";
            this.RemoveChosenElement.Size = new System.Drawing.Size(228, 23);
            this.RemoveChosenElement.TabIndex = 28;
            this.RemoveChosenElement.Text = "Удалить выбранный элемент";
            this.RemoveChosenElement.UseVisualStyleBackColor = true;
            this.RemoveChosenElement.Click += new System.EventHandler(this.RemoveChosenElement_Click);
            // 
            // add_controller_button
            // 
            this.add_controller_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_controller_button.Location = new System.Drawing.Point(602, 92);
            this.add_controller_button.Name = "add_controller_button";
            this.add_controller_button.Size = new System.Drawing.Size(228, 23);
            this.add_controller_button.TabIndex = 4;
            this.add_controller_button.Text = "Добавить контроллер";
            this.add_controller_button.UseVisualStyleBackColor = true;
            this.add_controller_button.Click += new System.EventHandler(this.add_controller_button_Click);
            // 
            // clear_ctrls_btn
            // 
            this.clear_ctrls_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_ctrls_btn.Location = new System.Drawing.Point(20, 400);
            this.clear_ctrls_btn.Name = "clear_ctrls_btn";
            this.clear_ctrls_btn.Size = new System.Drawing.Size(228, 23);
            this.clear_ctrls_btn.TabIndex = 18;
            this.clear_ctrls_btn.Text = "Очистить список контроллеров";
            this.clear_ctrls_btn.UseVisualStyleBackColor = true;
            this.clear_ctrls_btn.Click += new System.EventHandler(this.clear_ctrls_btn_Click);
            // 
            // add_group_to_controller
            // 
            this.add_group_to_controller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_group_to_controller.Location = new System.Drawing.Point(602, 174);
            this.add_group_to_controller.Name = "add_group_to_controller";
            this.add_group_to_controller.Size = new System.Drawing.Size(228, 23);
            this.add_group_to_controller.TabIndex = 29;
            this.add_group_to_controller.Text = "Добавить группу и экспертные оценки";
            this.add_group_to_controller.UseVisualStyleBackColor = true;
            this.add_group_to_controller.Click += new System.EventHandler(this.add_group_to_controller_Click);
            // 
            // controllers_panel
            // 
            this.controllers_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controllers_panel.Location = new System.Drawing.Point(3, 6);
            this.controllers_panel.Name = "controllers_panel";
            this.controllers_panel.Size = new System.Drawing.Size(889, 390);
            this.controllers_panel.TabIndex = 31;
            // 
            // add_assessments_tab
            // 
            this.add_assessments_tab.Controls.Add(this.save_values_to_ctrl);
            this.add_assessments_tab.Controls.Add(this.add_value);
            this.add_assessments_tab.Controls.Add(this.assessments_panel);
            this.add_assessments_tab.Location = new System.Drawing.Point(4, 22);
            this.add_assessments_tab.Name = "add_assessments_tab";
            this.add_assessments_tab.Padding = new System.Windows.Forms.Padding(3);
            this.add_assessments_tab.Size = new System.Drawing.Size(905, 485);
            this.add_assessments_tab.TabIndex = 3;
            this.add_assessments_tab.Text = "Добавление оценок контроллера";
            this.add_assessments_tab.UseVisualStyleBackColor = true;
            // 
            // save_values_to_ctrl
            // 
            this.save_values_to_ctrl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save_values_to_ctrl.Location = new System.Drawing.Point(374, 441);
            this.save_values_to_ctrl.Name = "save_values_to_ctrl";
            this.save_values_to_ctrl.Size = new System.Drawing.Size(198, 36);
            this.save_values_to_ctrl.TabIndex = 25;
            this.save_values_to_ctrl.Text = "Сохранить";
            this.save_values_to_ctrl.UseVisualStyleBackColor = true;
            this.save_values_to_ctrl.Click += new System.EventHandler(this.save_values_to_ctrl_Click);
            // 
            // add_value
            // 
            this.add_value.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_value.Location = new System.Drawing.Point(640, 28);
            this.add_value.Name = "add_value";
            this.add_value.Size = new System.Drawing.Size(124, 23);
            this.add_value.TabIndex = 24;
            this.add_value.Text = "Ввести оценки";
            this.add_value.UseVisualStyleBackColor = true;
            this.add_value.Click += new System.EventHandler(this.add_value_Click);
            // 
            // assessments_panel
            // 
            this.assessments_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assessments_panel.Location = new System.Drawing.Point(0, 0);
            this.assessments_panel.Name = "assessments_panel";
            this.assessments_panel.Size = new System.Drawing.Size(905, 485);
            this.assessments_panel.TabIndex = 26;
            // 
            // change_assessments_tab
            // 
            this.change_assessments_tab.Controls.Add(this.save_new_values_btn);
            this.change_assessments_tab.Controls.Add(this.change_assessments_panel);
            this.change_assessments_tab.Location = new System.Drawing.Point(4, 22);
            this.change_assessments_tab.Name = "change_assessments_tab";
            this.change_assessments_tab.Padding = new System.Windows.Forms.Padding(3);
            this.change_assessments_tab.Size = new System.Drawing.Size(905, 485);
            this.change_assessments_tab.TabIndex = 2;
            this.change_assessments_tab.Text = "Изменение оценок контроллера";
            this.change_assessments_tab.UseVisualStyleBackColor = true;
            // 
            // save_new_values_btn
            // 
            this.save_new_values_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save_new_values_btn.Location = new System.Drawing.Point(377, 433);
            this.save_new_values_btn.Name = "save_new_values_btn";
            this.save_new_values_btn.Size = new System.Drawing.Size(161, 44);
            this.save_new_values_btn.TabIndex = 20;
            this.save_new_values_btn.Text = "Сохранить изменения";
            this.save_new_values_btn.UseVisualStyleBackColor = true;
            this.save_new_values_btn.Click += new System.EventHandler(this.save_new_values_btn_Click);
            // 
            // change_assessments_panel
            // 
            this.change_assessments_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.change_assessments_panel.Location = new System.Drawing.Point(31, 9);
            this.change_assessments_panel.Name = "change_assessments_panel";
            this.change_assessments_panel.Size = new System.Drawing.Size(854, 473);
            this.change_assessments_panel.TabIndex = 21;
            // 
            // info_btn
            // 
            this.info_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.info_btn.Location = new System.Drawing.Point(3, 456);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(75, 23);
            this.info_btn.TabIndex = 24;
            this.info_btn.Text = "справка";
            this.info_btn.UseVisualStyleBackColor = true;
            // 
            // test_btn
            // 
            this.test_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.test_btn.Location = new System.Drawing.Point(683, 454);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(75, 23);
            this.test_btn.TabIndex = 23;
            this.test_btn.Text = "test";
            this.test_btn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеКонтроллерамиToolStripMenuItem,
            this.оценитьToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеКонтроллерамиToolStripMenuItem
            // 
            this.управлениеКонтроллерамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьКонтроллерToolStripMenuItem,
            this.загрузитьГруппуКонтроллеровToolStripMenuItem,
            this.save_ctrl_StripMenuItem,
            this.сохранитьВсеКонтроллерыToolStripMenuItem});
            this.управлениеКонтроллерамиToolStripMenuItem.Name = "управлениеКонтроллерамиToolStripMenuItem";
            this.управлениеКонтроллерамиToolStripMenuItem.ShowShortcutKeys = false;
            this.управлениеКонтроллерамиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.управлениеКонтроллерамиToolStripMenuItem.Text = "Файл";
            this.управлениеКонтроллерамиToolStripMenuItem.MouseEnter += new System.EventHandler(this.Update_controllers_for_save);
            // 
            // загрузитьКонтроллерToolStripMenuItem
            // 
            this.загрузитьКонтроллерToolStripMenuItem.Name = "загрузитьКонтроллерToolStripMenuItem";
            this.загрузитьКонтроллерToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.загрузитьКонтроллерToolStripMenuItem.Text = "Загрузить контроллер";
            this.загрузитьКонтроллерToolStripMenuItem.Click += new System.EventHandler(this.загрузитьКонтроллерToolStripMenuItem_Click);
            // 
            // загрузитьГруппуКонтроллеровToolStripMenuItem
            // 
            this.загрузитьГруппуКонтроллеровToolStripMenuItem.Name = "загрузитьГруппуКонтроллеровToolStripMenuItem";
            this.загрузитьГруппуКонтроллеровToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.загрузитьГруппуКонтроллеровToolStripMenuItem.Text = "Загрузить группу контроллеров";
            this.загрузитьГруппуКонтроллеровToolStripMenuItem.Click += new System.EventHandler(this.загрузитьГруппуКонтроллеровToolStripMenuItem_Click);
            // 
            // save_ctrl_StripMenuItem
            // 
            this.save_ctrl_StripMenuItem.Name = "save_ctrl_StripMenuItem";
            this.save_ctrl_StripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.save_ctrl_StripMenuItem.Text = "Сохранить контроллер";
            this.save_ctrl_StripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.save_StripMenuItem_Click);
            this.save_ctrl_StripMenuItem.Click += new System.EventHandler(this.save_ctrl_StripMenuItem_Click);
            // 
            // сохранитьВсеКонтроллерыToolStripMenuItem
            // 
            this.сохранитьВсеКонтроллерыToolStripMenuItem.Name = "сохранитьВсеКонтроллерыToolStripMenuItem";
            this.сохранитьВсеКонтроллерыToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.сохранитьВсеКонтроллерыToolStripMenuItem.Text = "Сохранить группу контроллеров";
            this.сохранитьВсеКонтроллерыToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсеКонтроллерыToolStripMenuItem_Click);
            // 
            // оценитьToolStripMenuItem
            // 
            this.оценитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оценитьToolStripMenuItem1,
            this.оценитьИСохранитьВExcelToolStripMenuItem});
            this.оценитьToolStripMenuItem.Name = "оценитьToolStripMenuItem";
            this.оценитьToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.оценитьToolStripMenuItem.Text = "Рассчитать";
            // 
            // оценитьToolStripMenuItem1
            // 
            this.оценитьToolStripMenuItem1.Name = "оценитьToolStripMenuItem1";
            this.оценитьToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
            this.оценитьToolStripMenuItem1.Text = "Рассчитать";
            this.оценитьToolStripMenuItem1.Click += new System.EventHandler(this.оценитьToolStripMenuItem1_Click);
            // 
            // оценитьИСохранитьВExcelToolStripMenuItem
            // 
            this.оценитьИСохранитьВExcelToolStripMenuItem.Name = "оценитьИСохранитьВExcelToolStripMenuItem";
            this.оценитьИСохранитьВExcelToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.оценитьИСохранитьВExcelToolStripMenuItem.Text = "Рассчитать и сохранить в Excel";
            this.оценитьИСохранитьВExcelToolStripMenuItem.Click += new System.EventHandler(this.оценитьИСохранитьВExcelToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // ReturnLastDeleted_btn
            // 
            this.ReturnLastDeleted_btn.Location = new System.Drawing.Point(602, 400);
            this.ReturnLastDeleted_btn.Name = "ReturnLastDeleted_btn";
            this.ReturnLastDeleted_btn.Size = new System.Drawing.Size(228, 23);
            this.ReturnLastDeleted_btn.TabIndex = 32;
            this.ReturnLastDeleted_btn.Text = "Вернуть удаленный элемент";
            this.ReturnLastDeleted_btn.UseVisualStyleBackColor = true;
            this.ReturnLastDeleted_btn.Click += new System.EventHandler(this.ReturnLastDeleted_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 543);
            this.Controls.Add(this.controllers_tab);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(929, 582);
            this.Name = "MainForm";
            this.Text = "Выбор программируемого логического контроллера методом экспертных оценок";
            this.controllers_tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.add_assessments_tab.ResumeLayout(false);
            this.change_assessments_tab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl controllers_tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button add_controller_button;
        private System.Windows.Forms.Button clear_ctrls_btn;
        private System.Windows.Forms.TabPage change_assessments_tab;
        private System.Windows.Forms.Button add_property;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеКонтроллерамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьКонтроллерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem save_ctrl_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оценитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оценитьИСохранитьВExcelToolStripMenuItem;
        private System.Windows.Forms.Button add_group;
        private GroupPanel group_panel;
        private System.Windows.Forms.TabPage add_assessments_tab;
        private System.Windows.Forms.Button add_value;
        private System.Windows.Forms.Button save_values_to_ctrl;
        private System.Windows.Forms.Button save_new_values_btn;
        private System.Windows.Forms.Button DeleteChosenItem;
        private System.Windows.Forms.Button RemoveChosenElement;
        private System.Windows.Forms.Button change_group;
        private ControllersPanel controllers_panel;
        private AssessmentsPanel assessments_panel;
        private ChangeAssessmentsPanel change_assessments_panel;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВсеКонтроллерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьГруппуКонтроллеровToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button add_group_to_controller;
        private System.Windows.Forms.Button Default_btn;
        private System.Windows.Forms.Button ReturnLastDeleted_btn;
    }
}

