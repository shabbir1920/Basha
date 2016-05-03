using OceanicFinanceBank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OceanicFinanceBank.DAL
{
    public class OceanicInitializer:  DropCreateDatabaseIfModelChanges<OceanicContext>//DropCreateDatabaseAlways<OceanicContext>  
    {
        protected override void Seed(OceanicContext context)
        {
            //Create dummy customers
           var customers = new List<Customer>
           {
               new Customer {ID=1,FirstName="Johon",LastName="Doe",SSN="1234567890",BirthDate=DateTime.Parse("1/2/2001"),Address="11 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male"},
               new Customer {ID=2,FirstName="asdf",LastName="Doe",SSN="1334567890",BirthDate=DateTime.Parse("1/3/2001"),Address="12 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=3,FirstName="fdsa",LastName="Doe",SSN="1244567890",BirthDate=DateTime.Parse("1/4/2001"),Address="13 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=4,FirstName="sasha",LastName="Doe",SSN="1235567890",BirthDate=DateTime.Parse("1/5/2001"),Address="14 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=5,FirstName="ahsas",LastName="Doe",SSN="1234667890",BirthDate=DateTime.Parse("1/6/2001"),Address="15 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=6,FirstName="qwer",LastName="Doe",SSN="1234577890",BirthDate=DateTime.Parse("1/7/2001"),Address="16 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=7,FirstName="rewq",LastName="Doe",SSN="1234568890",BirthDate=DateTime.Parse("1/8/2001"),Address="17 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=8,FirstName="poiu",LastName="Doe",SSN="1234567990",BirthDate=DateTime.Parse("1/9/2001"),Address="18 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=9,FirstName="uiop",LastName="Doe",SSN="2234567890",BirthDate=DateTime.Parse("1/10/2001"),Address="19 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=10,FirstName="abcd",LastName="Doe",SSN="3234567890",BirthDate=DateTime.Parse("1/11/2001"),Address="20 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=11,FirstName="dcba",LastName="Doe",SSN="4234567890",BirthDate=DateTime.Parse("1/12/2001"),Address="21 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=12,FirstName="jdbc",LastName="Doe",SSN="5234567890",BirthDate=DateTime.Parse("1/13/2001"),Address="22 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=13,FirstName="cbdj",LastName="Doe",SSN="6234567890",BirthDate=DateTime.Parse("1/14/2001"),Address="23 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=14,FirstName="lkjh",LastName="Doe",SSN="7234567890",BirthDate=DateTime.Parse("1/15/2001"),Address="24 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=15,FirstName="hjkl",LastName="Doe",SSN="8234567890",BirthDate=DateTime.Parse("1/16/2001"),Address="25 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=16,FirstName="alysa",LastName="Doe",SSN="9234567890",BirthDate=DateTime.Parse("1/17/2001"),Address="26 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=17,FirstName="asyla",LastName="Doe",SSN="3234567890",BirthDate=DateTime.Parse("1/18/2001"),Address="27 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=18,FirstName="anna",LastName="Doe",SSN="3334567890",BirthDate=DateTime.Parse("1/19/2001"),Address="28 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=19,FirstName="lenovo",LastName="Doe",SSN="3434567890",BirthDate=DateTime.Parse("1/20/2001"),Address="29 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=20,FirstName="logitech",LastName="Doe",SSN="3534567890",BirthDate=DateTime.Parse("1/21/2001"),Address="30 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=21,FirstName="modera",LastName="Doe",SSN="3634567890",BirthDate=DateTime.Parse("1/22/2001"),Address="31 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=22,FirstName="benz",LastName="Doe",SSN="3734567890",BirthDate=DateTime.Parse("1/23/2001"),Address="32 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=23,FirstName="altima",LastName="Doe",SSN="3834567890",BirthDate=DateTime.Parse("1/24/2001"),Address="33 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=24,FirstName="scion",LastName="Doe",SSN="3934567890",BirthDate=DateTime.Parse("1/25/2001"),Address="34 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=25,FirstName="pilot",LastName="Doe",SSN="4034567890",BirthDate=DateTime.Parse("1/26/2001"),Address="35 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=26,FirstName="sachin",LastName="Doe",SSN="4134567890",BirthDate=DateTime.Parse("1/27/2001"),Address="36 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=27,FirstName="afridi",LastName="Doe",SSN="4234567890",BirthDate=DateTime.Parse("1/28/2001"),Address="37 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=28,FirstName="bhutto",LastName="Doe",SSN="4334567890",BirthDate=DateTime.Parse("2/2/2001"),Address="38 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=29,FirstName="fateh",LastName="Doe",SSN="4434567890",BirthDate=DateTime.Parse("3/2/2001"),Address="39 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=30,FirstName="hossain",LastName="Doe",SSN="4534567890",BirthDate=DateTime.Parse("4/2/2001"),Address="40 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=31,FirstName="lawrence",LastName="Doe",SSN="4634567890",BirthDate=DateTime.Parse("5/2/2001"),Address="41 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=32,FirstName="eswar",LastName="Doe",SSN="4734567890",BirthDate=DateTime.Parse("6/2/2001"),Address="42 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=33,FirstName="ravi",LastName="Doe",SSN="4834567890",BirthDate=DateTime.Parse("7/2/2001"),Address="43 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=34,FirstName="ankur",LastName="Doe",SSN="4934567890",BirthDate=DateTime.Parse("8/2/2001"),Address="44 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=35,FirstName="shabbir",LastName="Doe",SSN="5034567890",BirthDate=DateTime.Parse("9/2/2001"),Address="45 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=36,FirstName="Ibrahim",LastName="Doe",SSN="5134567890",BirthDate=DateTime.Parse("10/2/2001"),Address="46 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=37,FirstName="gundeep",LastName="Doe",SSN="5234567890",BirthDate=DateTime.Parse("11/2/2001"),Address="47 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=38,FirstName="root",LastName="Doe",SSN="5334567890",BirthDate=DateTime.Parse("12/2/2001"),Address="48 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=39,FirstName="flintoff",LastName="Doe",SSN="5434567890",BirthDate=DateTime.Parse("6/18/2001"),Address="49 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=40,FirstName="warner",LastName="Doe",SSN="5534567890",BirthDate=DateTime.Parse("7/19/2001"),Address="50 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=41,FirstName="watson",LastName="Doe",SSN="5634567890",BirthDate=DateTime.Parse("8/20/2001"),Address="51 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=42,FirstName="dekock",LastName="Doe",SSN="5734567890",BirthDate=DateTime.Parse("8/21/2001"),Address="52 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=43,FirstName="waseem",LastName="Doe",SSN="5834567890",BirthDate=DateTime.Parse("8/22/2001"),Address="53 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=44,FirstName="dell",LastName="Doe",SSN="5934567890",BirthDate=DateTime.Parse("8/23/2001"),Address="54 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
               new Customer {ID=45,FirstName="razeen",LastName="Doe",SSN="6034567890",BirthDate=DateTime.Parse("8/24/2001"),Address="55 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Female" },
               new Customer {ID=46,FirstName="sameen",LastName="Doe",SSN="6134567890",BirthDate=DateTime.Parse("8/25/2001"),Address="56 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Female" },
               new Customer {ID=47,FirstName="najia",LastName="Doe",SSN="6234567890",BirthDate=DateTime.Parse("8/26/2001"),Address="57 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Female" },
               new Customer {ID=48,FirstName="maria",LastName="Doe",SSN="6334567890",BirthDate=DateTime.Parse("8/27/2001"),Address="58 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Female" },
               new Customer {ID=49,FirstName="fatima",LastName="Doe",SSN="6434567890",BirthDate=DateTime.Parse("8/28/2001"),Address="59 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Female" },
               new Customer {ID=50,FirstName="Iftikar",LastName="Doe",SSN="6534567890",BirthDate=DateTime.Parse("8/29/2001"),Address="60 Leesburg pike",City="Fallschurch",Country="USA",Zip="11123",Email="email@email.com",Gender="Male" },
           };
            
            //Add to the customers DB Set
            customers.ForEach(s => context.Customers.Add(s));

            //Save to the database
            context.SaveChanges();

            var applicaltions = new List<LoanApplication>
            {
                new LoanApplication() {ID=1,LoanAmount=1.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=1 },
                new LoanApplication() {ID=2,LoanAmount=2.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=2 },
                new LoanApplication() {ID=3,LoanAmount=3.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=3 },
                new LoanApplication() {ID=4,LoanAmount=4.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=4 },
                new LoanApplication() {ID=5,LoanAmount=5.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=5 },
                new LoanApplication() {ID=6,LoanAmount=6.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=6 },
                new LoanApplication() {ID=7,LoanAmount=7.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=7 },
                new LoanApplication() {ID=8,LoanAmount=8.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=8 },
                new LoanApplication() {ID=9,LoanAmount=9.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=9 },
                new LoanApplication() {ID=10,LoanAmount=10.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=10 },
                new LoanApplication() {ID=11,LoanAmount=11.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=11 },
                new LoanApplication() {ID=12,LoanAmount=12.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=12 },
                new LoanApplication() {ID=13,LoanAmount=13.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=13 },
                new LoanApplication() {ID=14,LoanAmount=14.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=14 },
                new LoanApplication() {ID=15,LoanAmount=15.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=15 },
                new LoanApplication() {ID=16,LoanAmount=16.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=16 },
                new LoanApplication() {ID=17,LoanAmount=17.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=17 },
                new LoanApplication() {ID=18,LoanAmount=18.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=18 },
                new LoanApplication() {ID=19,LoanAmount=19.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=19 },
                new LoanApplication() {ID=20,LoanAmount=20.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=20 },
                new LoanApplication() {ID=21,LoanAmount=21.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=21 },
                new LoanApplication() {ID=22,LoanAmount=22.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=22 },
                new LoanApplication() {ID=23,LoanAmount=23.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=23 },
                new LoanApplication() {ID=24,LoanAmount=24.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=24 },
                new LoanApplication() {ID=25,LoanAmount=25.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=25 },
                new LoanApplication() {ID=26,LoanAmount=26.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=26 },
                new LoanApplication() {ID=27,LoanAmount=27.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=27 },
                new LoanApplication() {ID=28,LoanAmount=28.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=28 },
                new LoanApplication() {ID=29,LoanAmount=29.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=29 },
                new LoanApplication() {ID=30,LoanAmount=30.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=30 },
                new LoanApplication() {ID=31,LoanAmount=31.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=31 },
                new LoanApplication() {ID=32,LoanAmount=32.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=32 },
                new LoanApplication() {ID=33,LoanAmount=33.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=33 },
                new LoanApplication() {ID=34,LoanAmount=34.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=34 },
                new LoanApplication() {ID=35,LoanAmount=35.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=35 },
                new LoanApplication() {ID=36,LoanAmount=36.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=36 },
                new LoanApplication() {ID=37,LoanAmount=37.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=37 },
                new LoanApplication() {ID=38,LoanAmount=38.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=38 },
                new LoanApplication() {ID=39,LoanAmount=39.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=39 },
                new LoanApplication() {ID=40,LoanAmount=40.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=40 },
                new LoanApplication() {ID=41,LoanAmount=41.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=41 },
                new LoanApplication() {ID=42,LoanAmount=42.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=42 },
                new LoanApplication() {ID=43,LoanAmount=43.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=43 },
                new LoanApplication() {ID=44,LoanAmount=44.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=44 },
                new LoanApplication() {ID=45,LoanAmount=45.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=45 },
                new LoanApplication() {ID=46,LoanAmount=46.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=46 },
                new LoanApplication() {ID=47,LoanAmount=47.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=47 },
                new LoanApplication() {ID=48,LoanAmount=48.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=48 },
                new LoanApplication() {ID=49,LoanAmount=49.00,LoanApplicationType=LoanType.Personal,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Denied,ApplicantId=49 },
                new LoanApplication() {ID=50,LoanAmount=50.00,LoanApplicationType=LoanType.Business,ApplicationDate=DateTime.Now,ApplicationStatus=Status.Applied,ApplicantId=50 }
            };

            //Add to the customers dbset
            applicaltions.ForEach(s => context.LoanApplications.Add(s));

            //Save to the database
            context.SaveChanges();
        }

        
    }
}