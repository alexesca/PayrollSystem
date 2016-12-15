using PayrollSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PayrollSystem;

namespace GUI
{
    /// <summary>
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        string firstName = "Alex";
        string lastName = "Escamore";
        string address = "MDSJD SLK";
        string type = "hourly";
        bool union = true;
        string paymentMethod = "cash";
        double typeRate = 0.0;
        CreateEmployeeObjects CEO = new CreateEmployeeObjects();

        public Add_Employee()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           // Message.Content = tableLits[0];
            //Environment.Exit(0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            Employee newEmployee = new Employee();

            newEmployee.EmployeeID = label_ID_Generated.Content.ToString();
            newEmployee.EmployeeFName = textBox_FirstName.Text;
            newEmployee.EmployeeLName = textBox_LastName.Text;
            newEmployee.EmployeePaymethod = Combox_MethopOptions.SelectedItem.ToString();
            newEmployee.EmployeeAddress = textBox_Address.Text;
            newEmployee.EmployeeType = comboBox_Type.SelectedItem.ToString();

            type = Combox_MethopOptions.SelectedItem.ToString();

            if (type == "Hourly")
            {
                

                CEO.completeHourly(newEmployee, type, newEmployee.EmployeeID);
            }
            else if (type == "Salary")
            {
                CEO.completeSalary(newEmployee, type, newEmployee.EmployeeID);
            }
            else if (type == "Commission")
            {
                CEO.completeComission(newEmployee, type, newEmployee.EmployeeID);
            }

        }

        private void Button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        List<string> list = new List<string> { "Salary", "Hourly", "Comission" };

        private void comboBox_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboBox_Type.Items.Add(list);
            string choose_Type = comboBox_Type.SelectedItem.ToString();
          
        }
        List<string> list2 = new List<string> { "Email", "Check", "Direct deposit" };

        private void Combox_MethopOptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            Combox_MethopOptions.Items.Add("Email");
            string choose_Type = comboBox_Type.SelectedItem.ToString();
        }
    }
}
