﻿using System;
using static System.Console;

namespace Game
{
    internal class Game
    {
        static void Main()
        {
            WriteLine(
                "Вы просыпаетесь в густом тумане, совершенно одинокий и без воспоминаний о прошлом. Ваше тело обмотано доспехами,\n" +
                "а рука сжимает рукоять меча. На груди валяется загадочный свиток с надписью:\n" +
                "\u001b[31m\" Найди убийцу и отомсти !\"\u001b[0m. В вашей голове звучит лишь одно слово: месть.\n");
            ReadLine();
            WriteLine(
                "Перед вами появляется зверь, похожий на огромного монстра с головой неопознанного существа и телом, подобным медведю.\n" +
                "Он свирепо храпит и топает ногами, готовясь к атаке. Перед вами два варианта действий:\n");
            ReadLine();
            WriteLine("1. Попытаться убежать.");
            WriteLine("2. Подготовиться к битве и атаковать зверя.");
            int choice;

            while (true)
            {
                try
                {
                    {
                        choice = int.Parse(ReadLine());
                        if (choice == 1 || choice == 2) break;
                        WriteLine("Введите 1 или 2");
                    }
                }
                catch
                {
                    WriteLine("Ошибка! Введите цифру \u001b[30m(1 или 2)\u001b[0m.");
                }
            }

            if (choice == 1)
            {
                WriteLine(
                    "К сожалению, зверь оказался гораздо быстрее вас и с легкостью догнал. \n " +
                    "С его рыком в воздухе и тяжелым топотом лап вы поняли, что смерть неизбежна. " +
                    "Силы покидают ваше тело, а темный туман медленно окутывает ваше сознание. \n " +
                    "Последним, что вы видите, - это его огромные зубы, мерцающие в тусклом свете.");
                ExitGame();
            }

            if (choice == 2)
            {
                WriteLine(
                    "Вы собрались с последними каплями решимости, прижимая к себе меч, который лежал неподалёку.\n" +
                    "Он обволакивал вашу длань, словно предвещая неизбежное столкновение. " +
                    "Сердце билось в унисон с шумом волн, и вы с уверенностью нашли в себе силы для битвы.\n" +
                    "Перед вами раскинулась тёмная арена, где вы должны были сразиться с неведомым зверем, который стоял перед вами, наполненный яростью и диким стремлением к силе.\n" +
                    "Сейчас ваш ход, ваша решимость, и ваш первый удар должен стать решающим шагом на пути к победе.\n" +
                    "Где вы решите нанести этот удар? Судьба висит на волоске, и ваш выбор будет определяющим.");
                ReadLine();
                WriteLine("1. Сделать прыжок и ударить в бок");
                WriteLine("2. Нанести удар в голову");
                WriteLine("3. Попытаться обезоружить зверя, атакуя его лапы");
                int choice2;
                while (true)
                {
                    try
                    {
                        choice2 = int.Parse(ReadLine());
                        if (choice2 == 1 || choice2 == 2 || choice2 == 3) break;
                        WriteLine("Введите 1, 2 или 3");
                    }
                    catch
                    {
                        WriteLine("Ошибка! Введите цифру \u001b[30m(1, 2 или 3)\u001b[0m.");
                    }
                }

                switch (choice2)
                {
                    case 1:
                        WriteLine("С переполохом вы бросаетесь в атаку, приготовившись нанести удар в бок зверя. Мощное сальто, меткий удар — и ваш меч пронзает его плоть.\n" +
                                  "Однако, вместо кровавой брызги, вы встречаете лишь пугающий, демонический хохот, сопровождаемый странными звуками, словно голосами из ада.\n" +
                                  "Ошеломленные и напуганные, вы осознаете, что ваш враг уже давно мертв, а его тело — всего лишь марионетка в руках темных сил,\n" +
                                  "что пронизывают его и управляют им, словно игрушкой.\n" +
                                  "В этом мгновении осознания вам становится ясно, что вы столкнулись с чем-то гораздо более могущественным и зловещим, чем просто зверь из леса.\n" +
                                  "Что-то, не принадлежащее этому миру, овладело его телом и душой, и теперь вы стоите лицом к лицу с источником этого тьмы и ужаса.");
                        ReadLine();
                        WriteLine("Очертания огненного свечения на спине зверя привлекают ваше внимание, вызывая некий внутренний импульс.\n" +
                                  "С готовностью атаковать эту точку, вы сосредотачиваетесь и бросаетесь в атаку, нацеленный прямо в пылающий огонек.\n" +
                                  "Ваш меч метко срезает воздух, стремясь проникнуть в источник света, надеясь, что это окажется ключом к победе над тьмой, что овладела зверем.\n" +
                                  "Ваш удар сопровождается вихрем страшных звуков и взрывов, словно битва между светом и тьмой развертывается прямо перед вашими глазами. ");
                        ReadLine();
                        WriteLine("Со звуком мощного всплеска пламени зверь исчезает, оставив лишь пепел в своем следе. Ваше дыхание замирает, а сердце бьется сильнее, осознавая победу.\n" +
                                  "Однако, смерть зверя не принесла вам покоя.\n" +
                                  "В вас все еще кипит жажда мести, и вы решительно настроены найти того, кто стоит за всем происходящим, кто стал причиной вашего страдания.\n" +
                                  "\nСнова овладев вами, чувство мести направляет ваши шаги, вдохновляя вас на поиск истины и правосудия.\n" +
                                  "Ваше приключение только начинается, а впереди вас ждут новые испытания, загадки и битвы.\n" +
                                  "Вы готовы пройти через все преграды, чтобы найти ответы и добиться своей мести."
                                  );
                        break;

                    case 2:
                        WriteLine("Ваш удар был точным и сильным, пронзив монстра прямо в голову.\n" +
                                  "Из раны полилась кровь, и вокруг зверя вспыхнули демонические всплески, как будто адские силы раздирали воздух вокруг.\n" +
                                  "Однако, зверь не упал, а наоборот, свирепо рычал и смотрел на вас своими зловещими глазами. И спустя какое-то мгновение,\n" +
                                  "рана на его голове затянулась, словно он никогда и не был ранен. Этот зверь, кажется, не принадлежит этому миру. " +
                                  "Вы почувствовали, что он уже не жив, а под влиянием \u001b[31mадских сил.\u001b[0m");
                        ReadLine();
                        WriteLine("У вас есть лишь небольшое мгновение, чтобы принять решение о том, что делать дальше.");
                        WriteLine();
                        string[] atack = { "еще один удар в голову", "удар в туловище", "удар по лапам зверя" };

                        for (int i = 0; i < atack.Length; i++)
                        {
                            WriteLine($"{i+1}. Нанести {atack[i]}");
                        }
                        int choiceCase2;
                        while (true)
                        {
                            try
                            {
                                choiceCase2 = int.Parse(ReadLine());
                                if (choiceCase2 == 1 || choiceCase2 == 2 || choiceCase2 == 3) break;
                                WriteLine("Введите 1, 2 или 3");
                            }
                            catch 
                            {
                                WriteLine("Ошибка! Введите цифру \u001b[30m(1, 2 или 3)\u001b[0m.");
                            }
                        }

                        switch (choiceCase2)
                        {
                            case 1:
                                WriteLine(
                                    "Ваш второй удар в голову зверя наносится с такой же силой, но не приносит ожидаемого результата.\n" +
                                    "Вместо того, чтобы причинить ущерб, ваш меч начинает расплавляться от близости к голове зверя, словно его температура превышает пределы обычного железа.\n" +
                                    "С ужасом вы осознаете, что этот зверь обладает невероятной силой, способной изменять структуру вещей вокруг.\n" +
                                    "Прежде чем вы успеваете сделать еще один шаг назад, зверь бросается на вас, раздирая вас пополам своими острыми когтями.\n" +
                                    "Боль пронзает ваше существо, и темнота окутывает ваше сознание...");
                                break;
                            case 2:
                                WriteLine(
                                    "Подготовившись к атаке, вы метко направляете свой меч в туловище зверя, надеясь нанести ему серьезный удар.\n" +
                                    "Однако внезапно зверь мощным движением своей лапы разрывает вас словно игрушечного куклу.\n" +
                                    "От силы удара вы отлетаете на несколько метров, потеряв всякую надежду на победу. Зверь не ждет, чтобы вы пришли в себя,\n" +
                                    "и, поднимая свою вторую лапу, наносит разрушительный удар прямо в ваше туловище.\n" +
                                    "Волна боли ошеломляет вас, а зверь, не давая вам ни малейшего шанса на спасение.\n" +
                                    "Вы падаете на землю, чувствуя, как жизненная сила покидает ваше тело.\n" +
                                    "Под вами начинает образовываться лужа крови, а ваше сознание медленно уходит в небытие, окутываемое тьмой...");
                                break;

                            case 3:
                                WriteLine("С вашими смелыми ударами по лапам зверь взревел от боли, но в следующее мгновение удивительное произошло:\n" +
                                    "новые лапы выросли у него прямо на ваших глазах!\n" +
                                    "Невероятная сила монстра оказалась больше, чем вы думали.\n" +
                                    "Он размахнулся новыми острыми когтями и разорвал вас на куски, пока вы бессильно лежали на земле, отдаваясь смерти.");
                                break;
                        }
                        ReadLine();
                        WriteLine("На этом ваше отчаянное стремление к победе завершается.\n" +
                                  "Сердце замирает в недопонимании, когда тьма окутывает вас, словно плотный туман, поглощая каждую вашу мысль и дыхание.\n" +
                                  "Ваши глаза закрываются, и вы погружаетесь в бездонную пустоту, словно плывете по черному океану бессмыслицы и забвения.\n" +
                                  "Вокруг вас только тьма, безмолвие и полное отсутствие каких-либо ощущений.\n" +
                                  "Ни больше, ни радости, ни горя — лишь пустота, в которой вы плывете, утрачивая свое бытие и становясь лишь пылью в вечном вихре времени.");
                                    
                        break;

                    case 3:
                        WriteLine(
                            "С вашими смелыми ударами по лапам зверь взревел от боли, но в следующее мгновение удивительное произошло:\n" +
                            "новые лапы выросли у него прямо на ваших глазах!\n" +
                            "Невероятная сила монстра оказалась больше, чем вы думали.\n" +
                            "Он размахнулся новыми острыми когтями и разорвал вас на куски, пока вы бессильно лежали на земле, отдаваясь смерти.");
                        break;
                }
            }

            ReadLine();
            ExitGame();
        }


        static void ExitGame()
        {
            int exitChoice;
            bool tf;
            WriteLine("Игра оконченна!");
            WriteLine("1. Начать заново");
            WriteLine("2. Выйти из игры");
            do
            {
                tf = int.TryParse(ReadLine(), out exitChoice);
                if (!tf || !(exitChoice == 1 || exitChoice == 2))
                    WriteLine("Ошибка! Введите цифру \u001b[30m(1 или 2)\u001b[0m.");
            } while (!tf || !(exitChoice == 1 || exitChoice == 2));

            if (exitChoice == 1) Clear();
            Main();
            if (exitChoice == 2) Environment.Exit(0);
        }
    }
}