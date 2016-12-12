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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataTable = System.Data.DataTable;
//To get it you need to og to Manage Nutget.
//Download the Excel Data Reader.
using Excel;
using System.IO;
using System.Windows.Forms;

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

            //   Form1 form1 = new Form1();
            //  form1.Show();
            Add_Employee NewEmployee = new Add_Employee();
            NewEmployee.Show();
            
        }
    }
}

