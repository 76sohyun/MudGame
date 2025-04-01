namespace MudGame;

public class Player
{
    public List<string> inventory;

    public int hp;
    public int Hp
    {
        get { return hp; }
        set{ hp = value;}
    }

    public Player()
    {
        inventory = new List<string>();
        hp = 3;
    }
    
    public bool IsDead()
    {
        return hp == 0;
    }
    
    public void Print()
    {
        Console.WriteLine("              I  N  V  E  N  T  O  R  Y             ");
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        Console.WriteLine("♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥♡♥");    
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.Write($"{inventory[i]}");
            if (i < inventory.Count - 1)
            {   
                Console.Write(" | ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        Console.WriteLine();
        Console.Write("체력 : ");
        for (int i = 0; i < hp; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           Console.Write(" ■ ");
        }
        
        Console.WriteLine();
        Console.WriteLine();
            
    }
    public bool IsOwned(string item)
    {
        for(int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i] == item) return true;
        }
        return false;
    }
}