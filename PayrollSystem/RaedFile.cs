using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{//This is a Read File. Taken form Alex's code form Lab04.
    //This class is not finish yet .It is close xD
    public class RaedFile
    {
        public static List<Employee> read_File(String file,List<List<DataTable>> table1)
        {

            List<Employee> list = new List<Employee>();
            
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    // Read until we reach the end of the file.
                    string str = "";
                    int line = 1;
                    do
                    {
                        //Reads a line
                        str = reader.ReadLine();

                        //Getting headers
                        if (line == 1)
                        {
                            getHeaders(table1[0][0], str);
                        }
                        else
                        {
                            //Adding students to the list
                            addEmployeeToTable(table1[0][0], str);
                        }
                        line++;
                    }
                    //Conditional
                    while (!reader.EndOfStream);
                }
            }
            //Catches any exception
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception .", e);
            }
            return list;
        }

  
    public static void addEmployeeToTable(DataTable table1, String str)
    {
        //Declaring variables
        string ID = GetID(str);
        string Name = getName(str);
        
        List<String> information = getInformation(str);
        DataRow row = table1.NewRow();
        row[0]= ID;
        
        int index = 1;
        //Adding rows
        foreach (string data in information)
        {
            row[index] = data;
            index++;
        }
        table1.Rows.Add(row);
    }
        public static void getHeaders(DataTable table1, String line)
        {
            //Declaring the headers
            String[] values = line.Split(',');
            table1.Columns.Add("ID");
            table1.Columns.Add("Name");
            table1.Columns.Add("Address");
            table1.Columns.Add("Pay Method");
            table1.Columns.Add("Type");
            table1.Columns.Add("Union");
        }
        public static String GetID(string str)
        {
            //Substringing the name
            int index = str.IndexOf(' ');
            string firstName = str.Substring(0, index);
            return firstName;
        }
        public static string getName(string str)
        {
            //Getting the last name
            int index = str.IndexOf(' ');
            string lastName = str.Substring(index + 1, (str.IndexOf(',') - index) - 1);
            return lastName;
        }
        public static List<String> getInformation(string str)
        {
            //Getting grades
            List<String> informationList = new List<String>();
            
            //Exploding the string/line
            informationList = str.Split(',').ToList<String>();
            informationList.RemoveAt(0);
            //Looping each grade
           
            return informationList;
        }

        // Split string by comma
        public static List<String> splitStringLine(String line)
        {
            //Declarin variables
            List<String> data = new List<String>();
            String tempString = "";
            //Iterates the line
            foreach (char character in line)
            {
                if (character.CompareTo(',') == 0)
                {
                    //Add them to the collection
                    data.Add(tempString);
                    tempString = "";
                }
                else
                {
                    //Builds the new string
                    tempString += character;
                }
            }
            //Returning the final value.
            return data;
        }
    }
}

