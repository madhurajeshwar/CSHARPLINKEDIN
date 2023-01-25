using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class School
    {
        String name { get; set; }
        String address { get; set; }
        String city {get; set; }
        String state { get; set; }

        String zip { get; set; }

        string _twitterUserName;
        string twitterUserName
        {
            get { return _twitterUserName; }
            set
            {   if(value.StartsWith("@"))
                _twitterUserName = value;
                else
                {
                    throw new Exception("Twitter address entered is invalid");
                }
            }
        }


    }
}
