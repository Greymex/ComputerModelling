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
        public void BuildGrid(Controller controller, PropertyGroup group)
        {
            ClearGrid();
            if (controller != null && group != null)
            {
                controller_lb.Text = controller.ControllerName;
                int temp = 0;
                foreach (var proprerty in controller.PropertyGroups.Find(t => t.PropetyGroupName == group.PropetyGroupName).Properties)
                {
                    if (proprerty.ExpertAssessments.Count > temp)
                        temp = proprerty.ExpertAssessments.Count;
                }

                if (temp == 0)
                { MessageBox.Show("Ошибка! Ни одно свойство не имеет оценок!"); return; }

                BuildColumns(temp);
                BuildRows(controller.PropertyGroups.Find(x => x.PropetyGroupName == group.PropetyGroupName));
                AddValues(controller, controller.PropertyGroups.Find(x => x.PropetyGroupName == group.PropetyGroupName));
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
                    evaluation_grid.Rows[i].Cells[j].Value = group_for_change.Properties[i].ExpertAssessments[j];
                }
                evaluation_grid.Rows[i].Cells[evaluation_grid.Rows[i].Cells.Count - 1].Value = group_for_change.Properties[i].Value;
            }

        }

        //Очистка грида
        public void ClearGrid()
        {
            evaluation_grid.Columns.Clear();
            evaluation_grid.Rows.Clear();
            controller_lb.Text = "";
        }

        //Создание колонок
        private void BuildColumns(int experts_count)
        {
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

            DataGridViewColumn last_column = new DataGridViewColumn();
            last_column.HeaderText = "Значение критерия";
            last_column.Width = 120;
            last_column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            last_column.CellTemplate = new DataGridViewTextBoxCell();
            evaluation_grid.Columns.Add(last_column);
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
                if (!property_group.Properties[i].Reversed)
                    evaluation_grid.Rows[i].HeaderCell.Value = property_group.Properties[i].Name + "*";
                else evaluation_grid.Rows[i].HeaderCell.Value = property_group.Properties[i].Name;
            }

            evaluation_grid.RowHeadersWidth = 220;
        }

        //Добавление внесенной группы выбранному контроллеру
        public void AddGroupToController(Controller controller, PropertyGroup property_group)
        {
            if (controller == null)
            {
                MessageBox.Show("Сначала выберите контроллер!");
                return;
            }


            PropertyGroup addable_group = GetGroupWithValues(property_group);

            if (controller.PropertyGroups.Contains(addable_group, new PropertyGroupsComparer()))
            {
                controller.PropertyGroups.Remove(controller.PropertyGroups.Find(x => x.PropetyGroupName == addable_group.PropetyGroupName));
                controller.PropertyGroups.Add(addable_group);
            }
            else controller.AddPropertyGroup(addable_group);



        }

        //Внесение оценок в выбранную группу
        private PropertyGroup GetGroupWithValues(PropertyGroup property_group)
        {
            PropertyGroup new_group = new PropertyGroup(property_group.PropetyGroupName);
            Property p;

            for (int i = 0; i < evaluation_grid.RowCount; i++)
            {
                List<int> assesments = new List<int>();
                for (int j = 0; j < evaluation_grid.ColumnCount - 1; j++)
                {
                    assesments.Add(int.Parse(evaluation_grid[j, i].Value.ToString()));
                }
                if (property_group
                    .Properties
                    .Find(t => t.Name == evaluation_grid.Rows[i].HeaderCell.Value.ToString()
                    .Replace("*",""))
                    .Reversed)
                {
                    p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString(), double.Parse(evaluation_grid[evaluation_grid.ColumnCount - 1, i].Value.ToString()), assesments, true);
                }
                else p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString().Replace("*", ""), double.Parse(evaluation_grid[evaluation_grid.ColumnCount - 1, i].Value.ToString()), assesments, false);
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
                for (int j = 0; j < evaluation_grid.ColumnCount - 1; j++)
                {
                    if (evaluation_grid[j, i].Value == null || !StringIsDigits(evaluation_grid[j, i].Value.ToString()) || int.Parse(evaluation_grid[j, i].Value.ToString()) > 10)
                    {
                        evaluation_grid[j, i].Style.ForeColor = Color.Red;
                        return true;
                    }
                }
                if (evaluation_grid[evaluation_grid.ColumnCount - 1, i].Value == null || !IsDouble(evaluation_grid[0, i].Value.ToString()))
                {
                    evaluation_grid[evaluation_grid.ColumnCount - 1, i].Style.ForeColor = Color.Red;
                    return true;
                }
            }
            return false;
        }

        private void Delete_Pressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                evaluation_grid.SelectedCells[0].Value = "";
            }
        }

        
    }
}
