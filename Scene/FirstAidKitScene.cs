namespace MudGame;

public class FirstAidKitScene : Scene
{
    public override void Render()
    {
        Console.WriteLine("당신의 방공호의 전기가 끊긴지 3일이 지났습니다...");
        Console.WriteLine("당신은 오들오들 떱니다....");
        Console.WriteLine("아무래도 몸살에 걸린 것 같습니다.");
        Console.WriteLine("약을 안먹으면 죽을 것 같습니다...");
        Console.WriteLine("당신은 어떻게 할 것입니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 이불 덮고 잔다...");
        Console.WriteLine("2. 엇... 마침 옆집 아저씨가 의사인게 떠올랐다.. 집 밖으로 나가서 옆집으로 간다.");
        Console.WriteLine("3. 구급상자 안에 있는 약을 먹는다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Console.WriteLine("당신은 이불을 꽁꽁 싸매서 잔다....");
                Console.WriteLine("하지만 보일러가 잘 안되는 덕에 감기몸살에 걸렸습니다..");
                Console.WriteLine("당신은 일주일내내 앓았습니다..");
                Console.WriteLine("오늘의 교훈 약을 아끼지말자.");
                Console.WriteLine("당신의 HP가 2 깎였습니다.");
                Game.player.hp--;
                Game.player.hp--;
                break;

            case ConsoleKey.D2:
                Console.WriteLine("당신은 옆 집에 가기 위해 얼굴을 손수건으로 가리고 나갑니다. ");
                Console.WriteLine("하지만 손수건은 방사능을 이길 수 없었습니다...");
                Console.WriteLine("\"커억어엉어어억\"");
                Console.WriteLine("당신은.,.. 방사능에 의해 문도가 되었습니다.");
                break;

            case ConsoleKey.D3:
                Console.WriteLine("\"띠리리릴리ㅣㄹ뾰보봅보보봅보\"");
                Console.WriteLine("당신은 약을 먹고 하루 정도 쉬자 몸살이 나았습니다.");
                Console.WriteLine("이거제~~~~~~~~");
                Game.player.inventory.Remove("FirstAidKit");
                break;
        }
    }

    public override void Next()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Game.Escape();
                Game.RandomScene();
                break;
            case ConsoleKey.D2:
                Game.GameOver("문도가 된 당신은 미치광이가 되어 춤추다가 그만 머리를 돌에 부딫혀죽었습니다.");
                break;
            case ConsoleKey.D3:
                Game.Escape();
                Game.RandomScene();
                break;
        }
    }
}