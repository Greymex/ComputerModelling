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
    public partial class ControllerWindow : Form
    {
        public ControllerWindow()
        {
            InitializeComponent();
            UpdateProperties();
        }

        List<PropertyGroup> groups = new List<PropertyGroup>();

        private void UpdateProperties()
        {
            properties_groups_cb.Items.Clear();
            foreach (var property_group in StartWindow.propertyGroups)
            {
                properties_groups_cb.Items.Add(property_group.PropetyGroupName);
            }
            //properties_groups_cb.SelectedItem.ToString();
        }

        private void add_value_Click(object sender, EventArgs e)
        {
            PropertyWindow propertyWindow = null;

            foreach (var property_group in StartWindow.propertyGroups)
            {
                if (property_group.PropetyGroupName == properties_groups_cb.SelectedItem.ToString())
                {
                    propertyWindow = new PropertyWindow(property_group, controller_name.Text);
                    propertyWindow.BuildWindow(property_group, int.Parse(experts_count.Value.ToString()), controller_name.Text);
                }
            }
            propertyWindow.ShowDialog();
            groups.Add(propertyWindow.filled_group);
        }

        private void add_controller_btn_Click(object sender, EventArgs e)
        {
            StartWindow.controllers.Add(new Controller(controller_name.Text, groups));
            groups = new List<PropertyGroup>();

            MessageBox.Show(
                    "Контроллер добавлен",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
