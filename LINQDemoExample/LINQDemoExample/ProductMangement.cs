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
            //var recordData = from productReview in listProductReview
            //                 where (productReview.ProductId == 1 && productReview.Rating > 3) ||
            //                 (productReview.ProductId == 4 && productReview.Rating > 3) ||
            //                 (productReview.ProductId == 9 && productReview.Rating > 3)
            //                 select productReview;

            var recordData = from productReview in listProductReview
                             where (productReview.ProductId == 1 || productReview.ProductId == 4 || productReview.ProductId == 9)
                             && productReview.Rating > 3
                             select productReview;
            Console.WriteLine("Selected Record Display Rating");
            

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductId-" + list.ProductId + "" + "UserId-" + list.UserId + "" + "Rating-" + list.Rating + "" + "Review-" + list.Review + "" + "IsLike-" + list.IsLike);
            }
        }
        public void RetriveCountOfRecord(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\n - - -  Retrieve count of review present for each productID - - - ");
            var recordData = listProductReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, count = x.Count() });

            Console.WriteLine(" ProductId\tcount");
            foreach (var list in recordData)
            {
                Console.WriteLine(" Product Id : {0} \t ReviewCount : {1}", list.ProductId, list.count);
            }
        }
        public void ShowProductIDAndReview(List<ProductReview> listProductReview)
        {

            var result = (from productReview in listProductReview
                          orderby (productReview.ProductId)
                          select productReview).ToList();

            Console.WriteLine("\n - - -  Display productID , Reviews from all records  - - -");
            Console.WriteLine(" Product Id \t Review");

            foreach (ProductReview productReview in result)
            {
                Console.WriteLine(" {0}\t\t{1}", productReview.ProductId, productReview.Review);
            }
        }
        public void SkipTop5Records(List<ProductReview> listProductReview)
        {
            var result = (from productReview
                          in listProductReview
                          select productReview).Skip(5);

            Console.WriteLine("\n - - -  Displaying top 5 skipped records - - - ");
            Console.WriteLine(" ProductId\tUserId Rating\tReview \t IsLike ");

            foreach (ProductReview productReview in result)
            {
                Console.WriteLine(" {0}\t\t{1}\t{2}\t{3}\t  {4}", productReview.ProductId, productReview.UserId, productReview.Rating, productReview.Review, productReview.IsLike);
            }
        }
    }
}
