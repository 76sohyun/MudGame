using System.Collections.Concurrent;

namespace MudGame;

public abstract class Scene
{
    protected ConsoleKey _key;
    
    public abstract void Render();
    
    public abstract void Choice();

    public virtual void Input()
    {
        _key = Console.ReadKey(true).Key;
    }
    
    public abstract void Result();

    public void Wait()
    {
        Console.WriteLine("계속 진행하려면 아무 키나 누르세요.");
        Console.ReadKey();
    }
    
    public abstract void Next();
    
    public void ChoiceAgain()
    {
        Console.Clear();
        Game.player.Print();
        Render();
        Console.WriteLine();
        Choice();
        Input();
        Console.WriteLine();
        Result();
    }
}