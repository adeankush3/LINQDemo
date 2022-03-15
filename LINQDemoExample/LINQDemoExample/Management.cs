using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemoExample
{
    public class Management
    {
        public readonly DataTable datatable = new DataTable();
        public void Top3Products(List<ProductReview> ProductList)
        {
            var result = (from productReview in ProductList
                          orderby productReview.Rating descending
                          select productReview).Take(3);

            Console.WriteLine(" Displaying Top 3 products");

            foreach (ProductReview p in ProductList)
            {
                Console.WriteLine("Product Id : {0}\tUser Id : {1}\tRating : {2}\tReview : {3}\tIsLike : {4}", p.ProductId, p.UserId, p.Rating, p.Review, p.IsLike);
            }
        }
    }

}
