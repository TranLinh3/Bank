using System;
using System.Collections.Generic;
using System.Text;
namespace MyCSharpApplication
{
    public class Customers
    {
        private string name;
        private int age;
        private List<BankAccount> accoints;
        public  void Customer(string name, int age,List<BankAccount> accouns)
        {
            this.name = name;
            this.age = age;
            this.accoints = new List<BankAccount>();
        }
    }
}
