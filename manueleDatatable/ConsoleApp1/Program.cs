using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Program
    {
        
        public enum Alocatie { Brussel, Brugge };
        static void Main(string[] args)
        {
            Alocatie temp = Alocatie.Brugge;

            Console.WriteLine(temp.ToString());
            


        //string input = Microsoft.VisualBasic.Interaction.InputBox("Prompt", "Title", "Default", -1, -1);



        /*
        KANTOORCODE	NUMMER	NAAM	CREATIEDATUM	STREEFDATUM	TAAKTYPE	AANVULLENDE_INFO	EIGENAAR	TAAL	TAAKGROEP
        102	75100143714	BHUJEL Tirtha	25/01/2019	30/01/2019	Sociale kennisgeving: schuldvraag ontvangen	75100143714	svmngov	nl	Sociaal statuut

        */
        // Create new DataTable and DataSource objects.
        DataTable table = new DataTable();

            // Declare DataColumn and DataRow variables.
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType, ColumnName and add to DataTable. 
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "KANTOORCODE";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NUMMER";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "NAAM";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "CREATIEDATUM";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "STREEFDATUM";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TAAKTYPE";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "AANVULLENDE_INFO";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "EIGENAAR";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TAAL";
            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "TAAKGROEP";
            table.Columns.Add(column);









            // Create new DataRow objects and add to DataTable.    

            row = table.Rows.Add("102", "75100143714", "BHUJEL Tirtha", "25/01/2019", "30/01/2019", "Socialekennisgeving:schuldvraagontvangen", "75100143714", "svmngov", "nl", "Sociaal statuut");

            //table.Rows.Add(row);

            foreach (DataRow item in table.Rows)
            {
                Console.WriteLine(string.Join(" - ", item.ItemArray));
            }

            Console.WriteLine(string.Join(" - ", row.ItemArray));

            Console.ReadKey();
            
        }
    }
}










