namespace MudGame;

public class Player
{
    public List<string> inventory;

    public Player()
    {
        inventory = new List<string>();
    }
    
    public void Print()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.Write("인벤토리 : ", inventory[i]);
            if (i < inventory.Count - 1)
            {
                Console.Write(", ");
            }
        }
    }
}