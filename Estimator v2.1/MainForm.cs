using ComputerModellingLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimator_v2._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Добавление группы свойств
        private void add_group_Click(object sender, EventArgs e)
        {
            if (groups_panel.ValidateGroupControl())
            {
                groups_panel.AddGroups();
                groups_panel.BuildGroupsComboBox();
            }
        }

        //Добавление свойства
        private void add_property_Click(object sender, EventArgs e)
        {
            if (groups_panel.ValidatePropertyControl())
            {
                groups_panel.AddProperty();
                groups_panel.BuildPropertiesViewItems();
            }
        }
        //Добавление оценок
        private void add_value_Click(object sender, EventArgs e)
        {
            try
            {
                assessments_panel.BuildGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Добавление контроллера
        private void add_controller_button_Click(object sender, EventArgs e)
        {
            if (controllers_panel.ValidateControllerControl())
            {
                controllers_panel.AddController();
                controllers_panel.BuildControllersViewItems();
            }
        }

        //Добавление группы к контроллеру
        private void save_values_to_ctrl_Click(object sender, EventArgs e)
        {
            if (!assessments_panel.AreThereErrors())
            {
                try
                {
                    assessments_panel.AddGroupToController();
                    controllers_panel.BuildControllersViewItems();
                    assessments_panel.ClearGrid();
                    MessageBox.Show("Группа успешно добавлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Введенные данные некорректны!");
        }

        //Удаление всех контроллеров из системы
        private void clear_ctrls_btn_Click(object sender, EventArgs e)
        {
            controllers_panel.ClearControllers();
        }

        //Загрузка контроллера
        private void загрузитьКонтроллерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Controller loaded_controller = controllers_panel.LoadController();
                if (loaded_controller != null)
                {
                    controllers_panel.BuildControllersViewItems();
                    groups_panel.AddGroups(loaded_controller.PropertyGroups);
                    groups_panel.BuildGroupsComboBox();
                    groups_panel.BuildPropertiesViewItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Оценка контроллеров
        private void оценитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Comparer comparer = new Comparer(controllers_panel.Controllers);

            foreach (Controller controller in controllers_panel.Controllers)
            {
                controller.SetAdditiveEstimate(comparer.PropertyInfos);
            }

            Output output = new Output();
            output.BuildGrid(controllers_panel.Controllers.First().PropertyGroups, controllers_panel.Controllers);
            output.GetAnswer();
            output.Show();
        }

        //Обновление контроллеров для сохранения
        private void Update_controllers_for_save(object sender, EventArgs e)
        {
            save_ctrl_StripMenuItem.DropDownItems.Clear();
            foreach (var controller in controllers_panel.Controllers)
            {
                save_ctrl_StripMenuItem.DropDownItems.Add(controller.ControllerName);
            }
        }

        //Сохранить контроллер
        private void save_StripMenuItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (var controller in controllers_panel.Controllers)
            {
                if (controller.ControllerName == e.ClickedItem.Text)
                {
                    controller.Save();
                    MessageBox.Show($"Контроллер {e.ClickedItem.Text} успешно сохранен", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }

        private void change_marks_btn_Click(object sender, EventArgs e)
        {
            change_assessments_panel.BuildGrid();
        }

        private void save_new_values_btn_Click(object sender, EventArgs e)
        {
            if (!change_assessments_panel.AreThereErrors())
            {
                try
                {
                    change_assessments_panel.AddGroupToController();
                    controllers_panel.BuildControllersViewItems();
                    change_assessments_panel.SetControllers(controllers_panel.Controllers);
                    change_assessments_panel.ClearGrid();
                    MessageBox.Show("Группа успешно обновлена!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Введенные данные некорректны!");
        }

        private void DeleteChosenItem_Click(object sender, EventArgs e)
        {
            groups_panel.DeleteChosenItem();
            groups_panel.BuildGroupsComboBox();
            groups_panel.BuildPropertiesViewItems();
        }

        private void RemoveChosenElement_Click(object sender, EventArgs e)
        {
            controllers_panel.DeleteChosenItem();
            controllers_panel.BuildControllersViewItems();
        }

        //Обновление групп и контроллеров в комбобоксах
        private void Update_Groups_and_Ctrls(object sender, EventArgs e)
        {
            assessments_panel.SetGroups(groups_panel.PropertyGroups);
            assessments_panel.UpdateGroupsComboBox();
            assessments_panel.SetControllers(controllers_panel.Controllers);
            assessments_panel.UpdateControllersComboBox();
            assessments_panel.ClearGrid();
            change_assessments_panel.SetControllers(controllers_panel.Controllers);
            change_assessments_panel.UpdateControllersComboBox();
            change_assessments_panel.UpdateGroupsComboBox();
            change_assessments_panel.ClearGrid();
        }
    }
}
