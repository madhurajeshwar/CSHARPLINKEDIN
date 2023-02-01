using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class School
    {
        public String name { get; set; }
        public String address { get; set; }

        public String phoneNumber { get; set; }
        public String city {get; set; }
        public String state { get; set; }
 
        public String zip { get; set; }

        private string _twitterUserName;
        public string twitterUserName
        {
            get { return _twitterUserName; }
            set
            {   if (value.StartsWith("@"))
                {
                    _twitterUserName = value;
                }
                else
                {
                    Console.WriteLine("I am "+value);
                    throw new Exception("Twitter address entered is invalid");
                }
            }
        }

        public School()
        {
            name = "Untitled";
            phoneNumber ="4000000";
        }
        public School(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
            
        }

        //polymorphism
        // Static Methods 
        public static  float averageThreeScores(float a,float b,float c)
        {
            return (a + b + c)/ 3;
        }
        public static int averageThreeScores(int a ,int b ,int c)
        {
            return (a + b + c) / 3;
        }

        //Function Bodied Expressions 
        //public float averageThreeScores(float a ,float b , float c) => (a+b+c)/3;

        //Overriding toString()
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(name);
            sb.AppendLine(address);
            sb.AppendLine(city);
            sb.Append(",");
            sb.Append(state);
            sb.Append(",");
            sb.Append(zip);
            return sb.ToString();
        }

    }
}
