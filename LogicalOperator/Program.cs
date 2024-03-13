using System;
namespace problems
{

    class LogicAndLoopsProblems
    {
        public void doWhileExample()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

        }



        public void WhileExample()
        {

            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }


        }




        public void consoleProb()
        {
            System.Console.WriteLine("hello ,welcome");
            string name = "Goutham";
            int age = 30;
            double d = 3.12;
            var n = 30.9;
            float val = 14567;

        }




        public void ForloopExample()
        {

            int num = 10;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        }




        public void NestedtForLoopExample()
        {

            Console.WriteLine("Enter first value");
            int Value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            int Value2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Value1; i++)
            {
                for (int j = 1; j <= Value2; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }


        }



        public void doWhileLoopExample()
        {
            int num = 5;
            int userInput = Convert.ToInt32(Console.ReadLine());
            do
            {

                Console.WriteLine("num value is less than userInput");
                break;

            } while (num <= userInput);


        }

        public void ConditionalOperators()
        {

            int num = 13;
            if (num % 2 == 0)
            {
                Console.WriteLine("It Is even Number");
            }
            else
            {
                Console.WriteLine("It Is A Odd Number");
            }


        }



        public void if_else_if_Conditions()
        {

            int num = 15;
            Console.WriteLine("enter user input");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if (num > userInput)
            {
                Console.WriteLine("number is greater than  userInput");
            }
            else if (num < userInput)
            {
                Console.WriteLine("number is less than  userInput");
            }
            else
            {
                Console.WriteLine("number and userInput both are same");
            }

        }



        public void switchCaseExample()
        {

            Console.WriteLine("enter the weeks name");
            string month = Convert.ToString(Console.ReadLine());
            switch (month)
            {
                case ("monday"):
                    Console.WriteLine("TODAY MONDAY");
                    break;
                case ("tuesday"):
                    Console.WriteLine("TODAY WAS TUEADAY");
                    break;
                case ("wednesday"):
                    Console.WriteLine("TODAY WAS WEDNESDAY");
                    break;
                case ("thursday"):
                    Console.WriteLine("TODAY WAS THURSDAY");
                    break;
                case ("friday"):
                    Console.WriteLine("TODAY WAS FRIDAY");
                    break;
                case ("satueday"):
                    Console.WriteLine("TODAY WAS SATURDAY");
                    break;

                default:
                    Console.WriteLine("is not a week name");
                    break;


            }

        }

    }
}