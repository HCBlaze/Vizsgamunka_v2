using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas.Classes
{
    internal class Customer
    {
        public int Id { get; private set; }
        public string First_name { get; private set; }
        public string Last_name { get; private set; }
        public string Phone { get; private set; }



        public Customer()
        {

        }

        public Customer(int id, string fistname, string lastname, string phone)
        {
            this.Id = id;
            this.First_name = fistname;
            this.Last_name = lastname;
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

        public void setFirstname(string firstname)
        {
            First_name = _setFirstname(firstname);
        }

        private string _setFirstname(string firstname)
        {
            string _firstname;
            if (char.IsUpper(firstname.First()))
            {
                _firstname = firstname;
            }
            else
            {
                _firstname = firstname.ToUpper();
            }

            return _firstname;
        }

        public void setLastname(string lastname)
        {
            Last_name = _setLastname(lastname);
        }
        private string _setLastname(string lastname)
        {
            string _lastname;
            if (char.IsUpper(lastname.First()))
            {
                _lastname = lastname;
            }
            else
            {
                _lastname = lastname.ToUpper();
            }

            return _lastname;
        }

        public void setPhoneNumber(string number)
        {
            Phone = _setPhoneNumber(number);
        }

        private string _setPhoneNumber(string number)
        {
            string _number;
            if(number.StartsWith("+36") && number.Length >= 12)
            {
                _number= number;
            }
            else
            {
                _number = MessageBox.Show("Nem jó a formátum vagy kevés a karakter!").ToString();
            }
            return _number;
        }
    }
}
