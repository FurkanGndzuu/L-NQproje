using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LİNQproje
{
    internal class Order
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customers Customers { get; set; }
        public List<Order> GetOrders()
        {
            List<Order> liste = new List<Order>();

            string sorgu= @"select  o.OrderID,o.CustomerID,o.EmployeeID,o.OrderDate,c.ContactName
                            from Orders o
                            inner join Customers c
                            on o.CustomerID = c.CustomerID";

            DataTable dataTable = GetDataTbale(sorgu);

            foreach(DataRow item in dataTable.Rows)
            {
                Order order = new Order();

                order.OrderID = (int)item["OrderID"];
                order.CustomerID = (string)item["CustomerID"];
                order.EmployeeID = (int)item["EmployeeID"];
                order.OrderDate = (DateTime)item["OrderDate"];

                order.Customers = new Customers();

                order.Customers.ContactName = (string)item["ContactName"];

                


                liste.Add(order);
            }
            return liste;
        }

        private DataTable GetDataTbale(string sorgu)
        {
            string ConnectionString = @"Data Source=DESKTOP-LDMU7VJ\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            SqlDataAdapter sda = new SqlDataAdapter(sorgu,ConnectionString);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
    }

    internal class Customers
    {
        public string CustomerID { get; set; }
        public string ContactName { get; set; }

        public List<Order> orders { get; set; }
        public int OrderCount
        {
            get
            {
                return orders.Count;
            }
        }

    }
}
