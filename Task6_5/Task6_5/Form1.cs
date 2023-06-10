using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6_5
{
    public partial class Form1 : Form
    {
        private List<Type> player = new List<Type>();
        private List<string> methods = new List<string>();

        Type currType;
        object instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateclassComboBox()
        {
            this.classComboBox.Items.Clear();

            foreach (Type t in player)
            {
                this.classComboBox.Items.Add(t.Name);
            }
        }

        private void UpdatemethodComboBox()
        {
            this.methodComboBox.Items.Clear();

            foreach (string methodName in methods)
            {
                this.methodComboBox.Items.Add(methodName);
            }
        }

        private void OpenLibrary(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DLL files (*.dll)|*.dll";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Assembly assembly = Assembly.LoadFrom(openFileDialog.SafeFileName);
                var types = assembly.GetTypes();
                foreach (Type type in types)
                {
                    if (!type.IsInterface && !type.IsAbstract)
                    {
                        player.Add(type);
                    }
                }
            }

            UpdateclassComboBox();

            this.classComboBox.Visible = true;
            this.smartButton.Visible = true;
        }

        private void smartButton_Click(object sender, EventArgs e)
        {
            var val = this.classComboBox.Text;

            if (val != "")
            {
                var type = player.Find((t) => t.Name == val);

                currType = type;

                this.methods.Clear();

                foreach (var method in type.GetMethods())
                {
                    this.methods.Add(method.Name);
                }

                this.instance = Activator.CreateInstance(this.currType);

                this.methodComboBox.Items.Clear();
                this.methodComboBox.Visible = true;
                this.methodButton.Visible = true;

                UpdatemethodComboBox();
            }
            else
            {
                MessageBox.Show("Класс не выбран!");
            }
        }

        private void methodButton_Click(object sender, EventArgs e)
        {

            string methodName = this.methodComboBox.Text;

            if (methodName != "")
            {
                var methodInfo = currType.GetMethod(methodName);

                if (methodInfo == null)
                {
                    Console.WriteLine($"Метод {methodName} не найден.");
                    return;
                }

                createForm(methodInfo, methodName);
            }
            else
            {
                MessageBox.Show("Метод не выбран!");
            }

        }

        private void createForm(MethodInfo methodInfo, string methodName)
        {
            var form = new Form();
            form.Text = methodName;


            //рекурсия для разбора параметров (если параметр не примитивен)


            var parameters = methodInfo.GetParameters();

            var y = 10;
            foreach (var parameter in parameters)
            {

                var label = new Label();
                //value изменить на название параметром:
                label.Text = parameter.Name + ":";
                label.Left = 10;
                label.Top = y;
                form.Controls.Add(label);

                var textBox = new TextBox();
                textBox.Left = 110;
                textBox.Top = y;
                form.Controls.Add(textBox);

                y += 30;
            }


            var button = new Button();
            button.Text = "Выполнить";
            button.Left = 110;
            button.Top = y;
            button.Click += (sender, e) =>
            {
                var args = new object[parameters.Length];
                for (int i = 0; i < parameters.Length; i++)
                {
                    args[i] = Convert.ChangeType(form.Controls[i * 2 + 1].Text, parameters[i].ParameterType);
                }

                try
                {

                    object curInstance = null;

                    if (!methodInfo.IsStatic)
                    {
                        curInstance = this.instance;
                    }

                    if (methodInfo.ReturnType.ToString() == "System.Void")
                    {
                        methodInfo.Invoke(curInstance, args);
                        MessageBox.Show("Выполнено!");
                    }
                    else
                    {
                        var vap = methodInfo.Invoke(curInstance, args);
                        if (vap != null)
                        {
                            MessageBox.Show(vap.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Поле ещё не создано!");
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("ОШИБКА!");
                }
            };

            form.Controls.Add(button);

            form.ShowDialog();
        }
    }
}

