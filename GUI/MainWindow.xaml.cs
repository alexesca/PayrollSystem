using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using DataTable = System.Data.DataTable;
//To get it you need to og to Manage Nutget.
//Download the Excel Data Reader.
using Excel;
using System.IO;
using System.Windows.Forms;
using PayrollSystem;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //   Form1 form1 = new Form1();
            //  form1.Show();

        }

        DataSet tableset;

       // DataTable employeeTable;
       //Create a List of Datatables
       List<List< DataTable>> tableLits= new List<List<DataTable>>();
        List<DataRow> employeesInfo = new List<DataRow>();
        List<DataRow> hourlyEmployee = new List<DataRow>();
        List<DataRow> salaryEmployee = new List<DataRow>();
        List<DataRow> commisionEmployee = new List<DataRow>();
        List<Employee> employeeList = new List<Employee>();
        
        
        private void MenuItemLoad_Click(object sender, RoutedEventArgs e)
        {
            //Enable the buttons
            buttonDelete.IsEnabled = true;
            buttonUpdate.IsEnabled = true;
            buttonAdd.IsEnabled = true;
            buttonPayAll.IsEnabled = true;
            comboBoxType.IsEnabled = true;

            OpenFileDialog fileExcel = new OpenFileDialog();
            string path = fileExcel.FileName;
            textBoxPath.Text = path;

            if (fileExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //This code only work with *xls (Excel 2003-2007) NOt receint excel.
                //The docuement has 4 sheets
                FileStream fs = File.Open(fileExcel.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);

                reader.IsFirstRowAsColumnNames = true;
                tableset = reader.AsDataSet();
                comboBoxType.Items.Clear();
                int i = 0;
                
                foreach (DataTable dt in tableset.Tables)
                {
                    tableLits.Add(new List<DataTable> {dt});
                    comboBoxType.Items.Add(dt.TableName);
                    //if ( i == 0)
                    //{
                    //    employeesInfo = dt.AsEnumerable().ToList();
                    //}else if( i == 1)
                    //{
                    //    hourlyEmployee = dt.AsEnumerable().ToList();
                    //} else if ( i == 2 )
                    //{
                    //    salaryEmployee = dt.AsEnumerable().ToList();
                    //}else if ( i == 3)
                    //{
                    //    commisionEmployee = dt.AsEnumerable().ToList();
                    //}
                    //i++;
                }




                reader.Close();
                //Add a reference to the class PayRollSystem
                // tableList has all the data.We just need to save as employee.
                PayrollSystem.RaedFile.read_File(path, tableLits);

                dataGridEmployee.ItemsSource = tableset.Tables["Employees"].DefaultView;
            }
            CreateEmployeeObjects employeeGenerator = new CreateEmployeeObjects(tableset);
            employeeList = employeeGenerator.convertTableToEmployee();
        }

        private void comboBoxType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //You select the sheet you want to see adn show int he table
            dataGridType.ItemsSource = tableset.Tables[comboBoxType.SelectedIndex].DefaultView;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(tableLits);
            //   Form1 form1 = new Form1();
            //  form1.Show();
            Add_Employee NewEmployee = new Add_Employee();
            NewEmployee.Show();
            
        }

        private void ShowTest_Click(object sender, RoutedEventArgs e)
        {
            for (int p = 0; p < employeeList.Count; p++)
            {
               
                textBoxShow.Text += employeeList[p].EmployeeID + "\t";
                textBoxShow.Text += employeeList[p].EmployeeFName + "\t";
                textBoxShow.Text += employeeList[p].EmployeeLName + "\t";
                textBoxShow.Text += employeeList[p].EmployeeAddress + "\t";
                textBoxShow.Text += employeeList[p].EmployeePaymethod + "\t";
                textBoxShow.Text += employeeList[p].EmployeeType + "\t";

                textBoxShow.Text += "\n\n";

            }
        
        }
    }
}

