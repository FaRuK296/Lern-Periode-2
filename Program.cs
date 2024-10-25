namespace Taschenrechner_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wilkommen beim Tachenrechner!");



            // Erste Zahl eingeben
            Console.WriteLine("Bitte gebe eine Zahl ein");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Zweite Zahl eingeben
            Console.WriteLine("Bitte gebe eine zweite Zahl ein");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Operator eingeben
            Console.WriteLine("Wähle einen Operator (+, -, *, /)");
            char chosenOperator = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;
            bool validOperation = true;



            // Berechnung der eingegebenen Werte
            switch (chosenOperator)
            {
                case '+':
                    result = number1 + number2;
                    break;

                case '-':
                    result = number1 - number2;
                    break;

                case '*':
                    result = number1 * number2;
                    break;

                case '/':

                    if (number2 != 0)
                    {
                        result = number1 / number2;

                    }
                    else
                    {
                        
                            Console.WriteLine("Error!");
                        validOperation = false;
                    
                    }
                    
                    break;



             
           }







            }
        }
    } 
