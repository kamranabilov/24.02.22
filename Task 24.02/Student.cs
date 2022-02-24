using System;
using System.Collections.Generic;
using System.Text;

namespace Task_24._02
{
    class Student
    {
        public string Fullname;
        public string GroupNo;
        static int Age;

        public Student(string fullname, string groupno, int age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }

       

        public string groupNo
        {
            get { return groupNo; }
            set
            {
                while (CheckGroupNo(value))
                {
                    Console.WriteLine("correct groupno enter");
                    value = Console.ReadLine();
                }
                groupNo = value;
            }
        }

        public static bool CheckGroupNo(string groupno)
        {
            if (groupno.Length == 3 && char.IsUpper(groupno[0]))
            {
                for (int i = 0; i < groupno.Length; i++)
                {
                    if (char.IsDigit(groupno[i]))
                        return false;

                }
                return true;
            }
            return false;
        }       
        public string fullname
        {
            get { return fullname; }
            set
            {
                while (CheckFullname(value))
                {
                    Console.WriteLine("correct name and surname enter");
                    value = Console.ReadLine();
                }
                fullname = value;
            }
        }
        public static bool CheckFullname(string fullname)
        {
            return fullname.Split(' ').Length >= 2; 
        }
        
    }
}


        
      
    

