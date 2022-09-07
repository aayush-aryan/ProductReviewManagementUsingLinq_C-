using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductReviewManagementUsingLinq
{
    public class ProductManagement
    {
        public void GetTopThreeRecords(List<ProductReview> productReviewList)
        {
            /// Linq query to retrieve top three having high ratings
            var recordedData = (from prodctReviews in productReviewList
                                orderby prodctReviews.Rating descending
                                select prodctReviews).Take(3);

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId:-" + list.UserID + " " + "Rating :-" + " " + list.Rating + " "
                + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
        }
    }
}
