using System;
using System.ComponentModel.DataAnnotations;

namespace Class_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];

            int input;
            do
            {
                Console.WriteLine("1. Butun telebelere bax.");
                Console.WriteLine("2. Telebeler uzre axtaris et.");
                Console.WriteLine("3. Telebe elave et.");
                Console.WriteLine("0. Menu-dan cixis.");
                Console.Write("Secim edin --> ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 0:
                        input = -1;
                        Console.WriteLine("Eminsiniz mi? Yes/No");
                        if (Console.ReadLine() == "Yes")
                        {
                            input = 0;
                        }
                        break;
                    case 1:
                        foreach (var item in students)
                        {
                            Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Telebe uzre axtaris deyeri daxil edin...");
                        string wantedInformation = Console.ReadLine();
                        foreach (var item in students)
                        {
                            if (item.FullName.Contains(wantedInformation) || item.GroupNo.Contains(wantedInformation))
                            {
                                Console.WriteLine($"FullName: {item.FullName} - GroupNo: {item.GroupNo}");
                            }
                        }
                        break;
                    case 3:
                        string fullName;
                        int count1 = 0;
                        do
                        {
                            if (count1==0)
                            {
                                Console.WriteLine("FullName daxil edin...");
                                fullName = Console.ReadLine();
                                count1++;
                                
                            }
                            else
                            {
                                Console.WriteLine("FullName daxil edin.(Ilk herfi boyuk, diger herfleri kicik ad ve soyaddan ibaret olmalidir)");
                                fullName = Console.ReadLine();
                            }

                        } while (!CorrectFullName(fullName));

                        string groupNo;
                        int count2 = 0;
                        do
                        {
                            if (count2==0)
                            {
                                Console.WriteLine("GroupNo daxil edin...");
                                groupNo = Console.ReadLine();
                                count2++;
                            }
                            else
                            {
                                Console.WriteLine("GroupNo daxil edin.(Bir boyuk herf ve 3 reqemden ibaret olmalidir)");
                                groupNo = Console.ReadLine();
                            }

                        } while (!CorrectGroupNo(groupNo));

                        Student student = new Student
                        {
                            FullName = fullName,
                            GroupNo = groupNo
                        };

                        if (Array.IndexOf(students, student) == -1)
                        {
                            Array.Resize(ref students, students.Length + 1);
                            students[students.Length - 1] = student;
                        }
                        break;
                    default:
                        Console.WriteLine("Yanlis secim etdiniz, yeniden secim edin.");
                        break;
                }

            } while (input != 0);




        }
        static bool CorrectGroupNo(string grNo)
        {
            if (string.IsNullOrWhiteSpace(grNo))
            {
                return false;
            }
            if (grNo.Length != 4)
            {
                return false;
            }
            if (!Char.IsUpper(grNo[0]))
            {
                return false;
            }
            for (int i = 1; i < grNo.Length; i++)
            {
                if (!Char.IsDigit(grNo[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CorrectFullName(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }
            string[] newFullName = fullname.Split(' ');
            if (newFullName.Length != 2)
            {
                return false;
            }
            if (!(Char.IsUpper(newFullName[0][0]) && Char.IsUpper(newFullName[1][0])))
            {
                return false;
            }
            for (int i = 0; i < newFullName.Length; i++)
            {
                for (int j = 1; j < newFullName[i].Length; j++)
                {
                    if (!Char.IsLower(newFullName[i][j]))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
