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
        player = new Player();
        gameOver = false;
        CurScene = new TitleScene();
        _sceneDic = new Dictionary<string, Scene>();
        _sceneDic.Add("Title", new TitleScene());
        _sceneDic.Add("Ax", new AxScene());
        _sceneDic.Add("Choose", new ItemChoose());
        _sceneDic.Add("탈출", new EscapeScene());
        
        
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

    public static void Escape()
    {
        Random random = new Random();
        int value = random.Next(0, 100);
        if (value < livPer)
        {
            CurSceneChange("탈출");
        }
        else return;
    }

    public static void RandomScene()
    {
        Dictionary<string, Scene> sceneDic = new Dictionary<string, Scene>();
        sceneDic = _sceneDic;
        sceneDic.Remove("Title");
        sceneDic.Remove("탈출");
        Random random = new Random();
        int sceneNum = random.Next(0,sceneDic.Count);

        switch (sceneNum)
        {
            case 0:
                CurScene = sceneDic["Ax"];
                break;
            case 1:
                CurScene = sceneDic["Radio"];
                break;
            case 3:
                CurScene = sceneDic["Choose"];
                break;
            case 4:
                CurScene = sceneDic["Choose"];
                break;
            case 5:
                CurScene = sceneDic["Choose"];
                break;
            case 6:
                CurScene = sceneDic["Choose"];
                break;
            case 7:
                CurScene = sceneDic["Choose"];
                break;
            case 8:
                CurScene = sceneDic["Choose"];
                break;
        }
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
            player.Print();
            CurScene.Render();
            Console.WriteLine();
            CurScene.Choice();
            CurScene.Input();
            Console.WriteLine();
            CurScene.Result();
            Console.WriteLine();
            CurScene.Wait();
            Console.WriteLine();
            CurScene.Next();
            livPer += 10;
        }
    }

    public static void CurSceneChange(string newScene)
    {
        CurScene = _sceneDic[newScene];
    }
}