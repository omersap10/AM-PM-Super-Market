using System;
using System.Collections.Generic;
using System.Text;

namespace AMPM.PROJECT
{
    public class Customer
    {
        private string name;
        private string address;
        private string phone_number;
        public Customer()
        {
            this.name = null;
            this.address = null;
            this.phone_number = null;
        }
        public Customer(string name, string address, string phone)
        {
            this.address = address;
            this.name = name;
            this.phone_number = phone;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return this.address;
        }

        public void setPhone_number(string phone)
        {
            this.phone_number = phone;
        }
        public string getPhone_number()
        {
            return this.phone_number;
        }

    }

   
}
