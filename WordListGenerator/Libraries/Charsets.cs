using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordListGenerator.Libraries
{
 public  static  class Charsets
    {
        
        public   const  string lowerCase= "abcdefghijklmnopqrstuvwxyz";
        public   const  string upperCase= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public   const  string numbers= "0123456789";
        private const string symbols = "!@#$%^&*()_-+={}[];':|,.<>/?~";

        public static string Symbols => symbols;
    }
}
