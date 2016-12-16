using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using DataTable = System.Data.DataTable;
//To get it you need to og to Manage Nutget.
//Download the Excel Data Reader.
using Excel ;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using Microsoft.Office.Interop.Excel;
using PayrollSystem;
using SaveFileDialog = Microsoft.Win32.SaveFileDialog;
using Window = System.Windows.Window;

namespace GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Excel
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
        GenerateTable generator = new GenerateTable();
        DataTable dt = new DataTable();

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

            if (fileExcel.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //This code only work with *xls (Excel 2003-2007) NOt receint excel.
                //The docuement has 4 sheets
                FileStream fs = File.Open(fileExcel.FileName, FileMode.Open, FileAccess.Read);
                IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);

                reader.IsFirstRowAsColumnNames = true;
                tableset = reader.AsDataSet();
                comboBoxType.Items.Clear();
                //int i = 0;
                
                foreach (DataTable dt in tableset.Tables)
                {
                    tableLits.Add(new List<DataTable> {dt});
                    comboBoxType.Items.Add(dt.TableName);
                    
                }

                reader.Close();
                //Add a reference to the class PayRollSystem
                // tableList has all the data.We just need to save as employee.
                PayrollSystem.RaedFile.read_File(path, tableLits);

                dataGridEmployee.ItemsSource = tableset.Tables["Employees"].DefaultView;
            }
            // creating the employee generator to convert the table into objects
            CreateEmployeeObjects employeeGenerator = new CreateEmployeeObjects(tableset);

            // convert the table into employee object
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
            /*
            //Console.WriteLine(tableLits);
            //   Form1 form1 = new Form1();
            //  form1.Show();
            Add_Employee NewEmployee = new Add_Employee();
            NewEmployee.Show();
            */
        }

        private void ShowTest_Click(object sender, RoutedEventArgs e)
        {
            showBalanceEmplo();
            
            if(returnEmployeeForeceipt().Count > 0)
            {
                buttonPayAll.IsEnabled  = true;
                genarateList.IsEnabled  = false;
            }


        }

        private void showBalanceEmplo()
        {
            
            dt = generator.toDataTable(employeeList);
            payRollTable.ItemsSource = dt.AsDataView();
        }

        private void dataGridEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGridEmployee_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            System.Windows.MessageBox.Show(dataGridEmployee.SelectedIndex.ToString());
            dataGridEmployee.SelectedCells.Remove(e);
            
        }

        private void buttonPayAll_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> paidEmployee = returnEmployeeForeceipt();
            foreach (Employee employee in employeeList)
            {
                employee.EmployeeBalance = 0;
            }

            buttonPayAll.IsEnabled = false;
            genarateList.IsEnabled = true;
            showBalanceEmplo();
            SaveFileDialog FilePathSave = new SaveFileDialog();

            PayrollSystem.SaveFile.OnExportGridToCSV(dt,FilePathSave.FileName);
            //SaveFile.OnExportGridToCSV(dt, FilePathSave.FileName ); 

        }

        private List<Employee> returnEmployeeForeceipt()
        {
            List<Employee> employeeBalance = new List<Employee>();
            foreach (Employee t in employeeList)
            {
                if (t.EmployeeBalance > 0)
                {
                    employeeBalance.Add(t);
                }
            }

            return employeeBalance;
        }

        
        private void getTheTable()
        {

        }
    }
}

