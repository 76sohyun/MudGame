namespace MudGame;

public class Util
{
        public static void Print(string context, ConsoleColor textColor, int delay)
        {
            Console.ForegroundColor = textColor;
            Console.Write(context);
            Thread.Sleep(delay);
            Console.ResetColor();
        }
}