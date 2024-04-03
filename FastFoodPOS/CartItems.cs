using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodPOS
{
    internal class CartItems
    {
        private string _Name;
        private string _ID;
        private string _Description;
        private string _Price;
        private Image _Image;
        private string _quan;

        public CartItems(string name, string ID, string description, string price, Image img, string quantity) 
        { 
            this._Name = name;
            this._ID = ID;  
            this._Description = description;
            this._Price = price;
            this._Image = img;
            this._quan = quantity;
        }

        #region Getters
        public string Name
        {
            get { return _Name; }
        }

        public string ID
        {
            get { return _ID; }
        }

        public string Description
        {
            get { return _Description; }
        }

        public string Price
        {
            get { return _Price; }
        }

        public Image Image
        {
            get { return _Image; }
        }

        public string Quantity
        {
            get { return _quan; }
        }
        #endregion

        public override string ToString()
        {
            return $"Name: {Name}, ID: {ID}, Description: {Description}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}
