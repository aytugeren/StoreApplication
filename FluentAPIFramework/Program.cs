
using FluentAPIFramework.Entities;
using System;
using System.Collections.Generic;

namespace FluentAPIFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            AddInformationtoDatabase();

        }

        private static void AddInformationtoDatabase()
        {
            using (var context = new EmployeeContext())
            {
                var employee1 = new Employee()
                {
                    Firstname = "Ahmet",
                    Surname = "Kara",
                    Age = 25,
                    MonthlySalary = 5000,

                };
                var employee2 = new Employee()
                {
                    Firstname = "Hakan",
                    Surname = "Kurtulmus",
                    Age = 20,
                    MonthlySalary = 3000,
                    
                };
                var address2 = new AddressInfo()
                {
                    Address1 = "asdasdasd",
                    Address2 = "adfsadfasf",
                    ZipCode = "34122"
                };
                var customer1 = new Customer()
                {
                    Firstname = "Mustafa",
                    Surname = "Elibos",
                    Age = 30,
                    AddressInfo = address2
                };
                var address3 = new AddressInfo()
                {
                    Address1 = "asdasdasd",
                    Address2 = "adfsadfasf",
                    ZipCode = "34122"
                };
                var customer2 = new Customer()
                {
                    Firstname = "Elif",
                    Surname = "Sensiz",
                    Age = 28,
                    AddressInfo = address3
                };
                var customer3 = new Customer()
                {
                    Firstname = "Mehmet",
                    Surname = "Sonsuz",
                    Age = 28,
                    AddressInfo = new AddressInfo { Address1 = "Fatih Mahallesi Feyyaz Altinortak Caddesi", Address2 = "Ahmet Apartmani No:24", ZipCode = "23412"}
                };
                var category = new Category()
                {
                    Name = "T-shirt",
                    Orders = new List<Order> { new Order { Name = "Blue T-Shirt", Amount = 24.99M, Piece = 23 },
                    new Order {Name = "Red T-Shirt", Amount = 24.99M, Piece = 20},
                    new Order {Name = "Black T-Shirt", Amount = 24.99M, Piece = 5 },
                    new Order {Name = "Green T-Shirt", Amount = 24.99M, Piece = 50 } }

                };
                var category1 = new Category()
                {
                    Name = "Sweat",
                    Orders = new List<Order> { new Order { Name = "Blue Sweat", Amount = 35.99M, Piece = 23 },
                    new Order {Name = "Red Sweat", Amount = 35.99M, Piece = 20},
                    new Order {Name = "Black Sweat", Amount = 35.99M, Piece = 5 },
                    new Order {Name = "Green Sweat", Amount = 35.99M, Piece = 50 } }
                };
                var category2 = new Category()
                {
                    Name = "Jean",
                    Orders = new List<Order> { new Order { Name = "Blue Jean", Amount = 99.99M, Piece = 23 },
                    new Order {Name = "Red Jean", Amount = 99.99M, Piece = 20},
                    new Order {Name = "Black Jean", Amount = 99.99M, Piece = 5 },
                    new Order {Name = "Green Jean", Amount = 99.99M, Piece = 50 } }
                };
                var category3 = new Category()
                {
                    Name = "Shirt",
                       Orders = new List<Order> { new Order { Name = "Blue Shirt", Amount = 35.99M, Piece = 23 },
                    new Order {Name = "Red Shirt", Amount = 35.99M, Piece = 20},
                    new Order {Name = "Black Shirt", Amount = 35.99M, Piece = 5 },
                    new Order {Name = "Green Shirt", Amount = 35.99M, Piece = 50 } }
                };
             

                context.Employees.Add(employee1);
                context.Employees.Add(employee2);
                context.Customers.Add(customer1);
                context.Customers.Add(customer2);
                context.Customers.Add(customer3);

                context.Categories.Add(category);
                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);
                context.SaveChanges();
            }
        }
    }
}
