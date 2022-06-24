using System;

namespace BADI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Brian's Animal Database Interface (BADI)");

            int runtimeCode = 0;

            //TODO: "Load" (validate) DataSource and other saved settings
            //*****

            //Load the library modules, validate they exist, connections, etc.
            try
            {
                if (LoadModules() == 0)
                {
                    Console.WriteLine("Modules loaded.");
                }
                else
                {
                    Console.WriteLine("Failed to load all modules:");
                }
            }
            catch
            {
                //TODO: Terminate or reload the program
                //***** Detailed log of which modules failed, multiple exceptions possible, io exceptions etc.
            }

            //Loop menu display function while not terminating in error
            while(runtimeCode is 0)
            {
                runtimeCode = QueryUserInput();
            }

            //TESTING: Pause program exit -- temporary program flow control
            Console.WriteLine("You have reached the end of the program. Goodbye.");
            Console.ReadLine();
        }

        //Library module helper method
        static int LoadModules()
        {
            //TODO: Load various library modules
            //***** DataSource connection module would be called here, program lock
            //***** Throw any exceptions back up the stack, alters program flow

            return 0;
        }

        //CLI menu display helper method
        static int QueryUserInput()
        {
            Console.WriteLine("Please enter a function key");

            //TODO: Validate input range within 1-libtoolsFunctionsTotal
            //Accept menu option that user inputs
            if (!Console.IsInputRedirected)
            {
                try
                {
                    //TODO: Accept and verify user input, handle i/o and input exceptions
                    Char menuSelection = Console.ReadKey(true).KeyChar;

                    if (!Char.IsDigit(menuSelection))
                    {
                        throw new ArgumentOutOfRangeException(menuSelection.ToString(), "User must input a digit.");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("{0} is not a valid menu option.", e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            //Return to Main() for program loop
            return 0;
        }
    }
}
