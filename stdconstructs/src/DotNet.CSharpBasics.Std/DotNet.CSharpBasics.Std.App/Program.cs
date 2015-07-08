/*
 * Program.cs
 * 
 * Contains main execution code of console application.
 * 
 * This code is intended for demonstration purposes, to help
 * students studying courses like Computer Programming Basics
 * and/or System Programming Basics.
 * Code should not be seriously considered for production use.
 * 
 * Author: Denis Belikov
 * 
**/

using System;

namespace DotNet.CSharpBasics.Std.App
{
    class Program
    {
        // Constant variable
        const string UNKNOWN_COMMAND = "Result cannot be obtained for unknown command.";

        // Static variable
        static bool shouldExit = false;

        // Static method returning String value
        static string GetCmdFromPrompt()
        {
            // Declaring variable
            string result;
            // Write text to standard output (console)
            Console.WriteLine("ENTER COMMAND:");
            // Initializing variable with value coming from standard input (stdin)
            result = Console.ReadLine();

            // Returning value to calling code
            return result;
        }

        static string GetCmdResult(string cmd)
        {
            CommandExecutor cmdExec = new CommandExecutor();
            string output = string.Empty;

            try
            {
                switch (cmd)
                {
                    case "date":
                        output = cmdExec.GetCurrentDate();
                        break;
                    case "pcname":
                        output = cmdExec.GetComputerName();
                        break;
                    case "osname":
                        output = cmdExec.GetOperatingSystemName();
                        break;
                    case "exit":
                        output = "Exiting...";
                        shouldExit = true;
                        break;
                    default:
                        output = UNKNOWN_COMMAND;
                        break;
                }
            }
            catch (Exception ex)
            {
                output = string.Format("Error ocurred while execuring command:\n{0}\n\nStack-trace:\n{1}",
                    ex.Message, ex.StackTrace);
            }

            return output;
        }

        // Static method of void - it does not return any value
        static void ShowOutput(string output)
        {
            if (!string.IsNullOrEmpty(output))
            {
                Console.WriteLine("RESULT:");
                Console.WriteLine("{0, 55}", output);
            }
        }

        // This method is an entry point for any console application
        static void Main(string[] args)
        {
            while (!shouldExit)
            {
                string cmd = GetCmdFromPrompt();
                string output = GetCmdResult(cmd);

                ShowOutput(output);
            }
        }
    }
}
