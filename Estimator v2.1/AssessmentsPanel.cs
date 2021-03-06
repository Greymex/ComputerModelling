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
    public partial class AssessmentsPanel : UserControl
    {
        //Поля, обрабатываемые в процессе добавления данных
        List<PropertyGroup> propertyGroups;
        List<Controller> controllers;


        //Конструктор
        public AssessmentsPanel()
        {
            InitializeComponent();
        }
        

        //Установка панели групп и свойств для последующего получения данных оттуда 
        public void SetGroups(List<PropertyGroup> property_groups)
        {
            propertyGroups = property_groups;
        }

        //Установка контроллеров
        public void SetControllers(List<Controller> controllers)
        {
            this.controllers = controllers;
        }

        //Обозначение контроллера
        public void SetControllerForView(Controller controller)
        {
            if (controller != null)
                controller_lb.Text = controller.ControllerName;
        }

        public void SetControllerForView()
        {
                controller_lb.Text = "Контроллер не выбран";
        }

        //Создание грида со всеми свойствами
        public void BuildGrid()
        {
            ClearGrid();
            if (properties_groups_cb.SelectedItem != null)
            {
                BuildColumns(int.Parse(experts_count.Value.ToString()));
                BuildRows(propertyGroups.Find(x => x.PropetyGroupName == properties_groups_cb.SelectedItem.ToString()));
            }
            else { MessageBox.Show("Сначала выберите группу!"); return; }
            
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
            for (int i = 0; i < experts_count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = $"Эксперт {i + 1}";
                column.Name = $"expert{i + 1}";
                column.Width = 100;
                column.CellTemplate = new DataGridViewTextBoxCell();
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                //evaluation_grid.Rows[i].HeaderCell.Value = property_group.Properties[i].Name;
            }

            evaluation_grid.RowHeadersWidth = 220;
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
        

        //Добавление внесенной группы выбранному контроллеру
        public void AddGroupToController(Controller controller)
        {
            if (controller == null)
            {
                MessageBox.Show("Сначала выберите контроллер!");
                return;
            }


            PropertyGroup addable_group = GetrGroupWithValues();

            if (controller.PropertyGroups.Contains(addable_group, new PropertyGroupsComparer()))
            {
                controller.PropertyGroups.Remove(controller.PropertyGroups.Find(x => x.PropetyGroupName == addable_group.PropetyGroupName));
                controller.PropertyGroups.Add(addable_group);
            }
            else controller.AddPropertyGroup(addable_group);

        }

        //Внесение оценок в выбранную группу
        private PropertyGroup GetrGroupWithValues()
        {
            PropertyGroup new_group = new PropertyGroup(properties_groups_cb.SelectedItem.ToString());
            Property p;

            for (int i = 0; i < evaluation_grid.RowCount; i++)
            {
                List<int> assesments = new List<int>();
                for (int j = 0; j < evaluation_grid.ColumnCount - 1; j++)
                {
                    assesments.Add(int.Parse(evaluation_grid[j, i].Value.ToString()));
                }
                if (propertyGroups
                    .Find(x => x.PropetyGroupName == new_group.PropetyGroupName)
                    .Properties
                    .Find(t => t.Name == evaluation_grid.Rows[i].HeaderCell.Value.ToString().Replace("*",""))
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
                    else {
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
            if (evaluation_grid.RowCount == 0 || evaluation_grid.ColumnCount == 0)
                return true;

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
