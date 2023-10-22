using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace InventoryManagement
{
   class DBHandler
    {
        //public static String hostServerName = Home.hostServerName;
        //public static String hostDBName = Home.hostDBName;
        
        public static String hostServerName = "JUNIOR";
        public static String hostDBName = "InventoryManagement";

        public static SqlConnection ConnectToDB(String serverName, String dbname)
        {
            SqlConnection con = null;
            String ConnectionString = "Server=" + serverName + ";Initial Catalog=" + dbname + ";UID=sn;PWD=sn;Pooling=False";
            //String ConnectionString = ConfigurationManager.ConnectionStrings["StockHP"].ConnectionString;
            //String ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Stock"].ToString();

            //SqlConnection con = new SqlConnection(ConnectionString);
            con = new SqlConnection(ConnectionString);

            //Debug.WriteLine(ConnectionString);

            return con;
        }

        public static int AddNewStockType(string name, string defaultBundleSize)
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            String query = "INSERT INTO StockMaster(Name, DefaultBundleSize) VALUES ('" + name + "', " + defaultBundleSize + ")";

            Debug.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return 1;
        }


        public static int AddNewStock(string sr, string name, string qty, string voucherNo, string remarks = "")
        {

            SqlConnection con = ConnectToDB(hostServerName, hostDBName);
            
            String query;
            /*
            if (remarks.Length == 0)
            {
                query = "INSERT INTO DetailedStock(Sr, Name, Qty, InStock, DateAdded, VoucherNo, Remarks) VALUES ('" + sr + "', '" + name + "', " + qty + ", 1, CURRENT_TIMESTAMP, " + voucherNo + ", " + remarks + ")";

            }*/

            query = "INSERT INTO DetailedStock(Sr, Name, Qty, InStock, DateAdded, VoucherNo, Remarks) VALUES ('" + sr + "', '" + name + "', " + qty + ", 1, CURRENT_TIMESTAMP, " + voucherNo + ", '" + remarks + "')";

            Debug.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            return 1;
        }

        public static int GetLatestVoucherNo()
        {
            int voucherNo = 0;

            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            string query = "SELECT Max(VoucherNo) as VoucherNo FROM DetailedStock";

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    int.TryParse(row["VoucherNo"].ToString(), out voucherNo);
                    break;
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


            return voucherNo;
        }

        public static string GetTotalQtyofStockType(string stockType)
        {
            string totalQty = "0";

            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            string query = "SELECT SUM(Qty) as TotalQty FROM DetailedStock WHERE Name = '" + stockType + "' AND InStock = 1";

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    totalQty = row["TotalQty"].ToString();
                    break;
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


            return totalQty;
        }

        public static bool GetInStockStatus(string sr)
        {
            bool inStock = false;

            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            string query = "SELECT InStock from DetailedStock WHERE Sr = " + sr + " AND InStock = 1";

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    inStock = true;

                    break;
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


            return inStock;
        }

        public static string GetLatestSr(string standardisedPrefix)
        {
            string sr = "";

            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            string query = "SELECT TOP 1 Sr from DetailedStock WHERE Sr LIKE '" + standardisedPrefix + "%' ORDER BY CAST (Sr as bigint) DESC";

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);

                foreach(DataRow row in dt.Rows)
                {
                    sr = row["Sr"].ToString();
                    break;
                }
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }


            return sr;
        }

        public static DataTable GetStockTypes(string clause = "")
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            String query = "SELECT * FROM StockMaster " + clause;

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dt;
        }

        public static DataTable GetDetailedStock(string values = "*", string clause = "")
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            String query = "SELECT " + values + " FROM DetailedStock " + clause;

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dt;
        }

        public static DataTable GetStockOverView(string clause = "WHERE InStock = 1 GROUP BY Name")
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            String query = "SELECT Name, COUNT(Qty) AS 'Total Bundles', SUM(Qty) AS 'Total Qty' FROM DetailedStock " + clause;

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return dt;
        }

        public static int UpdateRemarks(string sr, string remarks)
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            String query = "UPDATE DetailedStock SET Remarks = '" + remarks + "' WHERE Sr = " + sr;

            Debug.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return 1;
        }

        public static int RemoveFromStock(string sr)
        {
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            String query = "UPDATE DetailedStock SET InStock = 0, DateConsumed = CURRENT_TIMESTAMP WHERE Sr = " + sr;

            Debug.WriteLine(query);

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return 1;
        }
        public static int GetDefaultBundleSize(int prefix)
        {
            int defaultBundleSize = 0;
            SqlConnection con = ConnectToDB(hostServerName, hostDBName);

            DataTable dt = new DataTable();

            String query = "SELECT DefaultBundleSize FROM StockMaster WHERE Prefix = '" + prefix + "'";

            Debug.WriteLine(query);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);


                adapter.Fill(dt);
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            foreach (DataRow row in dt.Rows)
            {
                defaultBundleSize = int.Parse(row["DefaultBundleSize"].ToString());
            }

            return defaultBundleSize;
        }

    }
}
