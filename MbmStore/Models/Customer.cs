using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        // fields
       private string firstname;
       private string lastname;
       private int age;
       private string address;
       private string zip;
       private string city;
       private DateTime birthDate;
       List<string> phoneNumbers = new List<string>();
       List<Invoice> invoices = new List<Invoice>();
       

        // properties
        // Auto implemented property, in this case I won't need private string image url.
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }

        public List<string> PhoneNumbers {
            get { return phoneNumbers; }
        }

        public List<Invoice> Invoices
        {
            get { return invoices; }
        }


        public int Age{

            get {
                // The get block of Age property 
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthDate.Year;
                // calculate to see if the customer hasn’t had birthday yet 
                // subtract one year if the statement is true
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                // Otherwise return value age
                return age;
            }
        }

    
    
        public DateTime BirthDate
        {
            set
            {
                // Calculate If the value is greater then 120 or below 0.
                birthDate = value;
                if ((DateTime.Now.Year - value.Year) > 120 || (DateTime.Now.Year - value.Year) < 0) 
                {
                    // Throw expeption, if the statement is true
                    // Otherwise return value
                    throw new Exception("Age not accepted");
                }
            }
            get {
                return birthDate;
            }
        }




        // Constructor
        // Used for creating the Customer objects

        public Customer(string firstname, string lastname, string address, string zip, string city)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address= address;
            this.Zip = zip;
            this.City = city;
        }
        // Void method helps adding objects to a list.
        public void addPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        // Void method helps adding objects to a list. 
        public void addInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

    }

    }




