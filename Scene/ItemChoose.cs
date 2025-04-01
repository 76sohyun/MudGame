namespace MudGame;

public class ItemChoose : Scene
{
    private string key;
    private int keyInt;
    public override void Render()
    {
        Console.WriteLine("방공호에 가져갈 아이템을 선택해주세요");
    }

    public override void Choice()
    {
        for (int i = 1; i <= Game.items.Count; i++)
        {
            Console.WriteLine($"{i}. {Game.items[i-1]}");
        }
    }

    public override void Input()
    {
        key = Console.ReadLine();
        int.TryParse(key, out keyInt);
    }
    
    public override void Result()
    {
        int itemCount = 0;
        for (int i = 0; i < Game.items.Count; i++)
        {
            if (keyInt - 1 == i)
            {
                Game.player.inventory.Add(Game.items[i]);
                Game.items.RemoveAt(i);
            }
        }
    }
    
    public override void Next()
    {
        if (Game.player.inventory.Count == 4)
        {
            Game.CurSceneChange("Ax");
        }
    }
}