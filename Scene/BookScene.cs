using System.Globalization;
using System.Threading.Channels;

namespace MudGame;

public class BookScene:Scene
{
    public override void Render()
    {
        Console.WriteLine("\"사사삭\"");
        Console.WriteLine("하루가 끝나기 직전 침낭에 누운 당신은 흠칫했습니다.");
        Console.WriteLine("굉장히 익숙하면서도 소름끼치는 소리가 들렸기 때문입니다.");
        Console.WriteLine("\"사사삭\"");
        Console.WriteLine("전역 이후로 한 번도 들은 적도, 본 적도 없지만 그 정체는 분명했습니다.");
        Console.WriteLine("식량을 쌓아둔 상자 틈으로 바퀴벌레가 들어가는 것을 본 당신은 정신이 아득해졌습니다.");
        Console.WriteLine("저 존재를 맨 손으로 만지는 것은 분명 불가능하지만, 그렇다고 같이 살 수도 없을 것입니다.");
        Console.WriteLine("어떻게 하시겠습니까?");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 이럴 때를 대비해서 책을 가져왔지. 책 모서리를 양손으로 잡고 있는 힘껏 내리친다.");
        Console.WriteLine("2. 혹시 모르니 쥐약을 구석에 뿌리고 잠에 들어본다.");
        Console.WriteLine("3. 지금 당장 할 수 있는 것은 아무것도 없다. 제발 자연사하기를 기도한다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                if (Game.player.IsOwned("Book"))
                {
                    Console.WriteLine("\"틱! 틱! 탁!!!\"");
                    Console.WriteLine("녀석은 재빠른 움직임으로 당신의 무기를 피했지만, 오랜 사투 끝에 잡을 수 있었습니다.");
                    Console.WriteLine("당신은 책에 붙은 바퀴벌레를 쳐다보기도 싫어 통째로 땅에 묻었으며,");
                    Console.WriteLine("기력이 조금 빠지긴 했지만, 이제 더이상 바퀴벌레가 없다는 사실이 당신을 꿀잠으로 인도합니다.");
                    Game.player.inventory.Remove("Book");
                }
                break;
            case ConsoleKey.D2:
                if (Game.player.IsOwned("RatPoison"))
                {
                    Console.WriteLine("쥐약은 분명 탁월한 선택이었으나, 당신이 하나 간과한 것이 있습니다.");
                    Console.WriteLine("바로 저 바퀴벌레는 핵폭발에서도 살아남았다는 사실입니다.");
                    Console.WriteLine("영악한 녀석은 쥐약 냄새를 맡았는지 오히려 당신을 향해 달려왔습니다.");
                    Console.WriteLine("덩치는 산만하지만 깜짝 놀란 당신은 바닥에 굴러다니던 통조림을 밟고 넘어졌으며,");
                    Console.WriteLine("운이 좋았던건지 다행이도 엉덩이로 녀석을 찌부러트릴 수 있었습니다.");
                    Console.WriteLine("다만 바지에 붙어버린 녀석은 흔적을 남겼으며, 당신은 양손이 모두 까졌습니다.");
                    Console.WriteLine("체력 -1");
                    Game.player.hp -= 1;
                    Game.player.inventory.Remove("RatPoison");
                }
                break;
            case ConsoleKey.D3:
                Console.WriteLine("당신은 애써 바퀴버레를 무시했고, 그것도 당신을 무시하기 시작했습니다.");
                Console.WriteLine("어느 순간부터 그 녀석의 소리가 들리지 않았고, 당신은 안도의 한숨을 쉬었습니다.");
                break;
            default:
                break;
        }
    }

    public override void Next()
    {
        Game.livPer += 10;
        Game.RandomScene();
        Game.Escape();
    }
}