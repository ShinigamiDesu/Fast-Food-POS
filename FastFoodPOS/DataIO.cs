using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data;

namespace FastFoodPOS
{
    internal class DataIO
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\amazi\\OneDrive\\Desktop\\C# coding\\Websites, Apps And Databases\\FastFoodPOS\\FastFoodPOS\\FastFoodPOS\\FoodPOS.mdf\";Integrated Security=True");

        public void addProduct(string name, string desc, string price, byte[] img, int category) 
        {
            string insert = "INSERT INTO tbl_Items(item_Name, item_Description, item_Price, item_IMG, item_Category) VALUES(@name, @desc, @price, @img, @cat)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@cat", category);
            cmd.Parameters.AddWithValue("@img", img);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addCategory(string name, byte[] img)
        {
            string insert = "INSERT INTO tbl_Category(category_Name, category_IMG) VALUES(@name, @img)";
            SqlCommand cmd = new SqlCommand(insert, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@img", img);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addOrder(int orderID, decimal totalAMT) 
        {
            string INSERT = "INSERT INTO tbl_Orders(order_ID, order_TotalAMT) VALUES(@id, @total)";
            SqlCommand cmd = new SqlCommand(INSERT, con);
            cmd.Parameters.AddWithValue("@id", orderID);
            cmd.Parameters.AddWithValue("@total",totalAMT);
            try 
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Order Number is: " + orderID + "\nPlease take your receipt to the counter.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateOrder(string orderID, int choice)
        {
            if(choice == 1) 
            {
                string UPDATE = "UPDATE tbl_Orders SET order_Status = 1 WHERE order_ID = '" + orderID + "'";
                SqlCommand cmd = new SqlCommand(UPDATE, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(choice == 2) 
            {
                string UPDATE = "UPDATE tbl_Orders SET order_Status = 2 WHERE order_ID = '" + orderID + "'";
                SqlCommand cmd = new SqlCommand(UPDATE, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        public void addOrderItems(int orderID, int itemID, int itemQuantity) 
        {
            string INSERT = "INSERT INTO tbl_OrderItems(order_ID, item_ID, item_Quantity) VALUES(@orderid, @itemid, @quan)";
            SqlCommand cmd = new SqlCommand(INSERT, con);
            cmd.Parameters.AddWithValue("@orderid", orderID);
            cmd.Parameters.AddWithValue("@itemid", itemID);
            cmd.Parameters.AddWithValue("@quan", itemQuantity);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable getAllCategory() 
        {
            string select = "SELECT * FROM tbl_Category";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getMealsCategory()
        {
            string select = "SELECT * FROM tbl_Items JOIN tbl_Category on tbl_Items.item_Category = tbl_Category.category_ID and category_Name = '"+ "Meals" + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getItemByCategory(string id)
        {
            string select = "SELECT * FROM tbl_Items JOIN tbl_Category on tbl_Items.item_Category = tbl_Category.category_ID and category_ID = '" + id + "'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getOrders()
        {
            string select = "SELECT * FROM tbl_Orders WHERE order_Status = 0 OR order_Status = 1";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

        public DataTable getOrderDetails(string orderID)
        {
            string select = "SELECT * FROM tbl_OrderItems JOIN tbl_Orders ON tbl_Orders.order_ID = tbl_OrderItems.order_ID JOIN tbl_Items ON tbl_Items.item_ID = tbl_OrderItems.item_ID WHERE tbl_OrderItems.order_ID = '"+orderID+"'";
            SqlDataAdapter adapt = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }

    }
}
