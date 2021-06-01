using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace CshConsoleAPI
{
	public class AppCommands
	{
		
		public const string CMD_PROMPED = "\n>";
		public const string CMD_ECHO = "echo";
		public const string CMD_EXIT = "exit";
		public const string CMD_ADD = "add";
		public const string CMD_SUB = "sub";
		public const string CMD_MULT = "mult";
		public const string CMD_DIV = "div";





		/***
		* Echo demonstrates a command execution function.
		* the command prints the parameters it receives.
		*/
		public static bool CommandEcho(string[] parameters)
		{
			foreach (string param in parameters){
				Console.WriteLine(param);
			}
			return (true);
		}
		public static bool CommandExit(string[] parameters)
        {
			foreach (string param in parameters)
			{
				Environment.Exit(0);
			}
			return (true);

		}
		public static bool CommandAdd(string[] parameters)
		{
			int x = 0;
			foreach (string param in parameters)
			{
                x += Convert.ToInt32(param);
				
				
			}
			Console.WriteLine(x);
			return (true);

		}
		public static bool CommandSub(string[] parameters)
		{
			int x = Convert.ToInt32(parameters[0]);
			for(int i = 1; i< parameters.Length; i++)
			{
				x =x - Convert.ToInt32(parameters[i]);


			}
			Console.WriteLine(x);
			return (true);

		}
		public static bool CommandMult(string[] parameters)
		{
			int x = 1;
			foreach (string param in parameters)
			{
				x = x * Convert.ToInt32(param);


			}
			Console.WriteLine(x);
			return (true);

		}
		public static bool CommandDiv(string[] parameters)
		{
			int x = Convert.ToInt32(parameters[0]);
			for(int i= 1; i< parameters.Length; i++)
			{

				if (x != 0)
				{
					x = x / Convert.ToInt32(parameters[i]);
				}


			}
			Console.WriteLine(x);
			return (true);

		}

	}
}
