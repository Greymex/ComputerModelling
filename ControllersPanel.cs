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
using System.IO;

namespace Estimator_v2._1
{
    public partial class ControllersPanel : UserControl
    {
        // Свойство, хранящее отображаемый объект модели данных
        public List<Controller> Controllers { get; private set; }
        public object SelectedItem { get; private set; }
        public Controller SelectedController { get; private set; }

        //Конструктор
        public ControllersPanel()
        {
            InitializeComponent();
            Controllers = new List<Controller>();
        }
        

        //Добавление контроллера
        public void AddController()
        {
            Controller controller = new Controller(controller_name.Text);
            Controllers.Add(controller);
            SelectedController = controller;
            //BuildControllersViewItems();
            //controllers_view.SelectedNode = controllers_view.Nodes.Find(controller.ControllerName, false)[0];
            controller_name.Text = "";
        }

        //Загрузка контроллера
        public Controller LoadController()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Controllers" + @"\";
            fileDialog.Filter = "Все файлы (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Controller loaded_controller = Controller.Load(Path.GetFileNameWithoutExtension(fileDialog.FileName));
                if (loaded_controller != null)
                {
                    foreach (var controller in Controllers)
                    {
                        if (controller.ControllerName == loaded_controller.ControllerName)
                        {
                            MessageBox.Show("Такой контроллер уже существует!");
                            return null;
                        }
                    }
                    Controllers.Add(loaded_controller);
                    MessageBox.Show($"Контроллер {loaded_controller.ControllerName} загружен!");
                    return loaded_controller;
                }
                else
                {
                    MessageBox.Show("Произошла ошибка!");
                }
                
            }
            return null;
        }

        public void LoadControllersList()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Environment.CurrentDirectory + @"\Controllers" + @"\ControllersGroup" + @"\";
            fileDialog.Filter = "Все файлы (*.*)|*.*";
            fileDialog.RestoreDirectory = true;
            List<Controller> loaded_list = null;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                loaded_list = ControllerGroupSaver.Load(Path.GetFullPath(fileDialog.FileName));
                
            }

            foreach (var item in loaded_list)
            {
                if (Controllers.Contains(Controllers.Find(x => x.ControllerName == item.ControllerName)))
                {
                    MessageBox.Show("Один или несколько из контроллеров загружаемого списка уже содержатся в системе - контроллеры с одинаковыми именами не могут существовать!" +
                        " Для добавления группы рекомендуется очистить список контроллеров!");
                    return;
                }
            }

            if (loaded_list != null)
            {
                foreach (var item in loaded_list)
                {
                    Controllers.Add(item);
                }
                MessageBox.Show($"Контроллеры успешно загружены!");
            }
            else MessageBox.Show("Произошла непредвиденная ошибка...");
        }

        public void ClearControllers()
        {
            if (Controllers.Count > 0)
            {
                Controllers.Clear();
                BuildControllersViewItems();
                MessageBox.Show("Список контроллеров очищен");
            }
            else MessageBox.Show("Список контроллеров не содержит ни одного экземпляра!");

        }


        //Построение treeview
        public void BuildControllersViewItems()
        {
            controllers_view.Nodes.Clear();

            foreach (var controller in Controllers)
            {
                TreeNode node = new TreeNode(controller.ControllerName);
                //node.Name = controller.ControllerName;
                controllers_view.SelectedNode = node;
                foreach (var group in controller.PropertyGroups)
                {
                    node.Nodes.Add(group.PropetyGroupName);
                    Font boldFont = new Font("Times New Roman", 12, FontStyle.Regular);
                    node.NodeFont = boldFont;
                }
                controllers_view.Nodes.Add(node);
            }
            controllers_view.ExpandAll();
            controllers_view.Focus();
            SelectedItem = Controllers.Find(x => x.ControllerName == controllers_view.SelectedNode.Text);
            SelectedController = SelectedItem as Controller;
        }

        //Проверка на правильность введенных данных
        public bool ValidateControllerControl()
        {
            //Если текстбокс пустой
            if (String.IsNullOrWhiteSpace(controller_name.Text))
            {
                MessageBox.Show("Введите корректное название контроллера!");
                return false;
            }
            //Если такой контроллер уже существует
            else
            {
                foreach (var controller in Controllers)
                {
                    if (controller.ControllerName.ToLower() == controller_name.Text.ToLower())
                    {
                        MessageBox.Show("Такой контроллер уже существует!");
                        return false;
                    }
                }
            }
            MessageBox.Show("Контроллер добавлен!");
            return true;
        }

        //Выбор контроллера или группы при клике по нему в представлении
        private void GetSelectedNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (Controllers.Contains(Controllers.Find(x => x.ControllerName == e.Node.Text)))
            {
                SelectedItem = Controllers.Find(x => x.ControllerName == e.Node.Text);
                SelectedController = SelectedItem as Controller;
                return;
            }

            foreach (var controller in Controllers)
            {
                if (e.Node.Parent.Text == controller.ControllerName)
                {
                    foreach (var property_group in controller.PropertyGroups)
                    {
                        if (controller.PropertyGroups.Contains(controller.PropertyGroups.Find(t => t.PropetyGroupName == e.Node.Text)))
                        {
                            SelectedItem = controller.PropertyGroups.Find(t => t.PropetyGroupName == e.Node.Text);
                            SelectedController = controller;
                            return;
                        }
                    }
                }
            }     
        }

        //Удаление выбранного элемента
        public void DeleteChosenItem()
        {
            if (SelectedItem is Controller)
            {
                Controllers.Remove(SelectedItem as Controller);
                MessageBox.Show($"Контроллер {(SelectedItem as Controller).ControllerName} был удален!");
            }
            else
            {
                foreach (var controller in Controllers)
                {
                    if (controller.PropertyGroups.Contains(SelectedItem as PropertyGroup))
                    {
                        controller.PropertyGroups.Remove(SelectedItem as PropertyGroup);
                        MessageBox.Show($"Группа {(SelectedItem as PropertyGroup).PropetyGroupName} была удалена!");
                    }
                }
            }

        }
    }
}
