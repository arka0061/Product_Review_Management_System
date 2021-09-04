using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Product_Review_ManagementSystem
{
    public class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReview> review)
        {
            var recordedData = (from list in review
                                orderby list.Rating descending
                                select list).Take(3);

            foreach (var item in recordedData)
            {
                Console.WriteLine("Product Id: " + item.ProductID + "User Id: " + item.UserID + "Product Rating: " + item.Rating + "Is Like: " + item.IsLike);
            }
        }

        internal void TopRecords()
        {
            throw new NotImplementedException();
        }
    }
}
