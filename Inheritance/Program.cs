using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Loan
    {
        public int LoanNumber { get; set; }
        public string LastName { get; set; }
        public double LoanAmount { get; set; }
    }

    class CarLoan : Loan
    {
        public int Year { get; set; }
        public string Make { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Loan aLoan = new Loan();
            CarLoan aCarLoan = new CarLoan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchel";
            aLoan.LoanAmount = 1000.00;
            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;


            Console.WriteLine("Loan #{0} for {1} is for {2}", aLoan.LoanNumber, aLoan.LastName, aLoan.LoanAmount.ToString("C2"));

            Console.WriteLine("Loan #{0} for {1} is for {2}", aCarLoan.LoanNumber, aCarLoan.LastName, aCarLoan.LoanAmount);
            Console.WriteLine("     Loan #{0} is for a {1} {2}", aCarLoan.LoanNumber, aCarLoan.Year, aCarLoan.Make);


            Console.ReadLine();
        }
    }
}
