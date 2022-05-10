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
            AddStandartGroups();
            BuildPropertiesViewItems();
            BuildGroupsComboBox();
        }

        //Стандартные группы
        public void AddStandartGroups()
        {
            Property property = new Property("Время выполнения операции", 0, new List<int>(), true);
            Property property1 = new Property("Функциональность", 0, new List<int>(), false);
            Property property2 = new Property("Наработка на отказ", 0, new List<int>(), false);
            Property property3 = new Property("Среднее время восстановления", 0, new List<int>(), true);
            Property property4 = new Property("Стоимость оборудования", 0, new List<int>(), true);
            Property property5 = new Property("Стоимость монтажа", 0, new List<int>(), true);
            Property property6 = new Property("Потребляемая мощность", 0, new List<int>(), true);
            Property property7 = new Property("Гарантийный срок", 0, new List<int>(), false);
            Property property8 = new Property("Масса", 0, new List<int>(), true);
            //группы свойств контроллера 1

            PropertyGroup propertyGroup1 = new PropertyGroup("Производительность");
            PropertyGroup propertyGroup2 = new PropertyGroup("Надёжность");
            PropertyGroup propertyGroup3 = new PropertyGroup("Затраты");

            propertyGroup1.AddProperty(property);
            propertyGroup1.AddProperty(property1);
            propertyGroup2.AddProperty(property2);
            propertyGroup2.AddProperty(property3);
            propertyGroup3.AddProperty(property4);
            propertyGroup3.AddProperty(property5);
            propertyGroup3.AddProperty(property6);
            propertyGroup3.AddProperty(property7);
            propertyGroup3.AddProperty(property8);

            PropertyGroups.Add(propertyGroup1);
            PropertyGroups.Add(propertyGroup2);
            PropertyGroups.Add(propertyGroup3);
        }

        public void ClearAllGroups()
        {
            PropertyGroups.Clear();
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
                    if (!property.Reversed)
                        node.Nodes.Add(property.Name + "*");
                    else node.Nodes.Add(property.Name);
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
            property_group_name.Text = "";
        }

        //Занесение групп при загрузке в PropertyGroup
        public void AddGroups(List<PropertyGroup> groups)
        {
            foreach (var group in groups)
            {
                if (!PropertyGroups.Contains(PropertyGroups.Find(x => x.PropetyGroupName == group.PropetyGroupName)))
                {
                    PropertyGroups.Add(group);
                    //CheckProperties(group);
                }
                else
                {
                    PropertyGroups.Remove(PropertyGroups.Find(x => x.PropetyGroupName == group.PropetyGroupName));
                    PropertyGroups.Add(group);
                }
            }
        }

        //Добавление свойства
        public void AddProperty()
        {
            string name = property_name.Text;
            property_name.Text = "";
            //if (IsReversedProperty.Checked)
            //    name += "*";
            PropertyGroups
                .Find(x => x.PropetyGroupName == group_names_cb.SelectedItem.ToString())
                .AddProperty(new Property(name, 0, new List<int>(), !IsReversedProperty.Checked));
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
                    if (group.PropetyGroupName.ToLower() == property_group_name.Text.ToLower())
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
                        if (property.Name.ToLower() == property_name.Text.ToLower())
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
            string node_name = e.Node.Text.Replace("*", "");
            if (PropertyGroups.Contains(PropertyGroups.Find(x => x.PropetyGroupName == node_name)))
            {
                SelectedItem = PropertyGroups.Find(x => x.PropetyGroupName == node_name);
                return;
            }

            foreach (var group in PropertyGroups)
            {
                if (group.Properties.Contains(group.Properties.Find(t => t.Name == node_name)))
                {
                    SelectedItem = group.Properties.Find(t => t.Name == node_name);
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
