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
using Estimator_v2._1;

namespace Estimator_v2
{
    public partial class GroupPanel : UserControl
    {
        // Свойство, хранящее отображаемый объект модели данных
        public List<PropertyGroup> PropertyGroups { get; private set; }
        object SelectedItem;

        //Конструктор
        public GroupPanel()
        {
            InitializeComponent();
            PropertyGroups = new List<PropertyGroup>();
        }

        //Занесение данных из PropertyGroup в контролы
        public void BuildGroupsComboBox()
        {
            group_names_cb.Items.Clear();
            foreach (var group in PropertyGroups)
                group_names_cb.Items.Add(group.PropetyGroupName);

            if (group_names_cb.Items.Count > 0)
                group_names_cb.SelectedIndex = 0;
            else group_names_cb.Text = "";
        }

        //Занесение данных из Properties в treeview
        public void BuildPropertiesViewItems()
        {
            properties_view.Nodes.Clear();

            foreach (var group in PropertyGroups)
            {
                TreeNode node = new TreeNode(group.PropetyGroupName);
                foreach (var property in group.Properties)
                {
                    node.Nodes.Add(property.Name);
                }
                Font boldFont = new Font("Times New Roman", 12, FontStyle.Regular);
                node.NodeFont = boldFont;
                properties_view.Nodes.Add(node);
            }
            properties_view.ExpandAll();
        }


        //Занесение данных из контролов в PropertyGroup
        public void AddGroups()
        {
            PropertyGroups.Add(new PropertyGroup(property_group_name.Text));
        }

        //Занесение групп при загрузке в PropertyGroup
        public void AddGroups(List<PropertyGroup> groups)
        {
            foreach (var group in groups)
            {
                if (!PropertyGroups.Contains(PropertyGroups.Find(x => x.PropetyGroupName == group.PropetyGroupName)))
                {
                    PropertyGroups.Add(group);
                    CheckProperties(group);
                }
            }
        }

        //Проверка свойств в группе на обратность и установка на передачу в контрол
        private void CheckProperties(PropertyGroup group)
        {
            foreach (var property in group.Properties)
            {
                if (property.Reversed)
                    property.Name += "*";
            }
        }

        //Добавление свойства
        public void AddProperty()
        {
            string name = property_name.Text;
            if (IsReversedProperty.Checked)
                name += "*";
            PropertyGroups
                .Find(x => x.PropetyGroupName == group_names_cb.SelectedItem.ToString())
                .AddProperty(new Property(name, 0, new List<int>(), IsReversedProperty.Checked));
        }

        //Добавление свойства при загрузке
        public void AddProperty(Property property)
        {
            string name = property.Name;
            PropertyGroups
                .Find(x => x.PropetyGroupName == group_names_cb.SelectedItem.ToString())
                .AddProperty(new Property(name, 0, new List<int>(), IsReversedProperty.Checked));
        }

        //Проверка на правильность введенных данных
        public bool ValidateGroupControl()
        {
            //Если текстбокс пустой
            if (String.IsNullOrWhiteSpace(property_group_name.Text))
            {
                MessageBox.Show("Введите корректное название группы!");
                return false;
            }
            //Если такая группа уже существует
            else
            {
                foreach (var group in PropertyGroups)
                {
                    if (group.PropetyGroupName == property_group_name.Text)
                    {
                        MessageBox.Show("Такая группа уже существует!");
                        return false;
                    }
                }
            }
            MessageBox.Show("Группа добавлена!");
            return true;
        }

        //Проверка на правильность введенных данных
        public bool ValidatePropertyControl()
        {
            //Если текстбокс пустой
            if (String.IsNullOrWhiteSpace(property_name.Text))
            {
                MessageBox.Show("Введите корректное название свойства!");
                return false;
            }
            //Если такое свойство уже существует
            else
            {
                foreach (var group in PropertyGroups)
                {
                    foreach (var property in group.Properties)
                    {
                        if (property.Name == property_name.Text)
                        {
                            MessageBox.Show("Такое свойство уже существует!");
                            return false;
                        }
                    }
                    
                }
            }
            MessageBox.Show("Свойство добавлено!");
            return true;
        }

        //Выбор свойтсва или группы при клике по нему в представлении
        private void SelectItemFromTree(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (PropertyGroups.Contains(PropertyGroups.Find(x => x.PropetyGroupName == e.Node.Text)))
            {
                SelectedItem = PropertyGroups.Find(x => x.PropetyGroupName == e.Node.Text);
                return;
            }

            foreach (var group in PropertyGroups)
            {
                if (group.Properties.Contains(group.Properties.Find(t => t.Name == e.Node.Text)))
                {
                    SelectedItem = group.Properties.Find(t => t.Name == e.Node.Text);
                    return;
                }
            }
        }

        //Удаление выбранного элемента
        public void DeleteChosenItem()
        {
            if (SelectedItem is PropertyGroup)
            {
                PropertyGroups.Remove(SelectedItem as PropertyGroup);
                MessageBox.Show($"Группа свойств {(SelectedItem as PropertyGroup).PropetyGroupName} была удалена!");
            }
            else
            {
                foreach (var group in PropertyGroups)
                {
                    if (group.Properties.Contains(SelectedItem as Property))
                    {
                        group.Properties.Remove(SelectedItem as Property);
                        MessageBox.Show($"Свойство {(SelectedItem as Property).Name} было удалено!");
                    }
                }
            }

        }
    }
}
