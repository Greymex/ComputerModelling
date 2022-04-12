using ComputerModellingLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller_Estimator
{
    public partial class PropertyWindow : Form
    {
        public PropertyWindow(PropertyGroup Group, string ControllerName)
        {
            InitializeComponent();
            this.Text = Group.PropetyGroupName + " " + ControllerName;
            group = Group;
        }
        PropertyGroup group;
        public PropertyGroup filled_group;


        public void BuildWindow(PropertyGroup group, int experts_count, string ControllerName)
        {
            this.Text = ControllerName;

            DataGridViewColumn first_column = new DataGridViewColumn();
            first_column.HeaderText = "Значение контроллера";
            first_column.Width = 150;
            first_column.CellTemplate = new DataGridViewTextBoxCell();
            evaluation_grid.Columns.Add(first_column);

            for (int i = 0; i < experts_count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = $"Эксперт {i + 1}";
                column.Name = $"expert{i + 1}";
                column.Width = 100;
                column.CellTemplate = new DataGridViewTextBoxCell();
                evaluation_grid.Columns.Add(column);
            }

            AddRowsNames();
        }

        private void AddRowsNames()
        {
            List<PropertyView> properties = new List<PropertyView>();
            for (int i = 0; i < StartWindow.properties.Count; i++)
            {
                if (StartWindow.properties[i].GroupName == group.PropetyGroupName)
                {
                    properties.Add(StartWindow.properties[i]);
                }
            }
            evaluation_grid.Rows.Add(properties.Count);
            evaluation_grid.RowHeadersWidth = 200;
            for (int i = 0; i < properties.Count; i++)
            {
                 evaluation_grid.Rows[i].HeaderCell.Value = properties[i].PropertyName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PropertyGroup new_group = new PropertyGroup(group.PropetyGroupName);
            Property p;
            for (int i = 0; i < evaluation_grid.RowCount; i++)
            {
                List<int> assesments = new List<int>();
                for (int j = 1; j < evaluation_grid.ColumnCount; j++)
                {
                    assesments.Add(int.Parse(evaluation_grid[j, i].Value.ToString()));
                }
                if (evaluation_grid.Rows[i].HeaderCell.Value.ToString().Last().Equals('*'))
                {
                    p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString(), double.Parse(evaluation_grid[0, i].Value.ToString()), assesments, true);
                }
                else p = new Property(evaluation_grid.Rows[i].HeaderCell.Value.ToString(), double.Parse(evaluation_grid[0, i].Value.ToString()), assesments, false);
                new_group.AddProperty(p);
            }

            filled_group = new_group;
            Close();
        }
    }
}
