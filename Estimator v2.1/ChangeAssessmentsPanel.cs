using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComputerModellingLib;

namespace Estimator_v2._1
{
    public partial class ChangeAssessmentsPanel : UserControl
    {
        //Поля, обрабатываемые в процессе добавления данных
        List<PropertyGroup> propertyGroups;
        List<Controller> controllers;


        //Конструктор
        public ChangeAssessmentsPanel()
        {
            InitializeComponent();
        }


        //Установка панели групп и свойств для последующего получения данных оттуда 
        private void SetGroups(List<PropertyGroup> property_groups)
        {
            propertyGroups = property_groups;
        }

        //Установка контроллеров
        public void SetControllers(List<Controller> controllers)
        {
            this.controllers = controllers;
        }

        //Создание грида со всеми свойствами
        public void BuildGrid()
        {
            ClearGrid();
            if (all_ctrls_cb.SelectedItem != null && properties_groups_cb.SelectedItem != null)
            {
                Controller controller = controllers.Find(x => x.ControllerName == all_ctrls_cb.SelectedItem.ToString());

                int temp = 0;
                foreach (var proprerty in controller.PropertyGroups.Find(t => t.PropetyGroupName == properties_groups_cb.SelectedItem.ToString()).Properties)
                {
                    if (proprerty.ExpertAssessments.Count > temp)
                        temp = proprerty.ExpertAssessments.Count;
                }

                if (temp == 0)
                { MessageBox.Show("Ошибка! Ни одно свойство не имеет оценок!"); return; }

                BuildColumns(temp);
                BuildRows(controller.PropertyGroups.Find(x => x.PropetyGroupName == properties_groups_cb.SelectedItem.ToString()));
                AddValues(controller, controller.PropertyGroups.Find(x => x.PropetyGroupName == properties_groups_cb.SelectedItem.ToString()));
            }
            else { MessageBox.Show("Сначала выберите данные!"); return; }

        }

        //Добавление значений контроллера
        public void AddValues(Controller controller, PropertyGroup group_for_change)
        {
            for (int i = 0; i < group_for_change.Properties.Count; i++)
            {
                for (int j = 0; j < group_for_change.Properties[i].ExpertAssessments.Count; j++)
                {
                    evaluation_grid.Rows[i].Cells[j + 1].Value = group_for_change.Properties[i].ExpertAssessments[j];
                }
                evaluation_grid.Rows[i].Cells[0].Value = group_for_change.Properties[i].Value;
            }

        }

        //Очистка грида
        public void ClearGrid()
        {
            evaluation_grid.Columns.Clear();
            evaluation_grid.Rows.Clear();
        }

        //Создание колонок
        private void BuildColumns(int experts_count)
        {
            DataGridViewColumn first_column = new DataGridViewColumn();
            first_column.HeaderText = "Значение критерия";
            first_column.Width = 120;
            first_column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            first_column.CellTemplate = new DataGridViewTextBoxCell();
            evaluation_grid.Columns.Add(first_column);

            for (int i = 0; i < experts_count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = $"Эксперт {i + 1}";
                column.Name = $"expert{i + 1}";
                column.Width = 100;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.CellTemplate = new DataGridViewTextBoxCell();
                evaluation_grid.Columns.Add(column);
            }
        }

        //Создание рядов
        private void BuildRows(PropertyGroup property_group)
        {
            int rows_count = property_group
                .Properties
                .Count;
            evaluation_grid.Rows.Add(rows_count);

            for (int i = 0; i < rows_count; i++)
            {
                evaluation_grid.Rows[i].HeaderCell.Value = property_group.Properties[i].Name;
            }

            evaluation_grid.RowHeadersWidth = 200;
        }

        //Добавление внесенной группы выбранному контроллеру
        public void AddGroupToController()
        {
            if (all_ctrls_cb.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите контроллер!");
                return;
            }

            Controller controller_for_group = controllers.Find(x => x.ControllerName == all_ctrls_cb.SelectedItem.ToString());
            PropertyGroup addable_group = GetrGroupWithValues();

            if (controller_for_group.PropertyGroups.Contains(addable_group, new PropertyGroupsComparer()))
            {
                controller_for_group.PropertyGroups.Remove(controller_for_group.PropertyGroups.Find(x => x.PropetyGroupName == addable_group.PropetyGroupName));
                controller_for_group.PropertyGroups.Add(addable_group);
            }
            else controller_for_group.AddPropertyGroup(addable_group);



        }

        //Внесение оценок в выбранную группу
        private PropertyGroup GetrGroupWithValues()
        {
            PropertyGroup new_group = new PropertyGroup(properties_groups_cb.SelectedItem.ToString());
            Property p;

            for (int i = 0; i < evaluation_grid.RowCount; i++)
            {
                List<int> assesments = new List<int>();
                for (int j = 1; j < evaluation_grid.ColumnCount; j++)
                {
                    assesments.Add(int.Parse(evaluation_grid[j, i].Value.ToString()));
                }
                if (propertyGroups
                    .Find(x => x.PropetyGroupName == new_group.PropetyGroupName)
                    .Properties
                    .Find(t => t.Name == evaluation_grid.Rows[i].HeaderCell.Value.ToString())
                    .Reversed)
                {
                    p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString(), double.Parse(evaluation_grid[0, i].Value.ToString()), assesments, true);
                }
                else p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString(), double.Parse(evaluation_grid[0, i].Value.ToString()), assesments, false);
                new_group.AddProperty(p);
            }
            return new_group;
        }

        //проверка на правильность введенных оценок экспертов
        bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false;
            }
            return true;
        }

        //проверка на правильность введенных значение критерия
        bool IsDouble(string s)
        {
            int coma_counter = 0;
            if (s == ",")
                return false;

            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                {
                    if (!item.Equals(','))
                        return false;
                    else
                    {
                        coma_counter++;
                        if (coma_counter > 1)
                            return false;
                    }
                }
            }
            return true;
        }

        //проверка на правильность всех значений в таблице
        public bool AreThereErrors()
        {
            for (int i = 0; i < evaluation_grid.RowCount; i++)
                for (int j = 0; j < evaluation_grid.ColumnCount; j++)
                    evaluation_grid[j, i].Style.ForeColor = Color.Black;

            for (int i = 0; i < evaluation_grid.RowCount; i++)
            {
                for (int j = 1; j < evaluation_grid.ColumnCount; j++)
                {
                    if (evaluation_grid[j, i].Value == null || !StringIsDigits(evaluation_grid[j, i].Value.ToString()) || int.Parse(evaluation_grid[j, i].Value.ToString()) > 10)
                    {
                        evaluation_grid[j, i].Style.ForeColor = Color.Red;
                        return true;
                    }
                }
                if (evaluation_grid[0, i].Value == null || !IsDouble(evaluation_grid[0, i].Value.ToString()))
                {
                    evaluation_grid[0, i].Style.ForeColor = Color.Red;
                    return true;
                }
            }
            return false;
        }

        //Обновление комбобоксов в соответствии с данными
        public void UpdateGroupsComboBox()
        {
            properties_groups_cb.Items.Clear();

            foreach (var group in propertyGroups)
            {
                properties_groups_cb.Items.Add(group.PropetyGroupName);
            }
            if (properties_groups_cb.Items.Count > 0)
                properties_groups_cb.SelectedIndex = 0;
            else properties_groups_cb.Text = "";

        }
        public void UpdateControllersComboBox()
        {
            all_ctrls_cb.Items.Clear();

            foreach (var controller in controllers)
            {
                all_ctrls_cb.Items.Add(controller.ControllerName);
            }

            if (all_ctrls_cb.Items.Count > 0)
                all_ctrls_cb.SelectedIndex = 0;
            else { all_ctrls_cb.Text = ""; SetGroups(new List<PropertyGroup>()); properties_groups_cb.Text = ""; }
        }

        private void UpdateGroupsForCurrentController(object sender, EventArgs e)
        {
            SetGroups(controllers.Find(x => x.ControllerName == all_ctrls_cb.SelectedItem.ToString()).PropertyGroups);
            UpdateGroupsComboBox();
        }
    }
}
