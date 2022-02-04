﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class UserRegistration
    {
        //Declaring Constant Variables for Patterns
        public const string FIRST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string LAST_NAME = "^[A-Z][a-zA-Z]{2}";
        public const string EMAIL = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public const string MOBILE_NO = "^([9][1])+[ ]+[6789]{1}[0-9]{9}$";
        public const string PASSWORD = "^[a-z]{8}";

        //Method to check First Name
        public void ValidateFName(string fName)
        {
            //using regex constructor and assigning pattern.
            Regex regex = new Regex(FIRST_NAME);

            if (regex.IsMatch(fName))
            {
                Console.WriteLine("first name is matched with pattern");
            }
            else
            {
                Console.WriteLine("first name does not match with pattern");
            }
        }
        //Method to check Last Name
        public void ValidateLName(string lName)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(LAST_NAME);

            if (regex.IsMatch(lName))
            {
                Console.WriteLine("Last name is matched with pattern");
            }
            else
            {
                Console.WriteLine("Last name does not match with pattern");
            }
        }
        //Method to check Email id
        public void ValidateEmail(string emailId)
        {
            ///using regex constructor and assigning pattern
            Regex regex = new Regex(EMAIL);

            if (regex.IsMatch(emailId))
            {
                Console.WriteLine("Email is matched with pattern");
            }
            else
            {
                Console.WriteLine("Email not matched with pattern");
            }
        }
        //Method to check Mobile number
        public void ValidateMobileNumber(string monum)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(MOBILE_NO);

            if (regex.IsMatch(monum))
            {
                Console.WriteLine("Mobile Number is matched with pattern");
            }
            else
            {
                Console.WriteLine("Mobile Number not matched with pattern");
            }
        }
        //method to check password
        public void ValidatePassword(string password)
        {
            //using regex constructor and assigning pattern
            Regex regex = new Regex(PASSWORD);

            if (regex.IsMatch(password))
            {
                Console.WriteLine("PassWord is matched with pattern");
            }
            else
            {
                Console.WriteLine("PassWord not matched with pattern");
            }
        }
    
    }
}

