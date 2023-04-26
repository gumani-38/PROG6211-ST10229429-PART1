using System.Collections;


namespace GumaniMoilaPart1
{
    internal class Program
    {
        //global variables
        static ArrayList myIngredient = new ArrayList(); //declaring an object array
        static ArrayList myStep = new ArrayList();
        static Ingredient objIngredient;
        static Step objStep;
        //variables and initializing them to a default value;
        static int numIngredient = 0;
        static string ingredientName = "";
        static double ingredientQuantity = 0;
        static string unitMeasurement = "";
        static int numStep = 0;
        static string description = "";
        static void getIndgredientAndSteps()
        {
            Console.Write("Please enter the number of ingredient : "); //prompt message to the user
            numIngredient = int.Parse(Console.ReadLine()); //retrieving the user input and storing it in the memory

            //looping 
            for (var i = 0; i < numIngredient; i++)
            {
                int count = i + 1;
                Console.Write("Please enter the name of the ingredient number {0} : ", count);
                ingredientName = Console.ReadLine();
                Console.Write("Please enter the quantity of ingredient number {0} : ", count);
                ingredientQuantity = int.Parse(Console.ReadLine());
                Console.Write("Please enter the unit of measurement of ingredient number {0} : ", count);
                unitMeasurement = Console.ReadLine();
                //initializing the indgredient object with its values
                objIngredient = new Ingredient(ingredientName, ingredientQuantity, unitMeasurement);
                myIngredient.Add(objIngredient);
                Console.WriteLine("********************************************");

            }
            Console.Write("Please enter the number of steps : ");
            numStep = int.Parse(Console.ReadLine());
            for (int i = 0; i < numStep; i++)
            {
                int count = i + 1;
                Console.Write("Please enter the description of  step number {0} : ", count);
                description = Console.ReadLine();
                //initializing the steps object with its values
                objStep = new Step(description);
                myStep.Add(objStep);
            }

        }
        static void displayIngredient()
        {
            Console.WriteLine("------------------------------------------------");
            //loop
            foreach (Ingredient item in myIngredient)
            {
                Console.WriteLine("Ingredient name : {0}", item.GetIngredientName());
                Console.WriteLine("Ingredient quantity : {0}", item.GetIngredientQuantity());
                Console.WriteLine("Ingredient unit of measurement : {0}", item.GetUnitMeasurement());
                Console.WriteLine("");
            }
        }
        static void displayStep()
        {
            int countStep = 0;
            //loop
            foreach (Step item in myStep)
            {
                countStep = countStep + 1;
                Console.WriteLine("Step number {0} : {1}", countStep, item.GetDescription());
            }

        }
        static void Main(string[] args)
        {


            Console.WriteLine("Welocme To Recipe Saver Application"); //printing a line 
            Console.WriteLine("========================================");
            getIndgredientAndSteps();
            displayIngredient();
            Console.WriteLine("=======================================================");
            displayStep();
            Console.Write("How would you like to scale your quantities by factor of 0.5(half), 2(double) or 3(tripple)");
            Console.Write("please enter the number choice to select : 1 = 0.5(half), 2 = 2(double) or 3 = 3(tripple)");
            int scaleFactorMenu = int.Parse(Console.ReadLine());
            double scaleFactor = 0;

            //validating the enter menu choice value if is true the assign a specific scale factor
            if (scaleFactorMenu == 1)
            {
                scaleFactor = 0.5;
            }
            if (scaleFactorMenu == 2)
            {
                scaleFactor = 2;
            }
            if (scaleFactorMenu == 3)
            {
                scaleFactor = 3;
            }
            foreach (Ingredient item in myIngredient)
            {
                double quantity = scaleFactor * item.GetIngredientQuantity();
                item.SetIngredientQuantity(quantity);

            }
            Console.WriteLine("The updated ingredient by scale factor of {0}", scaleFactor);
            displayIngredient();

            Console.Write("Would you like to reset the quantities values back to original ? enter yes = (yes) or no = (no) : ");
            string resetQuantMenu = Console.ReadLine();
            if (resetQuantMenu == "yes")
            {
                foreach (Ingredient item in myIngredient)
                {
                    double quantity = item.GetIngredientQuantity()/ scaleFactor;
                    item.SetIngredientQuantity(quantity);

                }

            }
            Console.WriteLine("The indgredient quantities back to original : ");
            displayIngredient();
            Console.Write("Would you like to clear all the data to enter the new recipe ? yes = (yes) or no = (no) :");
            string clearDataMenu = Console.ReadLine();
            Console.Read();

            if (clearDataMenu == "yes")
            {
                myIngredient.Clear();
                myStep.Clear();
            }
            Console.WriteLine("");

        }
    }
}