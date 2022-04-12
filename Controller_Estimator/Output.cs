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

namespace Controller_Estimator
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        public void BuildGrid(int Group_count)
        {
            for (int i = 0; i < Group_count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();
                column.HeaderText = $"K_{StartWindow.propertyGroups[i].PropetyGroupName}";
                //column.Name = $"expert{i + 1}";
                column.Width = 100;
                column.CellTemplate = new DataGridViewTextBoxCell();
                output_grid.Columns.Add(column);
            }

            DataGridViewColumn last_column = new DataGridViewColumn();
            last_column.HeaderText = $"K_общ";
            last_column.Width = 100;
            last_column.CellTemplate = new DataGridViewTextBoxCell();
            output_grid.Columns.Add(last_column);

            StartWindow.controllers.Sort((x, y) => x.AdditiveEstimate.CompareTo(y.AdditiveEstimate));
            StartWindow.controllers.Reverse();

            AddRowsNames();
        }

        private void AddRowsNames()
        {
            output_grid.Rows.Add(StartWindow.controllers.Count);
            output_grid.RowHeadersWidth = 100;
            for (int i = 0; i < StartWindow.controllers.Count; i++)
            {
                output_grid.Rows[i].HeaderCell.Value = StartWindow.controllers[i].ControllerName;
            }


        }

        public void GetAnswer()
        {
            best_lb.Text = StartWindow.controllers[0].ControllerName;

            for (int i = 0; i < output_grid.RowCount - 1; i++)
            {
                if (output_grid.Rows[i].HeaderCell.Value.ToString() == StartWindow.controllers[i].ControllerName)
                {
                    for (int j = 0; j < output_grid.ColumnCount - 1; j++)
                    {
                        output_grid[j, i].Value = StartWindow.controllers[i].PropertyGroups[j].AdditiveEstimate;
                    }
                    output_grid[output_grid.ColumnCount - 1, i].Value = StartWindow.controllers[i].AdditiveEstimate;
                }
            }

            DrawAnswer();
        }

        private void DrawAnswer()
        {
            output_chart.Legends.Clear();
            //output_chart.ChartAreas[0].AxisY.Interval = 0.5;
            //output_chart.ChartAreas[0].AxisX.Interval = 1;
            //output_chart.ChartAreas[0].AxisY2.Enabled = AxisEnabled.False;

            var dataPointSeries = new Series();

            double parts = 1;
            for (int i = 0; i < StartWindow.controllers.Count; i++)
            {
                dataPointSeries.Points.AddXY(parts, StartWindow.controllers[i].AdditiveEstimate);
                parts += 1;
            }

            output_chart.Series.Clear();
            output_chart.Series.Add(dataPointSeries);

        }
        
    }
}
