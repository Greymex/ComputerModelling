using ComputerModellingLib;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

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
            if (group_panel.ValidateGroupControl())
            {
                group_panel.AddGroups();
                group_panel.BuildGroupsComboBox();
            }
        }

        //Добавление свойства
        private void add_property_Click(object sender, EventArgs e)
        {
            if (group_panel.ValidatePropertyControl())
            {
                group_panel.AddProperty();
                group_panel.BuildPropertiesViewItems();
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
                    if (controllers_panel.SelectedItem is Controller)
                    {
                        assessments_panel.AddGroupToController(controllers_panel.SelectedItem as Controller);
                        controllers_panel.BuildControllersViewItems();
                        assessments_panel.ClearGrid();
                        MessageBox.Show("Группа успешно добавлена!");
                    }
                    else MessageBox.Show("Выберите контроллер!");
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
                    group_panel.AddGroups(loaded_controller.PropertyGroups);
                    group_panel.BuildGroupsComboBox();
                    group_panel.BuildPropertiesViewItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка! Проверьте правильность выбранного файла!", "Ошибка!");
            }
        }

        //Оценка контроллеров
        private void оценитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (controllers_panel.Controllers.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один контроллер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Comparer comparer = new Comparer(controllers_panel.Controllers);

            foreach (Controller controller in controllers_panel.Controllers)
            {
                controller.SetAdditiveEstimate(comparer.PropertyInfos);
            }

            try
            {
                Output output = new Output();
                output.BuildGrid(controllers_panel.Controllers.First().PropertyGroups, controllers_panel.Controllers);
                output.GetAnswer();
                output.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка! Проверьте правильность выбранного файла!", "Ошибка!");
            }

            
        }

        //Обновление контроллеров для сохранения
        private void Update_controllers_for_save(object sender, EventArgs e)
        {
            try
            {
                save_ctrl_StripMenuItem.DropDownItems.Clear();
                foreach (var controller in controllers_panel.Controllers)
                {
                    save_ctrl_StripMenuItem.DropDownItems.Add(controller.ControllerName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            
        }

        private void save_new_values_btn_Click(object sender, EventArgs e)
        {
            if (!change_assessments_panel.AreThereErrors())
            {
                try
                {
                    if (controllers_panel.SelectedController != null && controllers_panel.SelectedItem != null)
                    {
                        change_assessments_panel.AddGroupToController(controllers_panel.SelectedController, controllers_panel.SelectedItem as PropertyGroup);
                        controllers_panel.BuildControllersViewItems();
                        change_assessments_panel.SetControllers(controllers_panel.Controllers);
                        change_assessments_panel.ClearGrid();
                        MessageBox.Show("Группа успешно обновлена!");
                    }
                    else MessageBox.Show("Сначала выберите группу в окне Контроллеры!");
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
            group_panel.DeleteChosenItem();
            group_panel.BuildGroupsComboBox();
            group_panel.BuildPropertiesViewItems();
        }

        private void RemoveChosenElement_Click(object sender, EventArgs e)
        {
            if (controllers_panel.SelectedItem != null)
            {
                controllers_panel.DeleteChosenItem();
                controllers_panel.BuildControllersViewItems();
            }
            else MessageBox.Show("Сначала выберите элемент!");
        }

        //Обновление групп и контроллеров в комбобоксах
        private void Update_Groups_and_Ctrls(object sender, EventArgs e)
        {
            controllers_panel.BuildControllersViewItems();
            assessments_panel.SetGroups(group_panel.PropertyGroups);
            assessments_panel.UpdateGroupsComboBox();
            assessments_panel.SetControllers(controllers_panel.Controllers);
            
            assessments_panel.ClearGrid();
            change_assessments_panel.SetControllers(controllers_panel.Controllers);
            change_assessments_panel.ClearGrid();

            if (controllers_panel.SelectedController != null)
                assessments_panel.SetControllerForView(controllers_panel.SelectedController);
            else assessments_panel.SetControllerForView();
        }

        private void оценитьИСохранитьВExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controllers_panel.Controllers.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один контроллер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            оценитьToolStripMenuItem1_Click(sender, e);
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "(*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            try
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileWriter.CreateXLCfileAndWrite(controllers_panel.Controllers,
                        controllers_panel.Controllers[0].PropertyGroups[0].Properties[0].ExpertAssessments.Count,
                        Path.GetFullPath(fileDialog.FileName));
                    //FileWriter.CreateCSVfileAndWrite(controllers_panel.Controllers,
                    //    controllers_panel.Controllers[0].PropertyGroups[0].Properties[0].ExpertAssessments.Count, 
                    //    Path.GetFullPath(fileDialog.FileName));
                    MessageBox.Show("Данные сохранены");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка! Файл не сохранен!");
            }

            

            
        }

        private void add_group_to_controller_Click(object sender, EventArgs e)
        {
            if (controllers_panel.SelectedController != null)
            {
                controllers_tab.SelectTab("add_assessments_tab");
                assessments_panel.SetControllerForView(controllers_panel.SelectedController);
            }
            else MessageBox.Show("Сначала выберите контроллер!");
        }

        private void change_group_Click(object sender, EventArgs e)
        {

            if (controllers_panel.SelectedController != null && controllers_panel.SelectedItem is PropertyGroup)
            {
                controllers_tab.SelectTab("change_assessments_tab");
                change_assessments_panel.BuildGrid(controllers_panel.SelectedController, controllers_panel.SelectedItem as PropertyGroup);
            }
            else MessageBox.Show("Сначала выберите группу!");

        }

        private void save_ctrl_StripMenuItem_Click(object sender, EventArgs e)
        {
            if (controllers_panel.Controllers.Count == 0)
            {
                MessageBox.Show("В системе не найдено контроллеров для сохранения!", "Ошибка!");
            }
        }

        private void сохранитьВсеКонтроллерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (controllers_panel.Controllers.Count == 0)
            {
                MessageBox.Show("В системе не найдено контроллеров для сохранения!", "Ошибка!");
            }
            else
            {
                ControllerGroupSaver groupSaver = new ControllerGroupSaver();
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "Все файлы (*.*)|*.*";
                fileDialog.RestoreDirectory = true;
                fileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Controllers";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    groupSaver.Save(Path.GetDirectoryName(fileDialog.FileName), Path.GetFileNameWithoutExtension(fileDialog.FileName), controllers_panel.Controllers);
                    MessageBox.Show("Данные сохранены");
                }

            }
        }

        private void загрузитьГруппуКонтроллеровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                controllers_panel.LoadControllersList();
                controllers_panel.BuildControllersViewItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Контроллеры не были загружены по причине того, что файл не был выбран!", "Загрузка отменена!");
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                path += "\\Info.pdf";
                Process.Start(path);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл справки не найден!");
            }

            
        }

        private void Default_btn_Click(object sender, EventArgs e)
        {
            group_panel.ClearAllGroups();
            group_panel.AddStandartGroups();
            group_panel.BuildPropertiesViewItems();
            group_panel.BuildGroupsComboBox();
            Update_Groups_and_Ctrls(sender, e);
        }

        private void ReturnLastDeleted_btn_Click(object sender, EventArgs e)
        {
            try
            {
                controllers_panel.GetBackDeletedItem();
                controllers_panel.BuildControllersViewItems();
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }
    }
}
