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
using System.Windows.Forms.DataVisualization.Charting;

namespace Estimator_v2._1
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        List<PropertyGroup> propertyGroups;
        List<Controller> controllers;

        public void BuildGrid(List<PropertyGroup> propertyGroups, List<Controller> controllers)
        {
            this.propertyGroups = propertyGroups;
            this.controllers = controllers;

            for (int i = 0; i < propertyGroups.Count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = $"K_{propertyGroups[i].PropetyGroupName}";
                column.Width = 100;
                column.CellTemplate = new DataGridViewTextBoxCell();
                output_grid.Columns.Add(column);
            }

            DataGridViewColumn last_column = new DataGridViewColumn();
            last_column.HeaderText = $"K_общ";
            last_column.Width = 100;
            last_column.CellTemplate = new DataGridViewTextBoxCell();
            output_grid.Columns.Add(last_column);

            controllers.Sort((x, y) => x.AdditiveEstimate.CompareTo(y.AdditiveEstimate));
            controllers.Reverse();

            AddRowsNames();
        }

        private void AddRowsNames()
        {
            output_grid.Rows.Add(controllers.Count);
            output_grid.RowHeadersWidth = 100;
            for (int i = 0; i < controllers.Count; i++)
            {
                output_grid.Rows[i].HeaderCell.Value = controllers[i].ControllerName;
            }


        }

        public void GetAnswer()
        {
            best_lb.Text = controllers[0].ControllerName;

            for (int i = 0; i < output_grid.RowCount - 1; i++)
            {
                if (output_grid.Rows[i].HeaderCell.Value.ToString() == controllers[i].ControllerName)
                {
                    for (int j = 0; j < output_grid.ColumnCount - 1; j++)
                    {
                        output_grid[j, i].Value = controllers[i].PropertyGroups[j].AdditiveEstimate;
                    }
                    output_grid[output_grid.ColumnCount - 1, i].Value = controllers[i].AdditiveEstimate;
                }
            }

            DrawAnswer();
        }

        private void DrawAnswer()
        {
            output_chart.Legends.Clear();

            var dataPointSeries = new Series();

            double parts = 1;
            for (int i = 0; i < controllers.Count; i++)
            {
                dataPointSeries.Points.AddXY(controllers[i].ControllerName, controllers[i].AdditiveEstimate);
                //dataPointSeries.AxisLabel = controllers[i].ControllerName;
                parts += 1;
            }

            output_chart.Series.Clear();
            output_chart.Series.Add(dataPointSeries);
            output_chart.AlignDataPointsByAxisLabel();

        }
    }
}
