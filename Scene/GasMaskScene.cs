namespace MudGame;

public class GasMaskScene : Scene
{
    public override void Render()
    {
        Console.WriteLine("대피소에 있는 당신은 갑자기 밖이 궁금해졌습니다.");
        Console.WriteLine("살아있는 사람은 있는지, 나가지 않으면 여기서 굶어죽는 것은 아닐지");
        Console.WriteLine("이럴때를 대비해 알리 익스프레스에서 방독면을 구매를 했지만, 대피하면서 챙겼는지 기억이 잘 나질 않습니다.");
        Console.WriteLine("당신은 마지막 희망을 가지고 상자를 열어봅니다.");
    }

    public override void Choice()
    {
        Console.WriteLine("1. 다행히 방독면을 발견할 수 있었다. 밖으로 나가보자!");
        Console.WriteLine("2. 방독면은 있지만, 아직 밖으로 나가기에는 시기상조일 것이다. 조금만 기다려보자.");
        Console.WriteLine("3. 방독면이 있을리가... 지금은 아무것도 할 수 없다.");
    }

    public override void Result()
    {
        switch (_key)
        {
            case ConsoleKey.D1:
                Random random = new Random();
                int value = random.Next(0,100);
                if (Game.player.IsOwned("GasMask"))
                {
                    if (value < 50)
                    {
                        Console.WriteLine("당신은 밖에 나가자마자 숨이 막히는 것을 느꼈습니다.");
                        Console.WriteLine("더 이상 있는 것은 무리라고 판단해 급한대로 바닥에 굴러다니던 통조림 하나를 들고왔습니다.");
                        Console.WriteLine("체력 +1");
                        Game.player.hp += 1;
                    }
                    else if (value < 80)
                    {
                        Console.WriteLine("밖은 생각보다 안전했습니다.");
                        Console.WriteLine("방독면을 벗을 수는 없겠지만, 간만에 밖으로 나온 당신은 느긋하게 주위를 둘러봅니다.");
                        Console.WriteLine("다행히 대피소로부터 멀리 떨어지지 않은 곳에서 총 한 자루를 주을 수 있었지만");
                        Console.WriteLine("어디선가 싸우는 듯한 소리가 들려 급하게 대피소로 돌아왔습니다.");
                        Game.player.inventory.Add("Gun");
                    }
                    else if (value < 99)
                    {
                        Console.WriteLine("밖은 생각보다 안전했습니다.");
                        Console.WriteLine("오랜만에 밖으로 나온 당신은 매우 신나 이곳저곳을 뛰어다닙니다.");
                        Console.WriteLine("\"철푸덕\"");
                        Console.WriteLine("예상했겠지만 당신은 결국 넘어졌고, 크게 다치고 말았습니다.");
                        Game.player.hp -= 1;
                    }
                    else
                    {
                        Console.WriteLine("\"치직... 치지직...\"");
                        Console.WriteLine("밖은 여전히 방사능에 잠겨있었습니다.");
                        Console.WriteLine("미처 가리지 못한 당신의 손은 방사능에 피폭되고 말았고,");
                        Console.WriteLine("이를 인지하지 못 한 채 돌아다닌 당신은 결국 피를 토하며 쓰러졌습니다.");
                        Game.gameOver = true;
                    }
                }
                break;
            case ConsoleKey.D2:
                Console.WriteLine("당신은 안전합니다. 아직까지는...");
                break;
            case ConsoleKey.D3:
                Console.WriteLine("당신은 안전합니다. 아직까지는...");
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