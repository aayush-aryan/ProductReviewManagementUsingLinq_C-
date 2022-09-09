using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLinq
{
   public class ProductReviewDataTable
    {
        /// <summary>
        /// Data binding is a common use of DataTable object.
        /// When the data operations have been performed, the new DataTable is merged back into the source DataTable.
        /// creating dataTable object
        /// </summary>
        public static DataTable dataTable = new DataTable();
        /// <summary>
        /// Uc8
        /// Adds data into data table.
        /// </summary>
        public static void AddDataIntoDataTable()
        {
            //Columns-return collections of datacolumn object for the table
            //Add- add datacolumns object and return newly created data column
            //Adding Fields into the datatable
            dataTable.Columns.Add("ProductId", typeof(Int32));
            dataTable.Columns.Add("UserId", typeof(Int32));
            dataTable.Columns.Add("Rating", typeof(double));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));
            //returns datarow collections contains datarow objects;
            // Creating rows and adding values into column wise
            dataTable.Rows.Add(1, 1, 5, "good", "true");
            dataTable.Rows.Add(2, 2, 3, "better", "true");
            dataTable.Rows.Add(3, 3, 5, "good", "true");
            dataTable.Rows.Add(4, 4, 4, "nice", "true");
            dataTable.Rows.Add(5, 5, 3, "better", "true");
            dataTable.Rows.Add(6, 6, 5, "good", "false");
            dataTable.Rows.Add(7, 7, 5, "good", "true");
            dataTable.Rows.Add(8, 7, 5, "better", "true");
            dataTable.Rows.Add(9, 8, 3, "good", "true");
            dataTable.Rows.Add(10, 9, 5, "good", "true");
            dataTable.Rows.Add(11, 10, 3, "better", "true");
            dataTable.Rows.Add(12, 10, 4, "nice", "false");
            dataTable.Rows.Add(13, 11, 3, "better", "true");
            dataTable.Rows.Add(14, 11, 4, "good", "true");
            dataTable.Rows.Add(15, 11, 5, "good", "true");
            dataTable.Rows.Add(16, 11, 5, "good", "true");
            dataTable.Rows.Add(17, 11, 3, "better", "true");
            dataTable.Rows.Add(18, 12, 4, "nice", "true");
            dataTable.Rows.Add(19, 15, 5, "good", "true");
            dataTable.Rows.Add(20, 16, 5, "good", "true");
            dataTable.Rows.Add(21, 17, 5, "good", "true");
            dataTable.Rows.Add(22, 11, 4, "nice", "true");
            dataTable.Rows.Add(23, 18, 3, "better", "false");
            dataTable.Rows.Add(24, 19, 4, "nice", "true");
            dataTable.Rows.Add(25, 20, 4, "nice", "true");

            //Printing data
            Console.WriteLine("\nDataTable contents are :");
            foreach (var dataTableList in dataTable.AsEnumerable()) // returns IEnumerable<datarow> object;
            {
                //Field<genericType>("columnName")-returns value of specified colum generic Type
                Console.WriteLine($"ProductID:{dataTableList.Field<int>("ProductId")}\tUserID:{dataTableList.Field<int>("UserId")}" +
                    $"\tRating:{dataTableList.Field<double>("Rating")}\tReview:{dataTableList.Field<string>("Review")}\tIsLike:{dataTableList.Field<bool>("IsLike")}");
            }

        }

        /// <summary>
        /// UC9 
        /// Retrieveing all records whose islike is true.
        /// </summary>
        public static void RetrivingAllRecordsFromDataTableWhoseIsLikeIsTrue()
        {
            var retrievedData = from records in dataTable.AsEnumerable()
                                where (records.Field<bool>("IsLike") == true)
                                select records;
            Console.WriteLine("\nRecords in table whose IsLike value is true:");
            foreach (var tableObjectList in retrievedData)
            {
                Console.WriteLine($"ProductID:{tableObjectList.Field<int>("ProductId")}\tUserID:{tableObjectList.Field<int>("UserId")}" +
                    $"\tRating:{tableObjectList.Field<double>("Rating")}\tReview:{tableObjectList.Field<string>("Review")}\tIsLike:{tableObjectList.Field<bool>("IsLike")}");
            }
        }

        /// <summary>
        /// UC 10 
        /// method for Finding average rating for each productId.
        /// </summary>
        public static void FindingAverageRatingForEachProductId()
        {
            var retrievedData = dataTable.AsEnumerable().GroupBy(r => r.Field<int>("ProductId"))
                .Select(x => new { ProductId = x.Key, Average = x.Average(r => r.Field<double>("Rating")) });
            Console.WriteLine("\nProductId and its average rating");
            foreach (var tableObj in retrievedData)
            {
                Console.WriteLine($"ProductID:{tableObj.ProductId},AverageRating:{tableObj.Average}");
            }
        }

        /// <summary>
        /// UC 11
        ///  Retrieving all records having nice review message.
        /// </summary>
        public static void RetrieveRecordsWhoseReviewMessageIsNice()
        {
            var retrievedData = from records in dataTable.AsEnumerable()
                                where (records.Field<string>("Review") == "nice")
                                select records;
            Console.WriteLine("\nRecords in table whose Review message=nice:");
            foreach (var tblObj in retrievedData)
            {
                Console.WriteLine($"ProductID:{tblObj.Field<int>("ProductId")}\tUserID:{tblObj.Field<int>("UserId")}\tRating:{tblObj.Field<double>("Rating")}\tReview:{tblObj.Field<string>("Review")}\tIsLike:{tblObj.Field<bool>("IsLike")}");
            }
        }
    }
}
  