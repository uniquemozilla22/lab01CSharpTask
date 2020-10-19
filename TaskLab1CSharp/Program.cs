using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace TaskLab1CSharp
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] result = { "anorexia", "underweight", "in normal range", "marginally overweight", "overweight", "very overweight or obese", "severely obese", "morbidly obese", "super obese" };

            int continues = 100;
            do
            {
                Console.WriteLine("Please enter your gender (m for 'Men' or w for 'Women'):");
                string gender = Console.ReadLine();

                Console.WriteLine("Please Enter your weight");
                string weight_in_string = Console.ReadLine();

                double weight = Single.Parse(weight_in_string);


                Console.WriteLine("Is your weight in Kilograms (press k ) or in Pounds(press p)");
                string kilo_or_pound = Console.ReadLine();

                double sq_of_height = 0;

                switch (kilo_or_pound)
                {
                    case "k":
                        {
                            Console.WriteLine("Please Enter your Height(in Meters):");
                            string height_in_string = Console.ReadLine();

                            double height = Single.Parse(height_in_string);
                            sq_of_height = height * height;
                            break;


                        }

                    case "p":
                        {
                            Console.WriteLine("Please Enter your Height(in Inches):");
                            string height_in_string = Console.ReadLine();

                            double height = Single.Parse(height_in_string);
                            sq_of_height = height * height * 703;
                            break;
                        }


                }
                double BMIReasult = weight / sq_of_height;

                if (gender == "w")
                {
                    if (BMIReasult < 17.5)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[0]);
                    }
                    else if (BMIReasult >= 17.5 && BMIReasult < 19.1)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[1]);

                    }
                    else if (BMIReasult >= 19.1 && BMIReasult < 25.8)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[2]);

                    }
                    else if (BMIReasult >= 25.8 && BMIReasult < 27.3)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[3]);
                    }
                    else if (BMIReasult >= 27.3 && BMIReasult < 32.3)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[4]);

                    }
                    else if (BMIReasult >= 32.3 && BMIReasult < 35)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[5]);

                    }
                    else if (BMIReasult >= 35 && BMIReasult < 40)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ". So, You are " + result[6]);

                    }
                    else if (BMIReasult >= 40 && BMIReasult < 50)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ". So, You are " + result[7]);

                    }
                    else if (BMIReasult >= 50 && BMIReasult < 60)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[8]);

                    }
                    else if (BMIReasult > 60)

                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ".");


                    }

                    Console.WriteLine("Do You want to exit the programme?(press y for YES or any key to continue)");
                    string exit = Console.ReadLine();

                    if (exit == "y")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }


                }
                else if (gender == "m")
                {
                    if (BMIReasult < 17.5)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[0]);
                    }
                    else if (BMIReasult >= 17.5 && BMIReasult < 20.7)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[1]);

                    }
                    else if (BMIReasult >= 20.7 && BMIReasult < 26.4)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[2]);

                    }
                    else if (BMIReasult >= 26.4 && BMIReasult < 27.8)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[3]);
                    }
                    else if (BMIReasult >= 27.9 && BMIReasult < 31.1)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[4]);

                    }
                    else if (BMIReasult >= 31.1 && BMIReasult < 35)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[5]);

                    }
                    else if (BMIReasult >= 35 && BMIReasult < 40)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ". So, You are " + result[6]);

                    }
                    else if (BMIReasult >= 40 && BMIReasult < 50)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ". So, You are " + result[7]);

                    }
                    else if (BMIReasult >= 50 && BMIReasult < 60)
                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + " .So, You are " + result[8]);

                    }
                    else if (BMIReasult > 60)

                    {
                        Console.WriteLine("You have the BMI of " + BMIReasult + ".");


                    }
                    Console.WriteLine("Do You want to exit the programme?(press y for YES or any key to continue)");
                    string exit = Console.ReadLine();

                    if (exit == "y")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Gender Type . Restart the console.");
                }

            } while (continues == 100);

        }

    }
}
