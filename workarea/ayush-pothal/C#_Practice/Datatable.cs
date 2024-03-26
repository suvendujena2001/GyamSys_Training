using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a DataSet
            DataSet dataSet= new DataSet("EmployeeDataSet");

            // Create DataTables
            DataTable dataTable1 = new DataTable("EmployeeTable");
            DataTable dataTable2 = new DataTable("DepartmentTable");


            // Add columns to the DataTable1
            dataTable1.Columns.Add("Id", typeof(int));
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("Age", typeof(int));

            // Add columns to the DataTable2
            dataTable2.Columns.Add("DeptId", typeof(int));
            dataTable2.Columns.Add("DeptName", typeof(string));

            // Add rows to the DataTable1
            dataTable1.Rows.Add(1, "Ayush Pothal", 22);
            dataTable1.Rows.Add(2, "Swagat Sahu", 21);
            dataTable1.Rows.Add(3, "Suvam Panda", 25);

            // Add rows to the DataTable2
            dataTable2.Rows.Add(1, "Microsoft");
            dataTable2.Rows.Add(2, "SAP");
            dataTable2.Rows.Add(3, "Salesforce");

            // Add the DataTables to the DataSet
            dataSet.Tables.Add(dataTable1);
            dataSet.Tables.Add(dataTable2);


            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine("Table Name: " + table.TableName);

                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        Console.Write(column.ColumnName + ": " + row[column] + " ");
                    }
                    Console.WriteLine(); 
                }
                Console.WriteLine(); 
            }
        }
    }
}
