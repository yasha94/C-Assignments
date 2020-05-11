using ServiceStack.Host;
using System;
using System.Collections.Generic;

namespace assignment6
{
    //class holding cookie details
    class Cookie{
        private string isGluten;
        private int amoutOfEggs;
        private double amountOfFlour;

        public Cookie()
        {
        }

        public Cookie(string isGluten, int amountOfEggs, double amountOfFlour){
            this.isGluten = isGluten;
            this.amoutOfEggs = amountOfEggs;
            this.amountOfFlour = amountOfFlour;
        }
        /**************GETTERS AND SETTERS FOR PRIVTE ATRIBUTES****************/
        public string Gluten_getter_setter
        {
            get { return this.isGluten; }
            set { this.isGluten = value;}
        }
        public int Eggs_getter_setter
        {
            get { return this.amoutOfEggs; }
            set { this.amoutOfEggs = value; }
        }
        public double flour_getter_setter
        {
            get { return this.amountOfFlour; }
            set { this.amountOfFlour = value; }
        }

    }
    //the main class
    class Program
    {
        //func to print given Cookie class obj
        public static void printCookie(Cookie c)
        {
            //check if cookie in null
            if(c == null){
                Console.WriteLine("Coockie is empty");
            }
            //print's cookie
            else{
                Console.WriteLine(c.Gluten_getter_setter);
                Console.WriteLine(c.Eggs_getter_setter);
                Console.WriteLine(c.flour_getter_setter);
            }
        }
        //main func
        static void Main(string[] args)
        {
            //creating three objs of class Cookie and call fun print cookie
            Cookie cookie1 = new Cookie("yes" , 5, 7.2);
            Cookie cookie2 = new Cookie("no" , 3, 5.5);
            Cookie cookie3 = new Cookie("yes" , 9, 1.5);
            printCookie(cookie1);
            //takes input 3 times to set cookies new data
            for (int i = 0; i < 3; i++)
            {
                //asks for input to be stored in created objs
                Console.WriteLine("please enter cookie details-->[gluten(yes,no), eggs, flour]");
                string isGluten = Console.ReadLine();
                int eggs = Convert.ToInt32(Console.ReadLine());
                double flour = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("choose to which cookie to insert data");
                string chooseCookie = Console.ReadLine();
                //check if cookie 1
                if (chooseCookie.Equals("cookie1"))
                {

                    cookie1.Gluten_getter_setter = isGluten;

                    cookie1.Eggs_getter_setter = eggs;

                    cookie1.flour_getter_setter = flour;
                }
                //check if cookie2
                else if (chooseCookie.Equals("cookie2"))
                {
                    cookie2.Gluten_getter_setter = isGluten;

                    cookie2.Eggs_getter_setter = eggs;

                    cookie2.flour_getter_setter = flour;

                }
                //choose if cookie3
                else if (chooseCookie.Equals("cookie3"))
                {
                    cookie3.Gluten_getter_setter = isGluten;

                    cookie3.Eggs_getter_setter = eggs;

                    cookie3.flour_getter_setter = flour;

                }
                // no suck cookie
                else
                {
                    Console.WriteLine("no such cookie");
                }
            }
            
            printCookie(cookie2);
            Console.WriteLine("\n");
            printCookie(cookie3);
            Console.WriteLine("\n");
            string glut = cookie2.Gluten_getter_setter = cookie1.Gluten_getter_setter;
            int egg = cookie2.Eggs_getter_setter = cookie1.Eggs_getter_setter;
            double flour1 = cookie2.flour_getter_setter = cookie1.flour_getter_setter;
            int new_coockie = cookie2.Eggs_getter_setter;
            Console.WriteLine("is thre gluten? " + glut + "\tnum of eggs " + egg + "\t" + flour1 + " grams of flour");
            new_coockie = 8;
            Console.WriteLine("new amount of eggs -->" + new_coockie);

            Console.ReadKey();
        }
    }
}
