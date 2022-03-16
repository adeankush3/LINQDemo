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
                Console.WriteLine("ProductId-" + list.ProductId + "" + "UserId-" + list.UserId + "" + "Rating-" + list.Rating + "" + "Review-" + list.Review + "" + "IsLike-" + list.IsLike);
            }
        }
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            var recordData = from productReview in listProductReview
                             where (productReview.ProductId == 1 && productReview.Rating > 3) ||
                             (productReview.ProductId == 4 && productReview.Rating > 3) ||
                             (productReview.ProductId == 9 && productReview.Rating > 3)
                             select productReview;
            Console.WriteLine("Selected Record Display Rating");

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId-" + list.ProductId + "" + "UserId-" + list.UserId + "" + "Rating-" + list.Rating + "" + "Review-" + list.Review + "" + "IsLike-" + list.IsLike);
            }
        }
    }
}
