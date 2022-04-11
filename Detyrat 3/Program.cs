using System;

namespace Detyrat_3
{
    class Program
    {


        static void Main(string[] args)
        {
            //Ushtrimi 1

            //Krijoni nje program i cili i lejon perdoruesit te jape nje fjalekalim dhe kryen validimet e meposhtme:
            //verifikon nese permban nje karakter[A - Z]
            //verifikon nese permban nje karakter[a - z]
            //verifikon nese permban nje karakter[0 - 9]
            //verifikon nese permban nje karakter[~, !,@,#,$,%,^,&,*,(,),-,+] 
            //ne rast se nuk plotesohet ndonje prej kushteve te mesiperme,
            //te afishohet mesazhi perkates per mangesine qe mund te kete,
            //ne te kundert te afishohet mesazhi qe fjalekalimi eshte i sakte.


            //Console.WriteLine("Jepni fjalekalimin: ");
            //string fjalekalimi = Console.ReadLine();

            //if (fjalekalimi.ToLower() == fjalekalimi)
            //{
            //    Console.WriteLine("Nuk ka karakter te madh");
            //}
            //else
            //{
            //    Console.WriteLine("Ka karakter te madh");
            //}
            //if (fjalekalimi.ToUpper()== fjalekalimi)
            //{
            //    Console.WriteLine("Nuk ka karakter te vogel");
            //}
            //else
            //{
            //    Console.WriteLine("Ka karakter te vogel");
            //}
            //bool isNumber = false;

            //for (int i = 0; i < fjalekalimi.Length; i++)
            //{
            //    if (char.IsDigit(fjalekalimi[i]))
            //    {
            //        isNumber = true;
            //        break;
            //    }
            //}

            //if (isNumber)
            //{
            //    Console.WriteLine("Permban numer");
            //}
            //else
            //{
            //    Console.WriteLine("Nuk permban numer");
            //}

            //Ushtrimi 2
            //Te kerkohet nga perdoruesi te jape username / password.
            //Te verifikohet qe fjalekalimi nuk permban username(pa u ndikuar nga karakteret kapitale,, etj)

            //Console.WriteLine("Username:");
            //string username = Console.ReadLine();
            //Console.WriteLine("Password:");
            //string password = Console.ReadLine();

            //int index = password.ToLower().IndexOf(username.ToLower());
            //if (index == -1)
            //{
            //    Console.WriteLine("Nuk e permban");
            //}
            //else
            //    Console.WriteLine("E permban");

            //Ushtrimi 3
            //Te kerkohet nga perdoruesi te jepen 3 stringje te cfaredoshme, 
            //nese 2 stringjet e fundit te dhena nga perdoruesi, ndodhen ne te parin, 
            //atehere te zevendesohen ne stringun e pare:
            //psh: str1 = "Pranvera nuk vjen me nje lule"
            //str2 = "pranvera"
            //str3 = "lule"
            //Aplikacioni duhet te afishoje "lule nuk vjen me nje Pranvera"

            Console.WriteLine("Jepni 3 stringje:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();

            int index = str1.ToLower().IndexOf(str2.ToLower());   
            int index1 = str1.ToLower().IndexOf(str3.ToLower());

            if (index != -1 && index1 != -1)
            {

                string fjala = str1.Substring(0, index) + str2 +
                str1.Substring(index + str1.Length, index1 - index - str1.Length) +
                str1 + str1.Substring(index1 + str2.Length);
                Console.WriteLine(fjala);
            }
        }
    }
}
