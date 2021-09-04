using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Review_ManagementSystem
{
    public class ProductReview
    {
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }
    }
}
