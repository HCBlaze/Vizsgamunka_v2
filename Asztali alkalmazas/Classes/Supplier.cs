using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas.Classes
{
    internal class Supplier
    {
        public int Id { get; private set; }
        public string CompanyName { get; private set; }
        public string ContactName { get; private set; }
        public string City { get; private set; }
        public string Phone { get; private set; }



        public Supplier()
        {

        }

        public Supplier(int id, string companyname, string contactname,string city, string phone)
        {
            this.Id = id;
            this.CompanyName = companyname;
            this.ContactName = contactname;
            this.City= city;
            this.Phone = phone;
        }
        public void setId(int id)
        {
            Id = _setID(id);
        }
        private int _setID(int i)
        {
            int _id = i;
            return _id;
        }

        public void setCompanyName(string companyname)
        {
            CompanyName = _setCompanyName(companyname);
        }

        private string _setCompanyName(string companyname)
        {
            return companyname;
        }

        public void setContactName(string contactname)
        {
            ContactName = _setContactName(contactname);
        }
        private string _setContactName(string contactname)
        {
            string _contactname;

            if (char.IsUpper(contactname.First()))
            {
                _contactname = contactname;
            }
            else
            {
                _contactname = contactname.ToUpper();
            }

            return _contactname;
        }

        public void setCity(string city)
        {
            City= _setCity(city);
        }

        private string _setCity(string city)
        {
            string _city;
            if (char.IsUpper(city.First()))
            {
                _city= city;
            }
            else
            {
                _city= city.ToUpper();
            }
            return _city;
        }

        public void setPhoneNumber(string number)
        {
            Phone = _setPhoneNumber(number);
        }

        private string _setPhoneNumber(string number)
        {
            string _number;
            if (number.StartsWith("+36") && number.Length == 12)
            {
                _number = number;
            }
            else
            {
                _number = MessageBox.Show("Nem jó a formátum vagy kevés a karakter!").ToString();
            }
            return _number;
        }
    }
}
