using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEEE_Task2.Crud
{
    internal class userDetails
    {
        public string Name;
        public string phoneNum;
        public string Email;

        public void printDetails()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Phone Number : " + phoneNum);
        }
    }
}
