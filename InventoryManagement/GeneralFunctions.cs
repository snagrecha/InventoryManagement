using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace InventoryManagement
{
    class GeneralFunctions
    {

        public static string StandardiseIntToString(int number, int sizeOfString)
        {
            string standardisedPrefix = number.ToString();
            
            while(standardisedPrefix.Length < sizeOfString)
            {
                standardisedPrefix = "0" + standardisedPrefix;
            }

            return standardisedPrefix;
        }

        public static void CreatePrefixNameDict()
        {
            Home.prefixToNameDict.Clear();
            Home.nameToPrefixDict.Clear();
            foreach(DataRow row in Home.stockTypes.Rows)
            {
                Home.prefixToNameDict.Add(row["Prefix"].ToString(), row["Name"].ToString());
                Home.nameToPrefixDict.Add(row["Name"].ToString(), row["Prefix"].ToString());
            }
        }

        public static string IncrementString(string number, int increment = 1)
        {
            string incrementedString;
            long num;

            long.TryParse(number, out num);
            num += increment;

            incrementedString = num.ToString();

            int difference = number.Length - incrementedString.Length;

            while(difference>0)
            {
                incrementedString = "0" + incrementedString;
                difference--;
            }

            return incrementedString;
        }

        public static int WriteToExcel(System.Data.DataTable dt)
        {

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelPackage excel  = new ExcelPackage();
            

            var worksheet = excel.Workbook.Worksheets.Add("Sheet 1");

            worksheet.Cells[1, 1].Value = "Sr";
            worksheet.Cells[1, 2].Value = "Stock Type";
            worksheet.Cells[1, 3].Value = "Qty";
            worksheet.Cells[1, 4].Value = "Date";

            int rowCount = 1;

            foreach(DataRow row in dt.Rows)
            {
                rowCount += 1;


                //worksheet.Cells[rowCount, i] = new Cell(rowCount + "," + i);
                worksheet.Cells[rowCount, 1].Value = row["Sr"].ToString();
                worksheet.Cells[rowCount, 2].Value = row["Stock Type"].ToString();
                worksheet.Cells[rowCount, 3].Value = row["Qty"].ToString();
                worksheet.Cells[rowCount, 4].Value = row["Date"].ToString();
            }

            FileStream objFileStream = File.Create("StockBarcode.xls");
            objFileStream.Close();

            File.WriteAllBytes("StockBarcode.xls", excel.GetAsByteArray());

            excel.Dispose();


            /*Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Sheet 1");


            worksheet.Cells[0, 0].Value = new Cell("Sr").Value;
            //worksheet.Cells[0, 1].Value = "Stock Type";
            //worksheet.Cells[0, 2].Value = "Qty";

            /*int rowCount = 0;

            foreach(DataRow row in dt.Rows)
            {
                rowCount += 1;


                //worksheet.Cells[rowCount, i] = new Cell(rowCount + "," + i);
                worksheet.Cells[rowCount, 0] = new Cell(row["Sr"].ToString());
                worksheet.Cells[rowCount, 1] = new Cell(row["Stock Type"].ToString());
                worksheet.Cells[rowCount, 2] = new Cell(row["Qty"].ToString());
            }
            

            workbook.Worksheets.Add(worksheet);
            workbook.Save("StockBarcode.xls");
            */

            return 1;
        }

        public static void OpenWordFile(string fileName = "BarcodePrintMailingList.docx")
        {
            System.Diagnostics.Process.Start(fileName);

        }
    }
}
