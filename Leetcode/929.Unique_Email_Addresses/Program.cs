using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _929.Unique_Email_Addresses
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(NumUniqueEmailsHashSet(new string[]
            {
                "test.email+alex@leetcode.com",
                "test.e.mail+bob.cathy@leetcode.com",
                "testemail+david@lee.tcode.com"
            }));
        }

        // runtime: 128ms - faster than 89.32%
        public static int NumUniqueEmailsClass(string[] emails)
        {
            int counter = 0;
            List<Email> emailList = new List<Email>();
            foreach (string email in emails)
            {
                Email address = new Email(email);
                if (!emailList.Any(x => x.Local == address.Local && x.Domain == address.Domain)){
                    counter++;
                    emailList.Add(address);
                }
            }
            return counter;
        }   

        // runtime: 128ms - faster than 89.32%
        public static int NumUniqueEmailsHashSet(string[] emails)
        {
            HashSet<string> hashSet = new HashSet<string>(emails.Count());
            int counter = 0;
            foreach(string email in emails)
            {
                bool ignore = false;
                StringBuilder builder = new StringBuilder();
                for(int i = 0; i < email.Length; i++)
                {
                    char letter = email[i];
                    if(letter == '@')
                    {
                        builder.Append(email.Substring(i));
                        break;
                    }
                    if(letter == '+')
                    {
                        ignore = true;
                        continue;
                    }
                    if(letter == '.')
                    {
                        continue;
                    }
                    if (!ignore)
                    {
                        builder.Append(letter);
                    }
                }
                string address = builder.ToString();
                if(!hashSet.Contains(address))
                {
                    hashSet.Add(address);
                    counter++;
                }
            }
            return counter;
        }
    }
    class Email {
        public string Domain { get; set; }

        public string Local { get; set; }

        public Email(string email)
        {
            string[] splitEmail = email.Split('@');
            Domain = splitEmail[1];

            Local = splitEmail[0].Substring(0, splitEmail[0].IndexOf('+')).Replace(".", "");
        }
    }
}
