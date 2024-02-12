// Name: Manu Sugunakumar
// Date: November 13, 2023
// Class Name: Services
// Desc: Makes service summary objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A3
{
    internal class Service
    {
        // Variables
        private static int serviceCount = 0;

        protected int identificationNumber;
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected string make;
        protected string model;
        protected string colour;
        protected int year;
        protected Boolean engOilChange;
        protected Boolean transOilChange;
        protected Boolean airFilterChange;
        protected string date;
        protected decimal price;

        // Default Constructor
        public Service() 
        { 
            serviceCount++;
            identificationNumber = serviceCount;
        }

        // Constructor for adding new car service summary
        public Service(string firstName, string lastName, string phoneNumber, string make, string model, string colour, int year, Boolean engOilChange, Boolean transOilChange, Boolean airFilterChange, string date, decimal price) 
        {
            Service service = new Service();
            identificationNumber = service.identificationNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;
            this.engOilChange = engOilChange;
            this.transOilChange = transOilChange;
            this.airFilterChange = airFilterChange;
            this.date = date;
            this.price = price;
        }

        // Constructor for updating car service summary
        public Service(int identificationNumber, string firstName, string lastName, string phoneNumber, string make, string model, string colour, int year, Boolean engOilChange, Boolean transOilChange, Boolean airFilterChange, string date, decimal price)
        {
            this.identificationNumber = identificationNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;
            this.engOilChange = engOilChange;
            this.transOilChange = transOilChange;
            this.airFilterChange = airFilterChange;
            this.date = date;
            this.price = price;
        }

        // Attribute get/set
        public int IdentificationNumber { get { return identificationNumber; } set { identificationNumber = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set {  phoneNumber = value; } }
        public string Make { get { return make; } set {  make = value; } }
        public string Model { get { return model; } set {  model = value; } }
        public string Colour { get { return colour; } set {  colour = value; } }
        public int Year { get { return year; } set { year = value; } }
        public Boolean EngOilChange { get { return engOilChange; } set { engOilChange = value; } }
        public Boolean TransOilChange { get { return transOilChange; } set {  transOilChange = value; } }
        public Boolean AirFilterChange { get { return airFilterChange; } set {  airFilterChange = value; } }
        public string Date { get { return date; } set {  date = value; } }
        public decimal Price { get { return price; } set {  price = value; } }

        // Gets all the service data and outputs it on one line of string
        public string GetServiceData()
        {
            return identificationNumber.ToString() + "," + firstName + "," + lastName + "," + phoneNumber + "," + make + "," + model + "," + colour + "," + year + "," + engOilChange.ToString() + "," + transOilChange.ToString() + "," + airFilterChange.ToString() + "," + date + "," + price.ToString();
        }
    }
}
