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
        Console.WriteLine("인벤토리");
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.Write($"{inventory[i]}");
            if (i < inventory.Count - 1)
            {
                Console.Write(", ");
            }
        }
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