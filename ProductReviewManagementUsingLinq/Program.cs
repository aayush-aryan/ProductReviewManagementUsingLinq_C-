using System;
using System.Collections.Generic;

namespace ProductReviewManagementUsingLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review Management!");
            //Adding ProductReview object in List; 
            List<ProductReview> productReviewList = new List<ProductReview>()
            {
                new ProductReview(){ ProductID = 1, UserID = 1, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 2, UserID = 2, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 3, UserID = 3, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 4, UserID = 4, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 5, UserID = 5, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 6, UserID = 6, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 7, UserID = 7, Rating = 5, Review = "bad", isLike = true},
                new ProductReview(){ ProductID = 8, UserID = 8, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 9, UserID = 9, Rating = 5, Review = "nice", isLike = true},
                new ProductReview(){ ProductID = 10, UserID = 10, Rating = 4, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 11, UserID = 10, Rating = 4, Review = "nice", isLike = true},
                new ProductReview(){ ProductID = 12, UserID = 10, Rating = 5, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 13, UserID = 11, Rating = 2, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 14, UserID = 12, Rating = 5, Review = "nice", isLike = true},
                new ProductReview(){ ProductID = 15, UserID = 13, Rating = 3, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 16, UserID = 13, Rating = 4, Review = "nice", isLike = true},
                new ProductReview(){ ProductID = 17, UserID = 13, Rating = 4, Review = "Good", isLike = true},
                new ProductReview(){ ProductID = 18, UserID = 14, Rating = 5, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 19, UserID = 15, Rating = 5, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 20, UserID = 16, Rating = 5, Review = "nice", isLike = false},
                new ProductReview(){ ProductID = 21, UserID = 17, Rating = 4, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 22, UserID = 10, Rating = 5, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 23, UserID = 18, Rating = 5, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 24, UserID = 20, Rating = 5, Review = "Good", isLike = false},
                new ProductReview(){ ProductID = 25, UserID = 20, Rating = 5, Review = "Good", isLike = false},
            };
            foreach (var list in productReviewList)
            {
                Console.WriteLine("ProductId :-" + list.ProductID + " " + "UserId :-" + list.UserID + " " + "Rating :-" + " " + list.Rating + " "
                + "Review :-" + list.Review + " " + "isLike :-" + list.isLike);
            }
            ProductManagement productManagement = new ProductManagement();

            // To Retrieve top three records with having high ratings
            // productManagement.GetTopThreeRecords(productReviewList);
            //  Console.WriteLine("---------------RecodrdsGreaterthenthreeRatingsAndUserID-1-4-9---------");
            // productManagement.GetRecordsHavingRatingsGreaterThanThreeAndSpecificProductID(productReviewList);
            // Console.WriteLine("----Review count for each product ID:");
            // productManagement.RetrieveReviewCountForEachProductIdOfRecords(productReviewList);
            // Console.WriteLine("------ProductID_And_Review_only---------------");
            // productManagement.RetrieveProductIdAndReview(productReviewList);
            // productManagement.GetAllRecordsExceptSkipTopFiveRecords(productReviewList);
            //UC7
            // productManagement.RetrieveOnlyProductIDAndReviewOfAllRecordsUsingSelect(productReviewList);
            //UC 8
            //Created data table
           // ProductReviewDataTable.AddDataIntoDataTable();
            //uc9
            ProductReviewDataTable.RetrivingAllRecordsFromDataTableWhoseIsLikeIsTrue();
        }
    }
}
