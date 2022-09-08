using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLinq
{
    public class ProductManagement
    {
        /// <summary>
        /// UC2
        /// Retriving top three records whose ratings is high
        /// </summary>
        /// <param name="productReviewList"></param>
        public void GetTopThreeRecords(List<ProductReview> productReviewList)
        {
            // Linq query to retrieve top three having high ratings
            var recordedData = (from prodctReviews in productReviewList
                                orderby prodctReviews.Rating descending
                                select prodctReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " "
                    + list.Rating + " " + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
        /// <summary>
        /// Retriving records whose ratings >3 and ProductID=1 or 4 or 9
        /// //<ProductReviewManagementUsingLinq.ProductReview>
        /// </summary>
        /// <param name="productReviewList"></param>

        public void GetRecordsHavingRatingsGreaterThanThreeAndSpecificProductID(List<ProductReview> productReviewList)
        {
            // Linq query to retrieve records with given condition
            IEnumerable<ProductReview> recordedData = (from productsL in productReviewList
                                                       where (productsL.Rating > 3) && (productsL.ProductID == 1 || productsL.ProductID == 4 ||
                                                       productsL.ProductID == 9)
                                                       select productsL);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " " + list.Rating + " "
                + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
        /// <summary>
        /// UC4
        /// Review Count for each product id
        /// using object listReview also by grouping the ProductId
        /// then selecting ProductId and then count is used 
        /// ProductId is Unique so we take as key 
        /// Count()-> returns no of element in sequence;method inside IEnumerable; 
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveReviewCountForEachProductIdOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            Console.WriteLine("ProductId and their review count:");

            foreach (var list in recordedData)
            {
                Console.WriteLine($"ProductID:{list.ProductID},ReviewCount:{list.Count}");
            }
        }
        /// <summary>
        /// UC5
        /// from productreviews of object table listreview retrieve 
        /// only product id and review product reviews from the list
        /// </summary>
        /// <param name="listProductReview"></param>
        public void RetrieveProductIdAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = from productReviews in listProductReview
                               select new
                               {
                                   productReviews.ProductID,
                                   productReviews.Review
                               };

            foreach (var list in recordedData)
            {
                Console.WriteLine("Product Id:- " + list.ProductID + " " + "Review: " + list.Review);
            }
        }
        /// <summary>
        /// UC6
        /// Gets all records except top five records.
        /// </summary>
        /// <param name="productReviewList"></param>
        public void GetAllRecordsExceptSkipTopFiveRecords(List<ProductReview> productReviewList)
        {
            var recordedReviewCount = (from product in productReviewList
                                       orderby product.ProductID
                                       select product).Skip(5);
            Console.WriteLine("--------------------Records_After_Skipping_Top_Five-----------------------------------------------");
            foreach (var list in recordedReviewCount)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " " + list.Rating + " "
                + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
    }
}
