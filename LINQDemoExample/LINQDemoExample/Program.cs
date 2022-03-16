using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LINQDemo Program");
            List<ProductReview> productReviewsList = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 2, UserId = 1, Rating = 5, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 3, UserId = 2, Rating = 4, Review = "Avg", IsLike = false },
                new ProductReview() { ProductId = 4, UserId = 2, Rating = 5, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 5, UserId = 3, Rating = 3, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 6, UserId = 4, Rating = 5, Review = "nice", IsLike = false },
                new ProductReview() { ProductId = 7, UserId = 3, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 8, UserId = 10, Rating = 5, Review = "Avg", IsLike = false },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 10, UserId = 10, Rating = 1, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 11, UserId = 10, Rating = 5, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 12, UserId = 17, Rating = 4, Review = "Good", IsLike = false },
                new ProductReview() { ProductId = 13, UserId = 8, Rating = 5, Review = "Avg", IsLike = true },
                new ProductReview() { ProductId = 14, UserId = 10, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 15, UserId = 9, Rating = 2, Review = "Good", IsLike = true },
                new ProductReview() { ProductId = 16, UserId = 10, Rating = 3, Review = "bad", IsLike = false },
                new ProductReview() { ProductId = 17, UserId = 11, Rating = 5, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 18, UserId = 10, Rating = 4, Review = "good", IsLike = true },
                new ProductReview() { ProductId = 19, UserId = 12, Rating = 5, Review = "nice", IsLike = false },
                new ProductReview() { ProductId = 20, UserId = 13, Rating = 1, Review = "bad", IsLike = true },
                new ProductReview() { ProductId = 21, UserId = 14, Rating = 5, Review = "Avg", IsLike = false },
                new ProductReview() { ProductId = 22, UserId = 15, Rating = 3, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 23, UserId = 20, Rating = 5, Review = "good", IsLike = false },
                new ProductReview() { ProductId = 24, UserId = 21, Rating = 4, Review = "nice", IsLike = true },
                new ProductReview() { ProductId = 25, UserId = 23, Rating = 5, Review = "bad", IsLike = false }
            };
            foreach (var list in productReviewsList)
            {
                Console.WriteLine("ProductId-" + list.ProductId + "" + "UserId-" + list.UserId + "" + "Rating-" + list.Rating + "" + "Review-" + list.Review + "" + "IsLike-" + list.IsLike);
            }
            ProductManagement management = new ProductManagement();
            //management.Top3Products(productReviewsList);
            //management.SelectedRecords(productReviewsList);
            management.RetriveCountOfRecord(productReviewsList);
            management.ShowProductIDAndReview(productReviewsList);


        }
    }
}
