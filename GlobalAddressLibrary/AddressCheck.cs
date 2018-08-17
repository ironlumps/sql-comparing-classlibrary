using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace GlobalAddressLibrary
{
    public class AddressCheck
    {
        // The CheckOptions method looks through the options of disabling the specific result codes and creates the query based upon that recommendation
        // All of the strings and booleans correspond to a windows form this as desgned for
        public string CheckOptions(string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            string table = tableName;
            string query = "";
            string[] countryList = countryCodes.Split(new char[] { ',', '|' });
            // The for loop iterates through the country codes to create a query for every country
            for (int x = 0; x <= countryList.Length - 1; x++)
            {
                // For all of the if statements, if the checked boolean is false (check box is not checked) the query adds to the query
                // for the check boxes it's based upon whether or not specific result codes are to be displayed
                if (checkAC == false)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC01' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC01%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC02' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC02%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC03' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC03%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC09' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC09%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC10' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC10%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC11' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC11%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC12' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC12%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC13' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC13%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC14' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC14%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC15' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC15%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC16' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC16%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC17' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC17%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC18' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC18%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC19' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC19%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC20' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC20%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AC22' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AC20%' and countrycode='" + countryList[x] + "' union\r\n";
                }
                if (checkAE == false)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE01' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE01%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE02' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE02%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE03' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE03%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE05' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE05%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE08' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE08%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE09' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE09%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE10' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE10%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE11' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE11%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE12' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE12%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE13' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE13%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE14' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE14%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AE17' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AE17%' and countrycode='" + countryList[x] + "' union\r\n";
                }
                if (checkAV == false)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV25' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV25%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV24' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV24%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV23' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV23%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV22' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV22%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV21' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV21%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV15' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV15%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV14' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV14%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV13' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV13%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV12' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV12%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'AV11' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%AV11%' and countrycode='" + countryList[x] + "' union\r\n";
                }
                if (checkGE == false)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GE01' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GE01%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GE02' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GE02%' and countrycode='" + countryList[x] + "' union\r\n";
                }
                if (checkGS == false)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS01' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS01%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS02' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS02%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS03' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS03%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS04' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS04%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS05' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS05%' and countrycode='" + countryList[x] + "' union\r\n";
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], 'GS06' AS [MD_RESULTS], count(*) AS [COUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where MD_Results like '%GS06%' and countrycode='" + countryList[x] + "' union\r\n";
                }
                else
                {
                    continue;
                }
            }
            // This if statement remvoes the union command from the last command in the SQL query as to not cause a SQL error
            if (query.EndsWith(" union\r\n"))
            {
                query = query.Substring(0, query.LastIndexOf(" union\r\n"));
                query += "\r\n";
            }
            // Adds an organization command to make everything easier to read and keep a uniform parsing process for other methods
            query += "Order By [COUNTRYCODE], [MD_Results]";
            return query;
        }
        // The CheckIfExists method checks to see if the .txt file for the SQL query for the table that is requested and its corresponding count file
        // exists or not and if not, the method calls upon other methods to create the files.
        public int CheckIfExists(string path, string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            if (!File.Exists(CreateTextFileString(path, tableName)) &&
                !File.Exists(CreateCountFileString(path, tableName)))
            {
                // Since both the text files and count text files don't exist, it calls upon the methods to create them for future access
                CreateTextFiles(path, tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
                CreateTextTotal(path, tableName, countryCodes);
                return 1;
            }
            else if (File.Exists(CreateTextFileString(path, tableName)) &&
                !File.Exists(CreateCountFileString(path, tableName)))
            {
                // Since the count text does not exist, but the text file for the table does exist, this method then just creates the count text file
                CreateTextTotal(path, tableName, countryCodes);
                return 2;
            }
            else if (!File.Exists(CreateTextFileString(path, tableName)) &&
                File.Exists(CreateCountFileString(path, tableName)))
            {
                CreateTextFiles(path, tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS);
                return 3;
            }
            else if (File.Exists(CreateTextFileString(path, tableName)) &&
                File.Exists(CreateCountFileString(path, tableName)))
            {
                // Since both files exist the method just returns an integer that is not 0 so the other methods can continue.
                return 4;
            }
            else
            {
                return 0;
            }
        }
        // The CreateTextFiles method is used by the CheckIfExists method to call the query that is created by the CheckOptions methdod and run it through
        // the SQL server. It then takes that response and writes it to a .txt file for easier access in the future.
        public void CreateTextFiles(string path, string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            SqlConnection connect = new SqlConnection("SERVER=BROWN21;database=GlobalAddressCustomerDataResults;Integrated Security=SSPI;MultipleActiveResultSets = True");
            connect.Open();

            // The SQL command calls upon CheckOptions to create the query necessary to execute for the SQL database within connect. 
            SqlCommand getData = new SqlCommand(CheckOptions(tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS), connect);
            getData.CommandTimeout = 1000000000;
            SqlDataReader data = getData.ExecuteReader();

            // After executing the query, the query is then read from and copied into a .txt file that can be then read from rather then having to execute
            // the SQL query everytime it's run
            string table1 =CreateTextFileString(path, tableName);
            FileStream fs = new FileStream(table1, FileMode.Create);
            using (StreamWriter table1SW = new StreamWriter(fs))
            {
                table1SW.AutoFlush = true;

                while (data.Read())
                {
                    table1SW.WriteLine(String.Format("{0},{1},{2}", data["COUNTRYCODE"], data["MD_RESULTS"], data["COUNT"]));
                }


            }
        }
        // The CreateTextTotal method is used by the CheckIfExists method to call the query from TotalQuery that retrieves the total amount of records for a specific country
        // which is then written to a .txt file for easier access in teh future.
        public void CreateTextTotal(string path, string tableName, string countryCodes)
        {
            SqlConnection connect = new SqlConnection("SERVER=BROWN21;database=GlobalAddressCustomerDataResults;Integrated Security=SSPI;MultipleActiveResultSets = True");
            connect.Open();

            // The SQL command calls upon TotalQuery to create the query necessary to execute for the SQL database within connect. 
            SqlCommand firstTotal = new SqlCommand(TotalQuery(tableName, countryCodes), connect);
            firstTotal.CommandTimeout = 1000000000;
            SqlDataReader firstData = firstTotal.ExecuteReader();

            // After executing the query, the query is then read from and copied into a .txt file that can be then read from rather then having to execute
            // the SQL query everytime it's run
            string firstTable = CreateCountFileString(path, tableName);
            FileStream fs = new FileStream(firstTable, FileMode.Create);
            using (StreamWriter firstTableSW = new StreamWriter(fs))
            {
                firstTableSW.AutoFlush = true;

                while (firstData.Read())
                {
                    firstTableSW.WriteLine(String.Format("{0},{1}", firstData["COUNTRYCODE"], firstData["TOTALCOUNT"]));
                }
                firstTableSW.Flush();

            }
        }
        // The TotalQuery method creates a SQL query for the specified table name and country codes that gives the total amount of records for a specific country within
        // the record which can then be used to calculate significance of any change in result code count.
        public string TotalQuery(string table, string countryCodes)
        {
            string query = "";
            string tableName = table;
            string[] countryList = countryCodes.Split(new char[] { ',', '|' });

            for (int x = 0; x < countryList.Length; x++)
            {

                if (x == countryList.Length - 1)
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], count(*) AS [TOTALCOUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where countrycode='" + countryList[x] + "'\r\n";
                }
                else
                {
                    query += "SELECT '" + countryList[x] + "'AS [COUNTRYCODE], count(*) AS [TOTALCOUNT] FROM [GlobalAddressCustomerDataResults].[dbo].[" + tableName + "] where countrycode='" + countryList[x] + "' union\r\n";
                }
            }

            return query;
        }
        // The RunDataTableQuery uses the first 2 tables that you want to compare and stores the results into a datatable for easier access and organization
        public DataTable RunDataTableQuery(string path, string table1, string table2)
        {
            DataTable data = new DataTable();
            string file = CreateTextFileString(path, table1);
            FileStream firstFile = new FileStream(file, FileMode.Open);
            using (StreamReader read = new StreamReader(firstFile))
            {
                string otherFile = CreateTextFileString(path, table2);
                FileStream secondFile = new FileStream(otherFile, FileMode.Open);
                using (StreamReader reader = new StreamReader(secondFile))
                {
                    // Adds the columns below to the datatable that is necessary to read from it
                    data.Columns.Add("Country Code", typeof(string));
                    data.Columns.Add(table1, typeof(string));
                    data.Columns.Add("Count", typeof(string));
                    data.Columns.Add(table2, typeof(string));
                    data.Columns.Add("Counts", typeof(string));
                    string country = "";
                    string result = "";
                    string secondResult = "";
                    string count = "";
                    string secondCount = "";
                    string value = "";
                    string secondValue = "";
                    while ((value = read.ReadLine()) != null && (secondValue = reader.ReadLine()) != null)
                    {
                        // Splits the lines read from the .txt file that was created and split them based on (,) that is was created with
                        string[] array = value.Split(',');
                        string[] secondArray = secondValue.Split(',');
                        country = array[0];
                        result = array[1];
                        count = array[2];
                        secondResult = secondArray[1];
                        secondCount = secondArray[2];
                        // Adds a row to the datatable that contains each of the values that were read from both of the tables.
                        data.Rows.Add(country, result, count, secondResult, secondCount);
                    }
                }
            }
            return data;
        }
        // The RunMultipleQuery uses the previously created datatable and another tablename with country codes and CheckOptions to add information onto the datatable
        // that was made from the first 2 tables rather than starting another one.
        public DataTable RunMultipleQuery(DataTable data, string path, string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            if (CheckIfExists(path, tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS) != 0)
            {
                // Using a given table name, the StreamReader reads from the text file of the SQL query of that table
                string file = CreateTextFileString(path, tableName);
                FileStream firstFile = new FileStream(file, FileMode.Open);
                // Columns are created in the data table based upon the table name given as to avoid problems with column name conflicts
                System.Data.DataColumn resultColumn = new DataColumn(tableName, typeof(string));
                DataColumn countColumn = new DataColumn("Count of " + tableName, typeof(string));
                data.Columns.Add(resultColumn);
                data.Columns.Add(countColumn);
                string resultQuery = "";
                string countQuery = "";
                using (StreamReader read = new StreamReader(firstFile))
                {
                    string country = "";
                    string result = "";
                    string count = "";
                    string value = "";

                    while ((value = read.ReadLine()) != null)
                    {
                        // Splits each line of the text file based upon a (,)
                        string[] array = value.Split(',');
                        country = array[0];
                        result = array[1];
                        count = array[2];
                        // Adds the recently split variables into a string rather than the row to organize it better
                        resultQuery += result + ",";
                        countQuery += count + ",";

                    }
                    // Splits the string that are a combination of the variables from the line
                    resultQuery = resultQuery.TrimEnd(',');
                    countQuery = countQuery.TrimEnd(',');
                    string[] resultArray = resultQuery.Split(',');
                    string[] countArray = countQuery.Split(',');

                    // The foreach loops below each iterate through the datatable and add the values that were read from the new tablename.txt file that stored
                    // all of the SQL results and adds them to the corresponding column names
                    int i = 0;
                    foreach (DataRow row in data.Rows)
                    {
                        if (i < resultArray.Length)
                        {
                            row[tableName] = resultArray[i];
                            i++;
                        }

                    }

                    int j = 0;
                    foreach (DataRow row in data.Rows)
                    {
                        if (j < countArray.Length)
                        {
                            row["Count of " + tableName] = countArray[j];
                            j++;
                        }
                    }

                }
                return data;
            }
            else
            {
                return null;
            }

        }
        // The GetCountry method pulls the specifc country values from the Count.txt file in order to match up to the count wihtin a program easier
        public string GetCountry(string path, string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            if (CheckIfExists(path, tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS) != 0)
            {
                // The StreamReader reads from the count text file that is created from the CheckIfExists method
                StreamReader tableReader = new StreamReader(CreateCountFileString(path, tableName));
                string tableCountry = "";
                string table = "";
                string end = "";
                while ((table = tableReader.ReadLine()) != null)
                {
                    // Splits the lines of the text file and stores each element into its own variable then adds that to a string of all of the values
                    string[] tableArray = table.Split(',');
                    tableCountry = tableArray[0];
                    end += tableCountry + ',';
                }
                // Cuts of (,) of the end of the string to be used in other methods
                end.TrimEnd(',');
                return end;
            }
            else
            {
                return "NULL";
            }
        }
        // This method is the same as the other GetCountry method, but it does not check if the text file already exists, so it can only be used if it it's
        // known that the text file exists or if the file is created before this method is created.
        public string GetCountry(string path, string tableName)
        {
            StreamReader tableReader = new StreamReader(CreateCountFileString(path, tableName));
            string tableCountry = "";
            string table = "";
            string end = "";
            while ((table = tableReader.ReadLine()) != null)
            {
                string[] tableArray = table.Split(',');
                tableCountry = tableArray[0];
                end += tableCountry + ',';
            }
            end.TrimEnd(',');
            return end;
        }
        // THe GetTotal method pulls the specific count from the country values within the Count.txt file in order to match and check significances easier.
        public string GetTotal(string path, string tableName, string countryCodes, bool checkAC, bool checkAE, bool checkAV, bool checkGE, bool checkGS)
        {
            if (CheckIfExists(path, tableName, countryCodes, checkAC, checkAE, checkAV, checkGE, checkGS) != 0)
            {
                // The StreamReader reads from the text file of the specified table name that is taken as one of the arguments
                StreamReader tableReader = new StreamReader(CreateCountFileString(path, tableName));
                string tableTotal = "";
                string table = "";
                string end = "";
                while ((table = tableReader.ReadLine()) != null)
                {
                    // Splits the line of the text file and organizes the counts into variables that are then combined into a string
                    string[] table1Array = table.Split(',');
                    tableTotal = table1Array[1];
                    end += tableTotal + ",";
                }
                // The string of all of the varaiables is then returned with the ending (,) taken off
                end.TrimEnd(',');
                return end;
            }
            else
            {
                return "NULL";
            }
        }
        // This method is the same as the other GetTotal method, but it does not check if the text file already exists, so it can only be used if it it's
        // known that the text file exists or if the file is created before this method is created.
        public string GetTotal(string path, string tableName)
        {
            StreamReader tableReader = new StreamReader(CreateCountFileString(path, tableName));
            string tableTotal = "";
            string table = "";
            string end = "";
            while ((table = tableReader.ReadLine()) != null)
            {
                string[] table1Array = table.Split(',');
                tableTotal = table1Array[1];
                end += tableTotal + ",";
            }

            end.TrimEnd(',');
            return end;
        }
        // The Significance method is used to calculate the signficance of a change in number of result codes and it uses the total number of records for each 
        // country to calulate it
        public DataTable Significance(DataTable data, string path, double signif, string tableName)
        {
            DataTable storage = new DataTable();
            storage.Columns.Add("Country Codes", typeof(string));

            // Pulls the country codes and totals to be used to calculate the basis for significance
            string[] countries = GetCountry(path, tableName).Split(',');
            string[] totals = GetTotal(path, tableName).Split(',');

            // Iterates through the rows
            for (int i = 0; i < data.Rows.Count; i++)
            {
                // Iterates through each column in the row
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    // If the country in the row matches the country from the text file then it continues to calculate the significance
                    if (countries[j] == data.Rows[i][0].ToString())
                    {
                        int k = 4;
                        int l = 2;
                        if (k < data.Columns.Count)
                        {
                            // Compares two count columns from the database that was created and divides them by the total for the country the columns are pulled from
                            // to calculate if the significance falls within the range specified by the signif value that is an argument of the method
                            if ((double.Parse(data.Rows[i][l].ToString()) / double.Parse(totals[j])) - (double.Parse(data.Rows[i][k].ToString()) / double.Parse(totals[j]))
                                > (signif / 100) || ((double.Parse(data.Rows[i][k].ToString()) / double.Parse(totals[j])) - (double.Parse(data.Rows[i][l].ToString()) / double.Parse(totals[j]))
                                > (signif / 100)))
                            {
                                int m = 2;
                                DataColumnCollection columns = storage.Columns;
                                string country = data.Rows[i][0].ToString();
                                DataRow dr = storage.NewRow();
                                dr["Country Codes"] = country;
                                while (m < data.Columns.Count)
                                {
                                    // For every column that is significant, it creates a sister column with the same name in a new data table 
                                    // along with the sister column of the result codes for the count column that was significant
                                    if (!columns.Contains(data.Columns[m].ColumnName))
                                    {
                                        storage.Columns.Add(data.Columns[m - 1].ColumnName, typeof(string));
                                        storage.Columns.Add(data.Columns[m].ColumnName, typeof(string));

                                        // Adds each new column to a data row that will be later added to the new data table
                                        dr[data.Columns[m - 1].ColumnName] = data.Rows[i][m].ToString();
                                        dr[data.Columns[m].ColumnName] = data.Rows[i][m].ToString();

                                        m += 2;
                                    }
                                }

                                storage.Rows.Add(dr);

                            }
                            k += 2;
                            l += 2;
                        }
                    }
                }
            }
            // Returns a data table that contains all of the significant changes from the result data table
            return storage;
        }
        // The Error Bounds method is used to point out differences between counts in different tables that fall within the error bounds specified by 
        // the error value within the argument of the method
        public DataTable ErrorBounds(DataTable data, string path, double error, string tableName)
        {
            DataTable storage = new DataTable();
            storage.Columns.Add("Country Codes", typeof(string));

            // Pulls the countries and counts from the count text file of a table name from the argument in order to be pulled from to calculate error bounds
            string[] countries = GetCountry(path, tableName).Split(',');
            string[] totals = GetTotal(path, tableName).Split(',');

            // Iterates through each row of the data table
            for (int i = 0; i < data.Rows.Count; i++)
            {
                // Iterates throuh each column of each row in the data table
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    if (countries[0] == data.Rows[i][0].ToString())
                    {
                        int k = 2;
                        int l = 4;

                        if (l < data.Columns.Count)
                        {
                            // Divides on count column by another and checks to see if the result falls within the range of error and if so it moves on
                            if ((double.Parse(data.Rows[i][k].ToString()) / (double.Parse(data.Rows[i][l].ToString())) < (1.0 - (error / 100))) ||
                                (double.Parse(data.Rows[i][l].ToString()) / (double.Parse(data.Rows[i][k].ToString())) < (1.0 - (error / 100))))
                            {
                                int m = 2;
                                DataColumnCollection columns = storage.Columns;
                                string country = data.Rows[i][0].ToString();
                                DataRow dr = storage.NewRow();
                                dr["Country Codes"] = country;
                                while (m < data.Columns.Count)
                                {
                                    if (!columns.Contains(data.Columns[m].ColumnName))
                                    {
                                        // Creates new columns that are the same name as that ones pulled from the data table analyzed in the new data table 
                                        // that stores the results that fall within the range of error bounds
                                        storage.Columns.Add(data.Columns[m - 1].ColumnName, typeof(string));
                                        storage.Columns.Add(data.Columns[m].ColumnName, typeof(string));

                                        dr[data.Columns[m - 1].ColumnName] = data.Rows[i][m].ToString();
                                        dr[data.Columns[m].ColumnName] = data.Rows[i][m].ToString();

                                        m += 2;
                                    }
                                }
                                // Adds the newly created row to the data table
                                storage.Rows.Add(dr);
                            }

                        }

                        k += 2;
                        l += 2;
                    }
                }
            }

            return storage;
        }

        public string CreateTextFileString(string path, string tableName)
        {
            string fileName = "";
            fileName += path + tableName + ".txt";
            return fileName;
        }
        public string CreateCountFileString(string path, string tableName)
        {
            string fileName = "";
            fileName += path + "\\" + tableName + "Count.txt";
            return fileName;
        }
    }
}
