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
            EmployeeFactory employeefactory = new EmployeeFactory();
            Employee temp_Employee = employeefactory.getEmployee(type);
            temp_Employee.EmployeeFName = firstName + "" + lastName;
            temp_Employee.EmployeePaymethod = paymentMethod;
            temp_Employee.EmployeeType = type;
            temp_Employee.EmployeeUnion = union;
            temp_Employee.EmployeeTypeRate = typeRate; 

        }
    }
}
