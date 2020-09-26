using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDrugScreens
{
    class Employee
    {
        public Employee()
        {

        }
        /*public Employee(string id)
        {
            id = ID;
        }
        public Employee(string id, DateTime drugtestdatelast)
        {
            id = ID;
            drugtestdatelast = DrugTestDateLast;
        }
        public Employee(string id, string lastname, DateTime drugtestdatelast)
        {
            lastname = LastName;
            drugtestdatelast = DrugTestDateLast;
        }
        public Employee(string id, string firstname, string lastname, DateTime drugtestdatelast)
        {
            id = ID;
            firstname = FirstName;
            lastname = LastName;
            drugtestdatelast = DrugTestDateLast;
        }
        public Employee(string id, string firstname, string middleinitial, string lastname, DateTime drugtestdatelast)
        {
            id = ID;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            drugtestdatelast = DrugTestDateLast;
        }*/
        public Employee(string id)
        {
            id = ID;
        }
        public Employee(string id, string nameprefix)
        {
            id = ID;
            nameprefix = NamePrefix;
        }
        public Employee(string id, string nameprefix, string firstname)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email, DateTime dateofbirth)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county, string city)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
            city = City;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county, string city, string state)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
            city = City;
            state = State;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county, string city,string state, string zipcode)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
            city = City;
            state = State;
            zipcode = ZipCode;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county, string city,string state, string zipcode, string username)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
            city = City;
            state = State;
            zipcode = ZipCode;
            username = UserName;
        }
        public Employee(string id, string nameprefix, string firstname, string middleinitial, string lastname, string gender, 
            DateTime drugtestdatelast, string email,DateTime dateofbirth, DateTime datehired, int salary, int lastpayhike, 
            string ssn, string phonenumber, string county, string city,string state, string zipcode, string username, 
            string password)
        {
            id = ID;
            nameprefix = NamePrefix;
            firstname = FirstName;
            middleinitial = MiddleInitial;
            lastname = LastName;
            gender = Gender;
            drugtestdatelast = DrugTestDateLast;
            email = EMail;
            dateofbirth = DateOfBirth;
            datehired = DateHired;
            salary = Salary;
            lastpayhike = LastPayHike;
            ssn = SSN;
            phonenumber = PhoneNumber;
            county = County;
            city = City;
            state = State;
            zipcode = ZipCode;
            username = UserName;
            password = Password;
        }
        public string ID { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DrugTestDateLast { get; set; }
        public string EMail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateHired { get; set; }
        public int Salary { get; set; }
        public int LastPayHike { get; set; }
        public string SSN { get; set; }
        public string PhoneNumber { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string GetEmployee(string ID)
        {
            return ID;
        }
    }
}
