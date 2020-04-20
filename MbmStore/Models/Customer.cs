﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        private DateTime Birthdate;

        public int CustomerId { get; set; }
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        // read only property


        // property that validates input (the set accessor)


        // read only property
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthdate.Year;
                if (now.Month < birthdate.Month ||
                    (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<Phone> PhoneNumbers { get; set; }

        // cunstructor
        public Customer() { }
        
        public Customer(int customerId, string firstnavn, string lastnavn, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstnavn;
            Lastname = lastnavn;
            Address = address;
            Zip = zip;
            City = city;
        }

        // method
        public void AddPhone(Phone phone)
        {
            PhoneNumbers.Add(phone);
        }

    }
}