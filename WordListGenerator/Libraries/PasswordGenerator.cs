using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WordListGenerator.Libraries
{
    class PasswordGenerator
    {

        private bool checkLowerCase=false;
        private bool checkUpperCase=false;
        private bool checkNumbers = false;
        private bool checkSymbols = false;
        private bool checkCustomCharset = false;
        private bool checkAppends = false;
        private bool checkPasswordSequence = false;
        private bool checkAllowSpaceChar = false;
        private string customCharset;
        private string appends;
        private string passwordSequense;

        public bool CheckLowerCase { get => checkLowerCase; set => checkLowerCase = value; }
        public bool CheckUpperCase { get => checkUpperCase; set => checkUpperCase = value; }
        public bool CheckNumbers { get => checkNumbers; set => checkNumbers = value; }
        public bool CheckSymbols { get => checkSymbols; set => checkSymbols = value; }
        public bool CheckCustomCharset { get => checkCustomCharset; set => checkCustomCharset = value; }
        public bool CheckAppends { get => checkAppends; set => checkAppends = value; }
        public bool CheckPasswordSequence { get => checkPasswordSequence; set => checkPasswordSequence = value; }
        public bool CheckAllowSpaceChar { get => checkAllowSpaceChar; set => checkAllowSpaceChar = value; }
        public string CustomCharset { get => customCharset; set => customCharset = value; }
        public string Appends { get => appends; set => appends = value; }
        public string PasswordSequense { get => passwordSequense; set => passwordSequense = value; }
        public LangugeHelper langugeHelper;

        public PasswordGenerator()
        {
            langugeHelper = new LangugeHelper();
        }
       
        
        public string PasswordGenerateWithSequence(string passwordMask) 
        {
            string password = "";
                 Random rnd = new Random();           
                int index = 0;
                for (int i = 0; i < passwordMask.Length; i++)
                { 
                    if (passwordMask[i].Equals('+'))
                    {
                        index = rnd.Next(Charsets.lowerCase.Length);
                    password = password + Charsets.lowerCase[index];
                        password.Append(Charsets.lowerCase[index]);
                    }
                    else if (passwordMask[i].Equals('*'))
                    {
                        index = rnd.Next(Charsets.upperCase.Length);
                    password = password + Charsets.upperCase[index];
                    }else if (passwordMask[i].Equals('#')) 
                    {
                     index = rnd.Next(Charsets.numbers.Length);
                    password = password + Charsets.numbers[index];
                    }   
                }  
            return password.ToString();
        }

        public string PasswordGenerate(int passwordLength)
        {
            string charset = "";
            
            if (CheckCustomCharset)
                charset += CustomCharset;
            if (CheckLowerCase)
                charset += Charsets.lowerCase;
            if (CheckUpperCase)
                charset += Charsets.upperCase;
            if (CheckNumbers)
                charset += Charsets.numbers;
            if (CheckSymbols)
                charset += Charsets.Symbols;

           

            if (CheckAppends) { 
                    if (Appends.Length > 0)
                    {
                        if (Appends.Contains('%'))
                        {
                        passwordLength = (passwordLength - Appends.Length);
                    }
                        else
                        {
                            MessageBox.Show(langugeHelper.Read("append_error_type", "generator"));
                        }
                        
                    }
               }
           
         
                Random rnd = new Random();
               string password = "";
           
            int index = 0;
                for (int i = 0; i < passwordLength; i++)
                {
                   
                        index = rnd.Next(charset.Length);
                        password=password+charset[index];                   
                  
                }
                
                if (CheckAppends)
                {


                    if (Appends.Contains('%'))
                    {
                        if (Appends.IndexOf('%') == 0)
                        {
                        password = password + Appends.Trim('%');                        
                        }
                        else if (Appends.IndexOf('%') == Appends.Length-1)
                        {
                        password = Appends.Trim('%') + password; 
                        }
                    }

                }
                
           
            return password;
            }
    }
}
