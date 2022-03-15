using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoExample
{
    public class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
        public void Top3Products(List<ProductReview> listProductReview)
        {
            var recordData = (from productReview in listProductReview
                              orderby productReview.Rating descending
                          select productReview).Take(3);

            Console.WriteLine(" displaying Top 3 products");

            foreach (var list in recordData)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", list.ProductId, list.UserId, list.Rating, list.Review, list.IsLike);
            }
        }
    }
}
