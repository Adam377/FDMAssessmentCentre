using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentCentreTask
{
    class Digit
    {
        //members
        private String digit;

        //constructor
        public Digit(int digit)
        {
            this.digit = digit.ToString();
        }

        //methods
        public void DrawDigit()
        {
            //draws number in LCD style.
            foreach(char n in digit)
            {
                switch(n)
                {
                    case '0':
                        //draw 0
                        Console.WriteLine(" _"); //top
                        Console.WriteLine("| |"); //upper middle
                        Console.WriteLine("|_|"); //bottom middle                        

                        Console.WriteLine();
                        break;

                    case '1':
                        //draw 1
                        Console.WriteLine("|");
                        Console.WriteLine("|");

                        Console.WriteLine();
                        break;

                    case '2':
                        //draw 2
                        Console.WriteLine(" _"); //top
                        Console.WriteLine(" _|"); //top right
                        Console.WriteLine("|_"); //bottom left

                        Console.WriteLine();
                        break;

                    case '3':
                        //draw 3
                        Console.WriteLine(" _"); //top
                        Console.WriteLine(" _|"); //top right                        
                        Console.WriteLine(" _|"); //top right

                        Console.WriteLine();
                        break;

                    case '4':
                        //draw 4
                        Console.WriteLine("|_|"); //top
                        Console.WriteLine("  |"); //middle

                        Console.WriteLine();
                        break;

                    case '5':
                        //draw 5
                        Console.WriteLine(" _"); //top
                        Console.WriteLine("|_"); //top right
                        Console.WriteLine(" _|"); //bottom left

                        Console.WriteLine();
                        break;

                    case '6':
                        //draw 6
                        Console.WriteLine("|_"); //top
                        Console.WriteLine("|_|");//bottom

                        Console.WriteLine();
                        break;

                    case '7':
                        //draw 7
                        Console.WriteLine("_"); //top
                        Console.WriteLine(" |"); //middle
                        Console.WriteLine(" |"); //bottom

                        Console.WriteLine();
                        break;

                    case '8':
                        //draw 8
                        Console.WriteLine(" _"); //top right
                        Console.WriteLine("|_|"); //middle
                        Console.WriteLine("|_|"); //bottom left

                        Console.WriteLine();
                        break;

                    case '9':
                        //draw 9
                        Console.WriteLine(" _"); //top right
                        Console.WriteLine("|_|"); //middle
                        Console.WriteLine(" _|"); //bottom left
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
