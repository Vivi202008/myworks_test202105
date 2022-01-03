using System;
using System.IO;

namespace Uppgifter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Wei's program. ");
            Console.WriteLine("Please press any key to begin...");
            Console.ReadKey();
            Meny();
            Action();
        }


        static void Meny()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("  0. Exit");
            Console.WriteLine("  1. Input the user's first name, last name and age");
            Console.WriteLine("  2. Changes the color of the text");
            Console.WriteLine("  3. Printing today's date");
            Console.WriteLine("  4. Input and Compare two numbers");
            Console.WriteLine("  5. Guess the number (1-100)");
            Console.WriteLine("  6. Input text and save in a file on the harddisk");
            Console.WriteLine("  7. Read a file on the harddisk");
            Console.WriteLine("  8. Root calculation and exponential calculation");
            Console.WriteLine("  9. Multiplication table");
            Console.WriteLine("  10. Create two arrays, generate random numbers and sort them");
            Console.WriteLine("  11. Input and checks a palindrome");
            Console.WriteLine("  12. Print all the numbers between two inputs ");
            Console.WriteLine("  13. Input several numbers, sort them by odd and even numbers and print");
            Console.WriteLine("  14. Input several numbers, add and print");
            Console.WriteLine("  15. Create two role names and attributes and save them in an instance of the class.");

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Input a number (0-15) to choice a funtion:  ");
        }

        static void Action()
        {
            string answer = Console.ReadLine();
            bool changeColor = true;
            do
            {
                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Case 1. Input the user's first name, last name and age");
                        Console.WriteLine("Input your first name: ");
                        string first_name = Console.ReadLine();
                        Console.WriteLine("Input your last name: ");
                        string last_name = Console.ReadLine();
                        int age=0 ;
                        bool age_input=true;
                        while (age_input)
                        { 
                            try
                            {
                                 Console.WriteLine("Input your age: ");
                                 age = int.Parse(Console.ReadLine());
                                age_input = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("This is not a number, input again");
                                age_input = true;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Your name is " + first_name + " " + last_name + " , you are " + age + " years old.");
                        break;
                    case "2":
                        Console.WriteLine("Case 2. Changes the color of the text");
                        Console.WriteLine();
                        if (changeColor) {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Hello, My color is blue!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Hello, My color is back to gray!");
                        }
                        changeColor = !changeColor;
                        break;
                    case "3":
                        Console.WriteLine("Case 3. Printing today's date");
                        Console.WriteLine();
                        Console.WriteLine("Today is " + DateTime.Now.ToString("yyyy-MM-dd"));
                        break;
                    case "4":
                        Console.WriteLine("Case 4. Input and Compare two numbers");
                        Console.WriteLine();
                        double num1, num2;
                        string inputNum1, inputNum2;
                        try
                        {
                            Console.WriteLine("Input first number:");
                            inputNum1 = Console.ReadLine();
                            num1 = System.Convert.ToDouble(inputNum1);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not a number, default become 0.");
                            num1 = 0;
                        }
                        try
                        {
                            Console.WriteLine("Input andra number:");
                            inputNum2 = Console.ReadLine();
                            num2 = System.Convert.ToDouble(inputNum2);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not a number, default become 0.");
                            num2 = 0;
                        }
                        if (num1 > num2)
                        {
                            Console.WriteLine("The first number "+num1+" is the largest");
                        }
                        else
                        {
                            if (num1 < num2)
                            {
                                Console.WriteLine("The second number " + num2 + "  is the largest");
                            }
                            else
                            {
                                Console.WriteLine("Both numbers are "+num1+" .");
                            }
                                
                        }
                        break;
                    case "5":
                        Console.WriteLine("Case 5. Guess the number (1-100)");
                        Console.WriteLine();
                        Random r = new Random();
                        int number1 = r.Next(0, 100);  
                        int keynumber = 0;
                        int inputTimes = 0;
                        while (keynumber != number1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Guess! Input an integer(1-100): ");
                            try
                            {
                                keynumber = int.Parse(Console.ReadLine());
                                inputTimes++;

                                if (keynumber > number1)
                                {
                                    Console.WriteLine("You har guessed "+inputTimes+ " times. and number is "+keynumber+". Too big! Guess again");
                                }
                                if (keynumber < number1)
                                {
                                    Console.WriteLine("You har guessed No." + inputTimes + " times. and number is " + keynumber + ". Too small! Guess again");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("This is not an integer. Input again");
                                keynumber = 0;
                                
                            }
                        }
                        // Right number and guesstimes.
                        Console.WriteLine("The right number is " + number1 +". You har guessed "+inputTimes+" times.");

                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "6":
                        Console.WriteLine("Case 6. Input text and save in a file on the harddisk");
                        Console.WriteLine();
                        Console.WriteLine("Input text: ");
                        string[] names = new string[] { Console.ReadLine(),"Sweden", "China","USA", DateTime.Now.ToString()};
                        using (StreamWriter sw = new StreamWriter("names.txt"))
                        {
                            foreach (string s in names)
                            {
                                sw.WriteLine(s);
                                Console.WriteLine(s);
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "7":
                        Console.WriteLine("Case 7. Read a file on the harddisk");
                        Console.WriteLine();
                        
                        // Read
                        string line = "";
                        using (StreamReader sr = new StreamReader("names.txt"))
                        {
                            while ((line = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(line);
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "8":
                        Console.WriteLine("Case 8. Root calculation and exponential calculation");
                        Console.WriteLine();
                        double number2;
                        try
                        {
                            Console.WriteLine("Input a number:");
                            number2 = double.Parse(Console.ReadLine());  
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not a number, default become 2.");
                            number2 = 2;
                        }
                        double result1= Math.Sqrt(number2);
                        Console.WriteLine(number2+"^(1/2)"+" = "+result1);
                        double result2 = 0;
                        for (int power = 2; power <= 10; power++)
                        {
                            result2 = Math.Pow(number2, power);
                            Console.WriteLine(number2 + " ^ " + power + " = " + result2);
                        }
                            

                            Console.WriteLine();
  
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "9":
                        Console.WriteLine("Case 9. Multiplication table");
                        Console.WriteLine();
                        string multiplication;
                        for (int i = 1; i <= 10; i++)
                        {
                            multiplication = i + ".";
                            Console.WriteLine();
                            for (int j = 1; j <= i; j++)
                            {

                                multiplication = multiplication + "\t" + i + "X" + j + "=" + (i * j);
                            }
                            Console.WriteLine(multiplication);
                        }
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "10":
                        Console.WriteLine("Case 10. Create two arrays, generate random numbers and sort them");
                        Console.WriteLine();
                        int number6; // antal numbers
                        try
                        {
                            Console.WriteLine("Input antal of the numbers that sorted:");
                            number6 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not an integer, default become 5.");
                            number6 = 5;
                        }

                        //generate random numbers
                        Random r1= new Random();
                        int[] array1 = new int[number6];
                        int[] array2 = new int[number6];
                        string numberArray1 ="Array1 numbers are ";
                        string numberArray2 = "Array2 numbers are ";
                        for (int i=0; i < number6; i++)
                        {
                            array1[i] = r1.Next(0, 100);
                            array2[i] = array1[i];
                        }

                        //sort and print
                        Console.WriteLine();
                        Array.Sort(array2);
                        for (int i = 0; i < number6; i++)
                        {
                            numberArray1 = numberArray1 + array1[i] + " , ";
                            numberArray2 = numberArray2 + array2[i] + " , ";
                        }
                        Console.WriteLine();
                        Console.WriteLine(numberArray1);
                        Console.WriteLine(numberArray2);

                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "11":
                        Console.WriteLine("Case 11. Input and checks a palindrome");
                        Console.WriteLine();
                        Console.WriteLine("Input a string of characters");
                        string testStr=Console.ReadLine();
                        char[] text = new char[testStr.Length];
                        for (int counter = 0; counter < testStr.Length; counter++)
                        {
                            text[counter] = testStr[counter];
                        }
                        
                        string resultPalindrome="";
                        for (int counter = 0; counter < testStr.Length; counter++)
                        {
                            if (!(text[counter] == text[testStr.Length - 1 - counter]))
                            {
                                Console.WriteLine(text[counter] +" and "+ text[testStr.Length - 1 - counter]+" are not same.");
                                resultPalindrome = testStr+" is not a palindrome.";
                                break;
                            }
                            else
                            {
                                Console.WriteLine(text[counter] + " and " + text[testStr.Length - 1 - counter] + " are same.");
                                resultPalindrome = testStr + " is a palindrome.";
                            }
                        }
                        Console.WriteLine(resultPalindrome);
                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "12":
                        Console.WriteLine("Case 12. Print all the numbers between two intengers. ");
                        Console.WriteLine();
                        int number3, number4;
                        try
                        {
                            Console.WriteLine("Input the first number:");
                            number3 = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not a number, default become 1.");
                            number3 = 1;
                        }
                        try
                        {
                            Console.WriteLine("Input the andra number:");
                            number4 = int.Parse(Console.ReadLine());                            
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("This is not a number, default become 10.");
                            number4 = 10;
                        }
                        int min, max;
                        if (number3 < number4)
                        {
                            min = number3;
                            max = number4;
                        }
                        else
                        {
                            min = number4;
                            max = number3;
                        }

                        Console.WriteLine();
                        Console.WriteLine("Print all the numbers between "+min+" and "+max+" , total is "+(max-min+1));
                        for (int j = min; j <= max; j++)
                        {
                            Console.Write(j+", ");
                        }
                        Console.WriteLine();

                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "13":
                        Console.WriteLine("Case 13. Input several numbers, sort them by odd and even numbers and print");
                        Console.WriteLine();

                        Console.WriteLine("Input several numbers, separated by commas");
                        string severalNumbers1 = Console.ReadLine();
                        string[] numbersStr = severalNumbers1.Split(',');
                        int[] numbersInt = new int[numbersStr.Length];
                        string allnumbers="All numbers is: ";

                        for(int i = 0; i < numbersStr.Length; i++) //input integers
                        {
                            try
                            {
                                numbersInt[i] = int.Parse(numbersStr[i]);                                
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The No."+(i+1)+" number is not an integer, default become "+(i+1)+" .");
                                numbersInt[i] = i+1;
                            }
                            allnumbers = allnumbers + numbersInt[i] + "  ";
                        }

                        Console.WriteLine();
                        Console.WriteLine(allnumbers);
                        Console.WriteLine();
                        allnumbers = "Sort odd number in ascending order: ";
                        Array.Sort(numbersInt);
                        for (int i = 0; i < numbersStr.Length; i++)
                        {
                            if (Convert.ToBoolean(numbersInt[i] % 2))
                            {
                                allnumbers = allnumbers + ", " + numbersInt[i];
                            }  
                        }
                        Console.WriteLine(allnumbers);
                        Console.WriteLine();

                        allnumbers = "Sort even number in descending order: ";
                        Array.Reverse(numbersInt);
                        for (int i = 0; i < numbersStr.Length; i++) //input 
                        {
                            if (!Convert.ToBoolean(numbersInt[i] % 2))  
                                allnumbers = allnumbers + " , " + numbersInt[i];
                        }
                        Console.WriteLine(allnumbers);


                        Console.WriteLine("----------------------------------------------------------");
                        break;
                    case "14":
                        Console.WriteLine("Case 14. Input several numbers, add and print");
                        Console.WriteLine();
                        Console.WriteLine("Input several numbers, separated by commas");
                        string severalNumbers = Console.ReadLine();
                        int sum = 0, number = 0;
                        int k = 0;
                        string[] numbersArray = severalNumbers.Split(','); // ，---input numbers
                        for (k=0; k < numbersArray.Length; k++)
                        {
                            try
                            {
                                number = Convert.ToInt32(numbersArray[k]);
                                
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("The No." + (k + 1) + " number is not an integer, default become " + (k + 1) + " .");
                                number = k + 1;
                            }
                            sum = sum + number;
                        }
                        
                        Console.WriteLine();                        
                        Console.WriteLine(severalNumbers+" sum is "+ Convert.ToString(sum));
                        Console.WriteLine();
                        break;
                    case "15":
                        Console.WriteLine("Case 15. Create two role names and attributes and save them in an instance of the class.");
                        Console.WriteLine();

                        Player player1=new Player();
                        Player player2=new Player();

                        string namePlayer1, namePlayer2;
                        Console.WriteLine("Input the name of your role");
                        namePlayer1 = Console.ReadLine();
                        Console.WriteLine("Input the name of an opponent");
                        namePlayer2 = Console.ReadLine();

                        Console.WriteLine("");
                        player1.SetPlayer(namePlayer1);
                        player1.PrintPlayer();
                        player2.SetPlayer(namePlayer2);
                        player2.PrintPlayer();

                        Console.WriteLine("");
                        break; 
                    case "0":
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Input fel. Please input number 0-15");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to back meny...");
                Console.ReadKey();
                Meny();
                answer = Console.ReadLine();
            } while (answer != "0");
        }
    }


}
