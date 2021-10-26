using System;

namespace Rectangle
{
    class Program
    {


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Go();
            Console.ReadLine();
        }
        public void Go()
        {

            bool exit = false;
            int length, width, height = 0;
            string option1 = string.Empty;
            Console.WriteLine("\n Please enter the dimention for the rectangle: (positive whole numbers are accepted [>0]).");
            do
            {

                Console.Write("\n Length:");
                option1 = Console.ReadLine();
                if (!int.TryParse(option1, out length) || (length <= 0))
                {
                    Console.WriteLine("\n You have entered a Incorrect input!!!! Try again");
                }
            } while (!(length > 0));



            do
            {

                Console.Write("\n Width:");
                option1 = Console.ReadLine();
                if (!int.TryParse(option1, out width) || (width <= 0))
                {
                    Console.WriteLine("\n You have entered a Incorrect input!!!! Try again");
                }
            } while (!(width > 0));


            do
            {

                Console.Write("\n Height:");
                option1 = Console.ReadLine();
                if (!int.TryParse(option1, out height) || (height <= 0))
                {
                    Console.WriteLine("\n You have entered a Incorrect input!!!! Try again");
                }
            } while (!(height > 0));


            Rectangle rectangle = new Rectangle(length, width, height);
            while (!exit)
            {
                Console.WriteLine(" 1) GET THE LENTH OF RECTANGLE");
                Console.WriteLine(" 2) CHANGE THE LENGTH OF RECTANGLE");
                Console.WriteLine(" 3) GET THE WIDTH OF CIRCLE");
                Console.WriteLine(" 4) CHANGE THE WIDTH OF RECTANGLE");
                Console.WriteLine(" 5) GET THE HEIGHT OF RECTANGLE");
                Console.WriteLine(" 6) SET THE HEIGHT OF RECTANGLE");
                Console.WriteLine(" 7) GET THE VOLUME OF THE RECTANGLE");
                Console.WriteLine(" 8) EXIT");
                Console.Write("PLEASE CHOOSE ONE OF THE FOLLOWING OPTIONS:");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("The length of the rectangle is :  {0}", rectangle.Getlength());
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine();


                            Console.Write("Enter the new length : ");


                            if (!int.TryParse(Console.ReadLine(), out length))
                            {
                                Console.WriteLine("Please enter a correct input");
                            }
                            else if (length > 0)
                            {
                                rectangle.Setlength(length);
                                Console.WriteLine();
                                Console.WriteLine("The length of the rectangle is changed to {0}", length);
                            }
                            else
                            {
                                Console.WriteLine("Please enter an Integer value");
                            }




                            break;

                        case 3:
                            Console.WriteLine("The length of the circle is : {0}", rectangle.Getwidth());
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();


                            Console.Write("Enter the new width : ");


                            if (!int.TryParse(Console.ReadLine(), out width))
                            {
                                Console.WriteLine("Please enter a correct input");
                            }
                            else if (width > 0)
                            {
                                rectangle.Setlength(width);
                                Console.WriteLine();
                                Console.WriteLine("The width of the rectangle is changed to {0}", width);
                            }
                            else
                            {
                                Console.WriteLine("Please enter an Integer value");
                            }


                            break;

                        case 5:
                            Console.WriteLine("The height of the rectangle is :  {0}", rectangle.Getheight());
                            Console.WriteLine();
                            break;
                        case 6:
                            Console.WriteLine();


                            Console.Write("Enter the new height : ");


                            if (!int.TryParse(Console.ReadLine(), out height))
                            {
                                Console.WriteLine("Please enter a correct input");
                            }
                            else if (height > 0)
                            {
                                rectangle.Setlength(height);
                                Console.WriteLine();
                                Console.WriteLine("The length of the rectangle is changed to {0}", height);
                            }
                            else
                            {
                                Console.WriteLine("Please enter an Integer value");
                            }
                            break;
                        case 7:
                            Console.WriteLine("The Volume of the rectangle is : {0}", rectangle.GetVolume());
                            Console.WriteLine();
                            break;
                        case 8:
                            exit = true;
                            break;



                    }
            }
        }
    }
}