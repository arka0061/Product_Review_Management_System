using System;
using System.Collections.Generic;

namespace Product_Review_ManagementSystem
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Product Review Management System!");
            List<ProductReview> products = new List<ProductReview>();
            {
                products.Add(new ProductReview() { ProductID = 1, UserID = 1, Review = "Good", Rating = 14, IsLike = true });
                products.Add(new ProductReview() { ProductID = 2, UserID = 2, Review = "Average", Rating = 12, IsLike = true });
                products.Add(new ProductReview() { ProductID = 3, UserID = 4, Review = "Good", Rating = 19, IsLike = true });
                products.Add(new ProductReview() { ProductID = 2, UserID = 5, Review = "Bad", Rating = 7, IsLike = false });
                products.Add(new ProductReview() { ProductID = 1, UserID = 1, Review = "Very Good", Rating = 19, IsLike = true });
                products.Add(new ProductReview() { ProductID = 2, UserID = 6, Review = "Average", Rating = 10, IsLike = true });
                products.Add(new ProductReview() { ProductID = 4, UserID = 7, Review = "Good", Rating = 15, IsLike = true });
                products.Add(new ProductReview() { ProductID = 9, UserID = 8, Review = "Average", Rating = 11, IsLike = true });
                products.Add(new ProductReview() { ProductID = 3, UserID = 9, Review = "Bad", Rating = 6, IsLike = false });
                products.Add(new ProductReview() { ProductID = 5, UserID = 4, Review = "Average", Rating = 13, IsLike = true });
                products.Add(new ProductReview() { ProductID = 7, UserID = 10, Review = "Very Good", Rating = 18, IsLike = true });
                products.Add(new ProductReview() { ProductID = 9, UserID = 5, Review = "Very Good", Rating = 17, IsLike = true });
                products.Add(new ProductReview() { ProductID = 10, UserID = 3, Review = "Bad", Rating = 9, IsLike = false });
                products.Add(new ProductReview() { ProductID = 11, UserID = 2, Review = "Bad", Rating = 8, IsLike = false });
                products.Add(new ProductReview() { ProductID = 12, UserID = 9, Review = "Average", Rating = 11, IsLike = true });
                products.Add(new ProductReview() { ProductID = 13, UserID = 11, Review = "Good", Rating = 15, IsLike = true });
                products.Add(new ProductReview() { ProductID = 14, UserID = 3, Review = "Bad", Rating = 6, IsLike = false });
                products.Add(new ProductReview() { ProductID = 15, UserID = 15, Review = "Very Good", Rating = 19, IsLike = true });
                products.Add(new ProductReview() { ProductID = 16, UserID = 9, Review = "Bad", Rating = 7, IsLike = false });
                products.Add(new ProductReview() { ProductID = 17, UserID = 1, Review = "Very Good", Rating = 20, IsLike = true });
                products.Add(new ProductReview() { ProductID = 18, UserID = 6, Review = "Average", Rating = 10, IsLike = true });
                products.Add(new ProductReview() { ProductID = 19, UserID = 7, Review = "Good", Rating = 15, IsLike = true });
                products.Add(new ProductReview() { ProductID = 20, UserID = 8, Review = "Average", Rating = 11, IsLike = true });
                products.Add(new ProductReview() { ProductID = 21, UserID = 9, Review = "Bad", Rating = 6, IsLike = false });
                products.Add(new ProductReview() { ProductID = 22, UserID = 22, Review = "Average", Rating = 13, IsLike = true });
                products.Add(new ProductReview() { ProductID = 23, UserID = 23, Review = "Average", Rating = 15, IsLike = true });
                products.Add(new ProductReview() { ProductID = 24, UserID = 24, Review = "Average", Rating = 20, IsLike = true });
                products.Add(new ProductReview() { ProductID = 25, UserID = 25, Review = "Average", Rating = 11, IsLike = true });
            }
            ProductManagement manage = new ProductManagement();
            manage.TopRecords(products);
            manage.SelectedRecords(products);
            manage.RetrieveCountOfRecords(products);
        }
    }
}
