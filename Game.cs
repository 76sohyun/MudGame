namespace MudGame;

public static class Game
{
    public static int livPer;
    public static bool gameOver;
    public static List<string> items;
    public static Dictionary<String, Scene> _sceneDic;
    public static Scene CurScene;
    public static Player player;
    public static Player Player
    {
        get { return player; }
        set { player = value; }
    }
    
    public static void Start()
    {
        player = new Player();
        gameOver = false;
        livPer = 0;
        CurScene = new TitleScene();
        
        _sceneDic = new Dictionary<string, Scene>();
        _sceneDic.Add("Title", new TitleScene());
        _sceneDic.Add("Ax", new AxScene());
        _sceneDic.Add("Radio", new RadioScene());
        _sceneDic.Add("Book", new BookScene());
        _sceneDic.Add("FirstAidKit", new FirstAidKitScene());
        _sceneDic.Add("Gun", new GunScene());
        _sceneDic.Add("Card", new CardScene());
        _sceneDic.Add("Map", new MapScene());
        _sceneDic.Add("GasMask", new GasMaskScene());
        _sceneDic.Add("Escape", new EscapeScene());
        _sceneDic.Add("Choose", new ItemChoose());
        
        
        items = new List<string>();
        items.Add("Ax");
        items.Add("Radio");
        items.Add("RatPoison");
        items.Add("Book");
        items.Add("FirstAidKit");
        items.Add("Gun");
        items.Add("Card");
        items.Add("Map");
        items.Add("GasMask");
    }

    public static void Escape()
    {
        Random random = new Random();
        int value = random.Next(0, 100);
        if (value < livPer)
        {
            CurSceneChange("Escape");
        }
        else return;
    }
    
    public static void RandomScene()
    {
        Random random = new Random();
        int sceneNum = random.Next(0,_sceneDic.Count-2);

        switch (sceneNum)
        {
            case 0:
                CurScene = _sceneDic["Ax"];
                break;
            case 1:
                CurScene = _sceneDic["Radio"];
                break;
            case 2:
                CurScene = _sceneDic["GasMask"];
                break;
            case 3:
                CurScene = _sceneDic["Book"];
                break;
            case 4:
                CurScene = _sceneDic["FirstAidKit"];
                break;
            case 5:
                CurScene = _sceneDic["Gun"];
                break;
            case 6:
                CurScene = _sceneDic["Card"];
                break;
            case 7:
                CurScene = _sceneDic["Map"];
                break;
        }
    }
    
    public static void End()
    {
        Console.WriteLine("**********************************");
        Console.WriteLine("*            게임오버...           *");
        Console.WriteLine("**********************************");
    }
    
    public static void GameOver(string reason)
    {
        Console.WriteLine();
        Console.WriteLine(reason);
        
        gameOver = true;
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
            gameOver = player.IsDead();
        }
    }

    public static void CurSceneChange(string newScene)
    {
        CurScene = _sceneDic[newScene];
    }
}