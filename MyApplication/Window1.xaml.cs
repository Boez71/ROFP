using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFHelper;

namespace MyApplication
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            List<Employee> myList = new List<Employee> 
            {
                new Employee{ Name="Some 1"},
                new Employee{ Name="Some 2"},
                new Employee{ Name="Some 3"},
                new Employee{ Name="Some 4"},
                new Employee{ Name="Some 5"}
            };
            cmbEmployeeNames.ItemsSource = myList;
        }

    }
}
