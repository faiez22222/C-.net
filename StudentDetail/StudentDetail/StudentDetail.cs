using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetail
{
    internal class StudentDetail
    {
        public static void main()
        {
            Console.WriteLine("Kindly Provide the student details: \r\n");
            Console.WriteLine("Enter First Name");
            String first_name= Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            String last_name= Console.ReadLine(); 
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ender Address1");
            String address1 = Console.ReadLine();   
            Console.WriteLine("Enter Address2");
            String address2 = Console.ReadLine();
            Console.WriteLine("Enter City");
            String city = Console.ReadLine();
            Console.WriteLine("Enter State");
            String state = Console.ReadLine();
            Console.WriteLine("Enter EmailID");
            String email = Console.ReadLine();
            Console.WriteLine("Enter Contact Information");
            long phone_no = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Gender");
            String gender = Console.ReadLine();

            Console.WriteLine("*************************************************************");

            Console.WriteLine("Student detail entered by you is : ");
            Console.WriteLine("First Name: "+ first_name);
            Console.WriteLine("Last Name : "+last_name );
            Console.WriteLine("Age: "+ age);
            Console.WriteLine("Address1: "+address1);
            Console.WriteLine("Adress2: "+address2);
            Console.WriteLine("City: "+city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Contact Number: " + phone_no);
            Console.WriteLine("gender: " + gender);

        }
    }
}
