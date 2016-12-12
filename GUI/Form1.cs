using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using Excel;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable tableEmployees = new DataTable();
        DataSet result = new DataSet();

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonUpdload.Show();
            buttonDelete.Show();
            buttonAdd.Show();
            dataGridView1.Show();
            buttonPayment.Show();
            dataGridView2.Show();
            comboBox1.Show();

            OpenFileDialog fileExcel = new OpenFileDialog();
            if (fileExcel.ShowDialog() == DialogResult.OK)
            { 
            FileStream fs = File.Open(fileExcel.FileName, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
            
            reader.IsFirstRowAsColumnNames = true;
            result = reader.AsDataSet();
            comboBox1.Items.Clear();
            foreach (DataTable dt in result.Tables)
            {
                comboBox1.Items.Add(dt.TableName);
            }
            reader.Close();
            }
        }
            
            // dataGridView1.DataSource = result.Tables["Data"].DefaultView;
       
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = result.Tables[comboBox1.SelectedIndex];
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        /*
               FileStream fs = File.Open(FileExcel.FileName, FileMode.Open, FileAccess.Read);
               IExcelDataReader reader = ExcelReaderFactory.CreateBinaryReader(fs);
               reader.IsFirstRowAsColumnNames = true;
               result = reader.AsDataSet();
               comboBox1.Items.Clear();
               foreach (DataTable dt in result.Tables)
               {
                   comboBox1.Items.Add(dt.TableName);
               }
               reader.Close();  */
        /*
       DataTable dtexcel = new DataTable();
       bool hasHeaders = false;
       string HDR = hasHeaders ? "Yes" : "No";
       string strConn;
       if (true)
           strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=" + HDR + ";IMEX=0\"";
       else
           strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties=\"Excel 8.0;HDR=" + HDR + ";IMEX=0\"";
       OleDbConnection conn = new OleDbConnection(strConn);

       DataTable schemaTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] {null,null,null,null});
       //Looping Total Sheet of Xl File
       /*foreach (DataRow schemaRow in schemaTable.Rows)
       {
       }*/
        //Looping a first Sheet of Xl File
        /*
        DataRow schemaRow = schemaTable.Rows[0];
        string sheet = schemaRow["TABLE_NAME"].ToString();
        if (!sheet.EndsWith("_"))
        {
            string query = "SELECT  * FROM [" + sheet + "]";
            OleDbDataAdapter daexcel = new OleDbDataAdapter(query, conn);
            dtexcel.Locale = CultureInfo.CurrentCulture;
            daexcel.Fill(dtexcel);
        }

        conn.Close();
        */
    }
}
