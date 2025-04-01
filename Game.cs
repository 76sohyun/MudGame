namespace MudGame;

public static class Game
{
    public static bool gameOver;
    public static Dictionary<String, Scene> _sceneDic;
    public static Scene CurScene;
    public static Player player;
    public static Player Player
    {
        get { return player; }
        set { player = value; }
    }
    private static int livPer;

    public static List<string> items;
    
    public static void Start()
    {
        gameOver = false;
        CurScene = new TitleScene();
        _sceneDic = new Dictionary<string, Scene>();
        _sceneDic.Add("Title", new TitleScene());
        _sceneDic.Add("Ax", new AxScene());
        _sceneDic.Add("Choose", new ItemChoose());
        livPer = 0;
        
        items = new List<string>();
        items.Add("Ax");
        items.Add("Radio");
        items.Add("RatPosion");
        items.Add("Book");
        items.Add("FirstaidKit");
        items.Add("Gun");
        items.Add("Card");
        items.Add("Map");
    }


    public static void End()
    {
        Console.WriteLine("****************************");
        Console.WriteLine("*****     Game Over    *****");
        Console.WriteLine("****************************");
    }

    public static void GameClear()
    {
        Console.WriteLine("******************************");
        Console.WriteLine("*****     Game Clear!   *****");
        Console.WriteLine("******************************");
        Console.WriteLine("축하합니다! 당신은 핵폭발에서 살아남았습니다!");
    }
    
    public static void Run()
    {
        while (gameOver == false)
        {
            CurScene.Render();
            Console.WriteLine();
            CurScene.Choice();
            CurScene.Input();
            Console.WriteLine();
            CurScene.Result();
            Console.WriteLine();
            CurScene.Wait();
            CurScene.Next();
            livPer += 10;
        }
    }

    public static void CurSceneChange(string newScene)
    {
        CurScene = _sceneDic[newScene];
    }
}