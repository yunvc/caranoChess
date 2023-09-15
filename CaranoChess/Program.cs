using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaranoChess
{
    class  info4Heroes
    {
        public string Name
        {
            get;
            set;
        }
        public int Attack
        {
            get;
            set;
        }
        public int Defense
        {
            get;
            set;
        }
        public int Hp
        {
            get;
            set;
        }
        public int Level
        {
            get;
            set;
        }
        public int Cost
        {
            get;
            set;
        }
        public string Attr1
        {
            get;
            set;
        }
        public string Attr2
        {
            get;
            set;
        }
    }//end class info4Heroes

    class info4Monster
    {
        public string Name
        {
            get;
            set;
        }

        public int Attack
        {
            get;
            set;
        }

        public int Defense
        {
            get;
            set;
        }

        public int Hp
        {
            get;
            set;
        }
    }//end class info4Heroes

    class Program
    {
        static void Main(string[] args)
        {
            #region regulation
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("玩法說明:");
            Console.ResetColor();

            Console.WriteLine("1、共7回合，每回合玩家將與電腦對戰。");
            Console.WriteLine("2、玩家起手為$7。");
            Console.WriteLine("3、角色皆為一星，每三隻相同星級的同角色即可上升一星，直至三星。");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n角色基礎:");
            Console.ResetColor();

            Console.WriteLine("$1");
            Console.WriteLine("亥犽:30攻擊、100血量");
            Console.WriteLine("薇拉: 30攻擊、100血量");
            Console.WriteLine("阿杜恩: 15攻擊、165血量");
            Console.WriteLine("克里希: 30攻擊、100血量");
            Console.WriteLine("克萊斯: 10攻擊、180血量");

            Console.WriteLine("\n$2");
            Console.WriteLine("愛里: 25攻擊、140血量");
            Console.WriteLine("特爾安娜絲: 35攻擊、100血量");
            Console.WriteLine("洛克: 25攻擊、140血量");
            Console.WriteLine("菲尼克: 35攻擊、100血量");

            Console.WriteLine("\n$3");
            Console.WriteLine("莉莉安: 35攻擊、100血量");
            Console.WriteLine("馬洛斯: 30攻擊、150血量");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n角色羈絆:");
            Console.ResetColor();

            Console.WriteLine("$1");
            Console.WriteLine("亥犽:射手、忍者");
            Console.WriteLine("薇拉:法師、魔族");
            Console.WriteLine("阿杜恩:戰士、坦克");
            Console.WriteLine("克里希:法師、精靈");
            Console.WriteLine("克萊斯:坦克、獸人");

            Console.WriteLine("\n$2");
            Console.WriteLine("愛里:戰士、忍者");
            Console.WriteLine("特爾安娜絲:射手、精靈");
            Console.WriteLine("洛克:射手、戰士");
            Console.WriteLine("菲尼克:射手、獸人");

            Console.WriteLine("\n$3");
            Console.WriteLine("莉莉安:法師、九尾妖狐");
            Console.WriteLine("馬洛斯:戰士、魔族");
            #endregion regulation

            #region def
            int round = 1;
            int money = 7;
            bool inputIsCorrect = false;
            List<info4Heroes> heroesInfoList = new List<info4Heroes>();
            List<int> chooseList4Lv1 = new List<int>();
            List<int> chooseList4Lv2 = new List<int>();
            List<int> chooseList4Lv3 = new List<int>();
            #endregion def

            while (inputIsCorrect == false)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n是否準備開始(Y/N)?");
                Console.ResetColor();

                switch (Console.ReadLine().ToUpper())
                {
                    case "Y":
                        inputIsCorrect = true;
                        Heroes(round, money,chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList);
                        break;
                    case "N":
                        inputIsCorrect = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The End.");
                        Console.ResetColor();
                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("請輸入 Y/N !");
                        Console.ResetColor();
                        Console.WriteLine("\n");
                        break;
                }
            }
            Console.ReadLine();
        }

        static void Heroes(int round,int money, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList)
        {
            #region def
            List<int> randomList = new List<int>();
            info4Heroes theHeroes = new info4Heroes();
            int calculation = 0;
            bool isEnough2Choose = true;
            #endregion def

            #region heroes *
            info4Heroes h1 = new info4Heroes();
            h1.Name = "亥犽";
            h1.Attack = 30;
            h1.Defense = 0;
            h1.Hp = 100;
            h1.Level = 1;
            h1.Cost = 1;
            h1.Attr1 = "射手";
            h1.Attr2 = "忍者";
            heroesInfoList.Add(h1);

            info4Heroes h2 = new info4Heroes();
            h2.Name = "薇拉";
            h2.Attack = 30;
            h2.Defense = 0;
            h2.Hp = 100;
            h2.Level = 1;
            h2.Cost = 1;
            h2.Attr1 = "法師";
            h2.Attr2 = "魔族";
            heroesInfoList.Add(h2);

            info4Heroes h3 = new info4Heroes();
            h3.Name = "阿杜恩";
            h3.Attack = 15;
            h3.Defense = 0;
            h3.Hp = 165;
            h3.Level = 1;
            h3.Cost = 1;
            h3.Attr1 = "戰士";
            h3.Attr2 = "坦克";
            heroesInfoList.Add(h3);

            info4Heroes h4 = new info4Heroes();
            h4.Name = "克里希";
            h4.Attack = 30;
            h4.Defense = 0;
            h4.Hp = 100;
            h4.Level = 1;
            h4.Cost = 1;
            h4.Attr1 = "法師";
            h4.Attr2 = "精靈";
            heroesInfoList.Add(h4);

            info4Heroes h5 = new info4Heroes();
            h5.Name = "克萊斯";
            h5.Attack = 10;
            h5.Defense = 0;
            h5.Hp = 180;
            h5.Level = 1;
            h5.Cost = 1;
            h5.Attr1 = "坦克";
            h5.Attr2 = "獸人";
            heroesInfoList.Add(h5);
            #endregion heroes *

            #region heroes **
            info4Heroes h6 = new info4Heroes();
            h6.Name = "愛里";
            h6.Attack = 25;
            h6.Defense = 0;
            h6.Hp = 140;
            h6.Level = 1;
            h6.Cost = 2;
            h6.Attr1 = "戰士";
            h6.Attr2 = "忍者";
            heroesInfoList.Add(h6);

            info4Heroes h7 = new info4Heroes();
            h7.Name = "特爾安娜絲";
            h7.Attack = 35;
            h7.Defense = 0;
            h7.Hp = 100;
            h7.Level = 1;
            h7.Cost = 2;
            h7.Attr1 = "射手";
            h7.Attr2 = "精靈";
            heroesInfoList.Add(h7);

            info4Heroes h8 = new info4Heroes();
            h8.Name = "洛克";
            h8.Attack = 25;
            h8.Defense = 0;
            h8.Hp = 140;
            h8.Level = 1;
            h8.Cost = 2;
            h8.Attr1 = "戰士";
            h8.Attr2 = "射手";
            heroesInfoList.Add(h8);

            info4Heroes h9 = new info4Heroes();
            h9.Name = "菲尼克";
            h9.Attack = 35;
            h9.Defense = 0;
            h9.Hp = 100;
            h9.Level = 1;
            h9.Cost = 2;
            h9.Attr1 = "射手";
            h9.Attr2 = "獸人";
            heroesInfoList.Add(h9);
            #endregion heroes **

            #region heroes ***
            info4Heroes h10 = new info4Heroes();
            h10.Name = "莉莉安";
            h10.Attack = 40;
            h10.Defense = 0;
            h10.Hp = 100;
            h10.Level = 1;
            h10.Cost = 3;
            h10.Attr1 = "法師";
            h10.Attr2 = "九尾妖狐";
            heroesInfoList.Add(h10);

            info4Heroes h11 = new info4Heroes();
            h11.Name = "馬洛斯";
            h11.Attack = 30;
            h11.Defense = 0;
            h11.Hp = 150;
            h11.Level = 1;
            h11.Cost = 3;
            h11.Attr1 = "戰士";
            h11.Attr2 = "魔族";
            heroesInfoList.Add(h11);
            #endregion heroes ***

            do
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------------第{0}回合選角-------------", round);
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("$:{0}", money);
                Console.ResetColor();

                bool isWant2ChooseMore = true;
                Random r = new Random();
                do
                {
                    if (round <= 2)
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            int b = r.Next(0, 5);
                            randomList.Add(b);
                        }
                    }
                    else if (round <= 5)
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            int b = r.Next(0, 9);
                            randomList.Add(b);
                        }
                    }
                    else if (round <= 7)
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            int b = r.Next(0, 11);
                            randomList.Add(b);
                        }
                    }

                    foreach (int i in randomList)
                    {
                        Console.WriteLine("Heroes(${0}):{1} \t({2},{3})", heroesInfoList[i].Cost, heroesInfoList[i].Name, heroesInfoList[i].Attr1, heroesInfoList[i].Attr2);
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("------------------------------------");
                    Console.ResetColor();

                    while (randomList.Count != 0 && money > 0)
                    {
                        bool inputNumIsCorrect = false;
                        do
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("請選擇角色(1~4):");
                            Console.ResetColor();
                            try
                            {
                                int choose = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n");
                                foreach(int i in randomList.ToArray())
                                {
                                    if (money < heroesInfoList[randomList[choose-1]].Cost)
                                    {
                                        isEnough2Choose = false;
                                    }
                                    else
                                    {
                                        isEnough2Choose = true;
                                    }
                                }
                                if (isEnough2Choose == false)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Your money isn't enough to choose this hero.\n");
                                    Console.ResetColor();
                                }
                                if (isEnough2Choose == true)
                                {
                                    chooseList4Lv1.Add(randomList[choose - 1]);

                                    foreach (int i in chooseList4Lv1.ToArray())//要在判斷升等前計算$(若升等-->Lv.1List會移除剛選擇的heroes，就少扣除$了)
                                    {
                                        calculation = money;
                                        calculation -= heroesInfoList[i].Cost;//randomList只會出現Lv.1的Heroes，所以只有Lv.1List會影響$
                                    }
                                    money = calculation;
                                    //Console.WriteLine("calculation:{0}", money);

                                    Check2LevelUp(round, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList);

                                    foreach (int i in chooseList4Lv1.ToArray())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("chooseList:{0}(Lv.1)", heroesInfoList[i].Name);
                                        Console.ResetColor();
                                    }
                                    foreach (int i in chooseList4Lv2.ToArray())
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("chooseList:{0}(Lv.2)", heroesInfoList[i].Name);
                                        Console.ResetColor();
                                    }
                                    foreach (int i in chooseList4Lv3.ToArray())
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine("chooseList:{0}(Lv.3)", heroesInfoList[i].Name);
                                        Console.ResetColor();
                                    }
                                    
                                    randomList.Remove(randomList[choose - 1]);
                                    inputNumIsCorrect = true;
                                }
                                else
                                {
                                    inputNumIsCorrect = true;
                                }  
                            }
                            catch (Exception ex)
                            {
                                inputNumIsCorrect = false;
                                
                                Console.ForegroundColor = ConsoleColor.Red;
                                //Console.WriteLine(ex.Message);
                                Console.WriteLine("請輸入不超過Heroes個數的數字!");
                                Console.WriteLine("\n");
                                Console.ResetColor();
                            }
                        } while (inputNumIsCorrect == false);

                        
                        bool inputIsCorrect2Choose = false;
                        foreach (int i in randomList.ToArray())
                        {
                            if (money >= heroesInfoList[i].Cost)
                            {
                                inputIsCorrect2Choose = false;
                            }
                            else
                            {
                                inputIsCorrect2Choose = false;
                            }
                        }
                        while (inputIsCorrect2Choose == false && money>0)
                        {
                            if (randomList.Count != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("要繼續選擇角色嗎?(Y/N)");
                                Console.ResetColor();

                                try
                                {
                                    switch (Console.ReadLine().ToUpper())
                                    {
                                        case "Y":
                                            inputIsCorrect2Choose = true;
                                            Console.WriteLine("\n");
                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("------------------------------------");
                                            Console.ResetColor();

                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("$:{0}", money);
                                            Console.ResetColor();

                                            foreach (int i in randomList.ToArray())
                                            {
                                                Console.WriteLine("Heroes(${0}):{1} \t({2},{3})", heroesInfoList[i].Cost, heroesInfoList[i].Name, heroesInfoList[i].Attr1, heroesInfoList[i].Attr2);
                                            }

                                            Console.ForegroundColor = ConsoleColor.Blue;
                                            Console.WriteLine("------------------------------------");
                                            Console.ResetColor();
                                            break;
                                        case "N":
                                            inputIsCorrect2Choose = true;
                                            randomList.Clear();
                                            break;
                                        default:
                                            Console.WriteLine("\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("請輸入 Y/N !");
                                            Console.WriteLine("\n");
                                            Console.ResetColor();
                                            break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    inputNumIsCorrect = false;
                                    Console.WriteLine("\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    //Console.WriteLine(ex.Message);
                                    Console.WriteLine("請輸入不超過Heroes個數的數字!");
                                    Console.ResetColor();
                                }
                            }
                            else//選完randomList中所有角色
                            {
                                inputIsCorrect2Choose = true;
                                randomList.Clear();
                            }
                        }
                    }
                    //Console.WriteLine("$:{0}", money);
                    if (money > 1)//刷新完角色後($1-->$0)會無法選擇角色，所以至少要$2
                    {
                        bool inputIsRight2Renew = false;
                        while (inputIsRight2Renew == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("是否要用 $1 刷新角色?(Y/N)");
                            Console.ResetColor();

                            switch (Console.ReadLine().ToUpper())
                            {
                                case "Y":
                                    inputIsRight2Renew = true;
                                    isWant2ChooseMore = true;
                                    money -= 1;
                                    Console.WriteLine("\n");
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("------------------------------------");
                                    Console.ResetColor();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("$:{0}", money);
                                    Console.ResetColor();
                                    break;
                                case "N":
                                    inputIsRight2Renew = true;
                                    isWant2ChooseMore = false;
                                    Monster(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList);
                                    round++;
                                    randomList.Clear();
                                    break;
                                default:
                                    inputIsRight2Renew = false;
                                    Console.WriteLine("\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("請輸入 Y/N !");
                                    Console.ResetColor();
                                    break;
                            }
                        }
                    }
                    else//money isn't enough
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your money (${0}) is not enough to choose heroes.", money);
                        Console.ResetColor();
                        Monster(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList);
                        round++;
                        randomList.Clear();
                    }
                } while (isWant2ChooseMore == true);
            }
            while (round <= 7 && money>0);
        }//end static void Heroes

        static void Check2LevelUp(int round, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList)
        {
            #region def
            bool isRemove1 = false;
            bool isRemove2 = false;
            int theRepeatNum1 = -1;
            int theRepeatNum2 = -1;
            #endregion def

            //Lv1.-->Lv.2
            foreach (var s in chooseList4Lv1.GroupBy(c => c))
            {
                //Console.WriteLine("Lv.1--" + heroesInfoList[s.Key].Name + "出現了:" + s.Count() + "次");
                if (s.Count() != 1)
                {
                    if (s.Count() == 3)
                    {

                        while (isRemove1 == false)
                        {
                            foreach (int n in chooseList4Lv1.ToArray())//n為heroesName的陣列位置
                            {
                                if (n == s.Key)
                                {
                                    //Console.WriteLine("n:{0}", n);
                                    chooseList4Lv1.Remove(n);
                                    theRepeatNum1 = n;
                                    isRemove1 = true;
                                }
                            }
                        }
                    }
                }
            }
            //Console.WriteLine("repeat1:{0}", theRepeatNum1);
            if (isRemove1 == true)
            {
                chooseList4Lv2.Add(theRepeatNum1);
            }

            //Lv2.-->Lv.3
            foreach (var s in chooseList4Lv2.GroupBy(c => c))
            {
                //Console.WriteLine("Lv.2--" + heroesInfoList[s.Key].Name + "出現了:" + s.Count() + "次");
                if (s.Count() != 1)
                {
                    if (s.Count() == 3)
                    {
                        while (isRemove2 == false)
                        {
                            foreach (int n in chooseList4Lv2.ToArray())//n為heroesName的陣列位置
                            {
                                if (n == s.Key)
                                {
                                    //Console.WriteLine("n:{0}", n);
                                    chooseList4Lv2.Remove(n);
                                    theRepeatNum2 = n;
                                    isRemove2 = true;
                                }
                            }
                        }
                    }
                }
            }
            if (isRemove2 == true)
            {
                chooseList4Lv3.Add(theRepeatNum2);
            }
        }//end static void Check2LevelUp

        static void Combination(int round, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList, List<info4Monster> monsterInfoList)
        {
            #region def
            //List<int> mergeList = new List<int>();
            int count_AD = 0;
            int count_AP = 0;
            int count_ADC = 0;
            int count_TK = 0;
            int count_Ninja = 0;
            int count_Elves = 0;
            int count_Orc = 0;
            int count_Demon = 0;
            int count_Gumiho = 0;
            string attr1 = "";
            string attr2 = "";
            #endregion def

            List<int> resultList = chooseList4Lv1.Union(chooseList4Lv2).Union(chooseList4Lv3).ToList();

            foreach (int i in resultList)
            {
                attr1 = heroesInfoList[i].Attr1;
                attr2 = heroesInfoList[i].Attr2;

                switch (attr1)
                {
                    case "戰士":
                        count_AD += 1;
                        //Console.WriteLine("count_AD:{0}", count_AD);
                        break;
                    case "法師":
                        count_AP += 1;
                        //Console.WriteLine("count_AP:{0}", count_AP);
                        break;
                    case "射手":
                        count_ADC += 1;
                        //Console.WriteLine("count_ADC:{0}", count_ADC);
                        break;
                    case "坦克":
                        count_TK += 1;
                        //Console.WriteLine("count_TK:{0}", count_TK);
                        break;
                    case "忍者":
                        count_Ninja += 1;
                        //Console.WriteLine("count_Ninja:{0}", count_Ninja);
                        break;
                    case "精靈":
                        count_Elves += 1;
                        //Console.WriteLine("count_Elves:{0}", count_Elves);
                        break;
                    case "獸人":
                        count_Orc += 1;
                        //Console.WriteLine("count_Orc:{0}", count_Orc);
                        break;
                    case "魔族":
                        count_Demon += 1;
                        //Console.WriteLine("count_Demon:{0}", count_Demon);
                        break;
                    case "九尾妖狐":
                        count_Gumiho += 1;
                        //Console.WriteLine("count_Gumiho:{0}", count_Gumiho);
                        break;
                }
                switch (attr2)
                {
                    case "戰士":
                        count_AD += 1;
                        //Console.WriteLine("count_AD:{0}", count_AD);
                        break;
                    case "法師":
                        count_AP += 1;
                        //Console.WriteLine("count_AP:{0}", count_AP);
                        break;
                    case "射手":
                        count_ADC += 1;
                        //Console.WriteLine("count_ADC:{0}", count_ADC);
                        break;
                    case "坦克":
                        count_TK += 1;
                        //Console.WriteLine("count_TK:{0}", count_TK);
                        break;
                    case "忍者":
                        count_Ninja += 1;
                        //Console.WriteLine("count_Ninja:{0}", count_Ninja);
                        break;
                    case "精靈":
                        count_Elves += 1;
                        //Console.WriteLine("count_Elves:{0}", count_Elves);
                        break;
                    case "獸人":
                        count_Orc += 1;
                        //Console.WriteLine("count_Orc:{0}", count_Orc);
                        break;
                    case "魔族":
                        count_Demon += 1;
                        //Console.WriteLine("count_Demon:{0}", count_Demon);
                        break;
                    case "九尾妖狐":
                        count_Gumiho += 1;
                        //Console.WriteLine("count_Gumiho:{0}", count_Gumiho);
                        break;
                }
                //Console.WriteLine("attr1:{0}", attr1);
                //Console.WriteLine("attr2:{0}", attr2);
            }

            #region AD
            if (count_AD == 2)
            {
                heroesInfoList[2].Attack += 20;
                heroesInfoList[5].Attack += 20;
                heroesInfoList[7].Attack += 20;
                heroesInfoList[10].Attack += 20;
                //Console.WriteLine("ad2:{0}", heroesInfoList[2].Attack);
            }
            else if (count_AD == 4)
            {
                heroesInfoList[2].Attack += 50;
                heroesInfoList[5].Attack += 50;
                heroesInfoList[7].Attack += 50;
                heroesInfoList[10].Attack += 50;
            }
            #endregion AD

            #region AP
            if (count_AP == 2)
            {
                heroesInfoList[1].Attack += 30;
                heroesInfoList[3].Attack += 30;
                heroesInfoList[9].Attack += 30;
            }
            else if (count_AP == 3)
            {
                heroesInfoList[1].Attack += 70;
                heroesInfoList[3].Attack += 70;
                heroesInfoList[9].Attack += 70;
            }
            #endregion AP

            #region ADC
            if (count_ADC == 2)
            {
                heroesInfoList[0].Attack += 30;
                heroesInfoList[6].Attack += 30;
                heroesInfoList[7].Attack += 30;
                heroesInfoList[8].Attack += 30;
            }
            else if (count_ADC == 4)
            {
                heroesInfoList[0].Attack += 70;
                heroesInfoList[6].Attack += 70;
                heroesInfoList[7].Attack += 70;
                heroesInfoList[8].Attack += 70;
            }
            #endregion ADC

            #region TK
            if (count_TK == 1)
            {
                heroesInfoList[2].Hp += 60;
                heroesInfoList[4].Hp += 60;
            }
            else if (count_TK == 2)
            {
                heroesInfoList[2].Hp += 150;
                heroesInfoList[4].Hp += 150;
            }
            #endregion TK

            #region Ninja
            if (count_Ninja == 2)
            {
                monsterInfoList[round - 1].Attack = Convert.ToInt32(monsterInfoList[round - 1].Attack * 0.9);
            }
            #endregion Ninja

            #region Elves
            if (count_Elves == 2)
            {
                monsterInfoList[round - 1].Hp = Convert.ToInt32(monsterInfoList[round - 1].Hp * 0.9);
            }
            #endregion Elves

            #region Orc
            if (count_Orc == 2)
            {
                heroesInfoList[4].Hp = Convert.ToInt32(heroesInfoList[4].Hp * 1.1);
                heroesInfoList[8].Hp = Convert.ToInt32(heroesInfoList[8].Hp * 1.1);
            }
            #endregion Orc

            #region Demon
            if (count_Demon == 1)
            {
                heroesInfoList[1].Attack += 10;
                heroesInfoList[10].Attack += 10;
                heroesInfoList[1].Hp += 25;
                heroesInfoList[10].Hp += 25;
            }
            else if (count_Demon == 2)
            {
                heroesInfoList[1].Attack += 35;
                heroesInfoList[10].Attack += 35;
                heroesInfoList[1].Hp += 70;
                heroesInfoList[10].Hp += 70;
            }
            #endregion Demon

            #region Gumiho
            if (count_Gumiho == 1)
            {
                monsterInfoList[round - 1].Attack = Convert.ToInt32(monsterInfoList[round - 1].Attack - (heroesInfoList[9].Attack * 0.1));
            }
            #endregion Gumiho

            //foreach(int i in resultList)
            //{
            //    Console.WriteLine("result:{0}、attack:{1}", heroesInfoList[i].Name, heroesInfoList[i].Attack);
            //}
        }//end static void Combination

        static void Monster(int round, int money, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList)
        {
            info4Monster theMonster = new info4Monster();
            List<info4Monster> monsterInfoList = new List<info4Monster>();

            #region monster 
            info4Monster m1 = new info4Monster();
            m1.Name = "樹苗蛙";
            m1.Attack = 45;
            m1.Defense = 0;
            m1.Hp = 600;
            monsterInfoList.Add(m1);

            info4Monster m2 = new info4Monster();
            m2.Name = "芭蕉猴";
            m2.Attack = 65;
            m2.Defense = 0;
            m2.Hp = 900;
            monsterInfoList.Add(m2);

            info4Monster m3 = new info4Monster();
            m3.Name = "智慧岩魔、力量岩魔";
            m3.Attack = 110;
            m3.Defense = 0;
            m3.Hp = 1300;
            monsterInfoList.Add(m3);

            info4Monster m4 = new info4Monster();
            m4.Name = "強化超級士兵";
            m4.Attack = 160;
            m4.Defense = 0;
            m4.Hp = 1800;
            monsterInfoList.Add(m4);

            info4Monster m5 = new info4Monster();
            m5.Name = "天空巨龍";
            m5.Attack = 230;
            m5.Defense = 0;
            m5.Hp = 2100;
            monsterInfoList.Add(m5);

            info4Monster m6 = new info4Monster();
            m6.Name = "深淵魔龍克爾德";
            m6.Attack = 300;
            m6.Defense = 0;
            m6.Hp = 2500;
            monsterInfoList.Add(m6);

            info4Monster m7 = new info4Monster();
            m7.Name = "魘魔神凱撒";
            m7.Attack = 400;
            m7.Defense = 0;
            m7.Hp = 3000;
            monsterInfoList.Add(m7);
            #endregion monster  

            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------第{0}回合對戰-------------", round);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("V.S【{0}】", monsterInfoList[round-1].Name);
            Console.ResetColor();

            Combination(round,chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList);
            Battle(round,money,chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------------");
            Console.ResetColor();
        }//end static void Monster

        static void Battle(int round, int money, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList, List<info4Monster> monsterInfoList)
        {
            Console.WriteLine("\n");
            #region check value
            //Console.WriteLine("round" + round);
            //foreach (int i in chooseList)
            //{
            //    Console.WriteLine("heroesName:{0}", heroesInfoList[i].Name);
            //    Console.WriteLine("Attack:{0}", heroesInfoList[i].Attack);
            //    Console.WriteLine("Hp:{0}", heroesInfoList[i].Hp);
            //}
            #endregion check value

            #region def
            List<int> battleList1 = new List<int>();
            List<int> battleList2 = new List<int>();
            List<int> battleList3 = new List<int>();
            bool isAllDead = false;
            bool isPlayerWin = false;
            int attackCount = 1;
            int sum4Attack_h = 0;
            int sum4Attack_m = 0;
            int hpAfterBattle_h = 0;
            string name_h = "";
            string name_m = "";
            int attack_h = 0;
            int attack_m = 0;
            int hp_h = 0;
            int hp_m = 0;
            #endregion def

            battleList1 = chooseList4Lv1.ToList();
            battleList2 = chooseList4Lv2.ToList();
            battleList3 = chooseList4Lv3.ToList();

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n第{0}次攻擊:", attackCount);
                Console.ResetColor();

                #region Heroes attack monster

                #region Lv.1
                foreach (int i in battleList1.ToArray())
                {
                    name_h = heroesInfoList[i].Name;
                    attack_h = heroesInfoList[i].Attack;

                    name_m = monsterInfoList[round - 1].Name;
                    hp_m = monsterInfoList[round - 1].Hp;

                    sum4Attack_h += attack_h;
                    //Console.WriteLine("attack_h1:{0}", attack_h);
                    if (hp_m - sum4Attack_h > 0)
                    {
                        //Console.WriteLine("sumAttack:{0}", sum4Attack_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t的血量剩下 {4}.", name_h, name_m, attack_h, name_m, hp_m - sum4Attack_h);
                    }
                    else
                    {
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t死亡.", name_h, name_m, attack_h, name_m);
                        isPlayerWin = true;
                        Judge(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList, isPlayerWin);
                        isAllDead = true;
                    }
                }
                #endregion Lv.1

                #region Lv.2
                // *1.8倍
                foreach (int i in battleList2.ToArray())
                {
                    name_h = heroesInfoList[i].Name;

                    #region 角色素質提升
                    if (i == 2)//Attack:15(阿杜恩)
                    {
                        attack_h = heroesInfoList[i].Attack + 12;
                    }
                    else if (i == 4)//Attack:10(克萊斯)
                    {
                        attack_h = heroesInfoList[i].Attack + 8;
                    }
                    else if (i == 5 || i == 7)//Attack:25(愛里、洛克)
                    {
                        attack_h = heroesInfoList[i].Attack + 15;
                    }
                    else if (i == 6 || i == 8)//Attack:35(特爾安娜絲、菲尼克)
                    {
                        attack_h = heroesInfoList[i].Attack +25;
                    }
                    else if (i == 9)//Attack:40(莉莉安)
                    {
                        attack_h = heroesInfoList[i].Attack + 28;
                    }
                    else//Attack:30(亥犽、薇拉、克里希、馬洛斯)
                    {
                        attack_h = heroesInfoList[i].Attack + 20;
                    }
                    #endregion 角色素質提升

                    name_m = monsterInfoList[round - 1].Name;
                    hp_m = monsterInfoList[round - 1].Hp;

                    sum4Attack_h += attack_h;
                    //Console.WriteLine("attack_h2:{0}", attack_h);
                    if (hp_m - sum4Attack_h > 0)
                    {
                        //Console.WriteLine("sumAttack:{0}", sum4Attack_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t的血量剩下 {4}.", name_h, name_m, attack_h, name_m, hp_m - sum4Attack_h);
                    }
                    else
                    {
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t死亡.", name_h, name_m, attack_h, name_m);
                        isPlayerWin = true;
                        Judge(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList, isPlayerWin);
                        isAllDead = true;
                    }
                }
                #endregion Lv.2

                #region Lv.3
                // *3.5倍
                foreach (int i in battleList3.ToArray())
                {
                    name_h = heroesInfoList[i].Name;

                    #region 角色素質提升
                    if (i == 2)
                    {
                        attack_h = heroesInfoList[i].Attack + 35;
                    }
                    else if (i == 4)
                    {
                        attack_h = heroesInfoList[i].Attack + 25;
                    }
                    else if (i == 5 || i == 7)
                    {
                        attack_h = heroesInfoList[i].Attack + 60;
                    }
                    else if (i == 6 || i == 8)
                    {
                        attack_h = heroesInfoList[i].Attack + 85;
                    }
                    else if (i == 9)
                    {
                        attack_h = heroesInfoList[i].Attack + 100;
                    }
                    else
                    {
                        attack_h = heroesInfoList[i].Attack + 75;
                    }
                    #endregion 角色素質提升

                    name_m = monsterInfoList[round - 1].Name;
                    hp_m = monsterInfoList[round - 1].Hp;

                    sum4Attack_h += attack_h;
                    //Console.WriteLine("attack_h3:{0}", attack_h);
                    if (hp_m - sum4Attack_h > 0)
                    {
                        //Console.WriteLine("sumAttack:{0}", sum4Attack_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t的血量剩下 {4}.", name_h, name_m, attack_h, name_m, hp_m - sum4Attack_h);
                    }
                    else
                    {
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害,\t【{3}】\t死亡.", name_h, name_m, attack_h, name_m);
                        isPlayerWin = true;
                        Judge(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList, isPlayerWin);
                        isAllDead = true;
                    }
                }           
                #endregion Lv.3
                #endregion Heroes attack monster

                Console.WriteLine("\n");

                #region Monster attacks heroes

                #region Lv.1
                foreach (int i in battleList1.ToArray())
                {
                    name_h = heroesInfoList[i].Name;
                    attack_m = monsterInfoList[round - 1].Attack;
                    sum4Attack_m = attack_m * attackCount;

                    name_m = monsterInfoList[round - 1].Name;
                    hp_h = heroesInfoList[i].Hp;

                    hpAfterBattle_h = hp_h - sum4Attack_m;
                    
                    if (hpAfterBattle_h > 0)
                    {
                        //Console.WriteLine("hpAfterBattle:{0}", hpAfterBattle_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t的血量剩下{4}", name_m, name_h, attack_m, name_h, hpAfterBattle_h);
                    }
                    else//有hero死亡
                    {
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t死亡", name_m, name_h, attack_m, name_h);
                        battleList1.Remove(i);
                    }
                }
                #endregion Lv.1

                #region Lv.2
                // *1.8倍
                foreach (int i in battleList2.ToArray())
                {
                    name_h = heroesInfoList[i].Name;
                    attack_m = monsterInfoList[round - 1].Attack;
                    sum4Attack_m = attack_m * attackCount;

                    name_m = monsterInfoList[round - 1].Name;

                    #region 角色素質提升
                    if (i == 2)//Hp:165(阿杜恩) 
                    {
                        hp_h = heroesInfoList[i].Hp + 135; 
                    }
                    else if (i == 4)//Hp:180(克萊斯) 
                    {
                        hp_h = heroesInfoList[i].Hp + 150;
                    }
                    else if (i == 5 || i == 7)//Hp:140(愛里、洛克) 
                    {
                        hp_h = heroesInfoList[i].Hp + 112;
                    }
                    else if (i == 10)//Hp:150(馬洛斯) 
                    {
                        hp_h = heroesInfoList[i].Hp + 120;
                    }
                    else//Hp:100(亥犽、薇拉、克里希、特爾安娜絲、菲尼克、莉莉安) 
                    {
                        hp_h = heroesInfoList[i].Hp + 80;
                    }
                    #endregion 角色素質提升

                    hpAfterBattle_h = hp_h - sum4Attack_m;

                    if (hpAfterBattle_h > 0)
                    {
                        //Console.WriteLine("hpAfterBattle:{0}", hpAfterBattle_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t的血量剩下{4}", name_m, name_h, attack_m, name_h, hpAfterBattle_h);
                    }
                    else//有hero死亡
                    {    
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t死亡", name_m, name_h, attack_m, name_h);
                        foreach (int a in battleList2.ToArray())
                        {
                            if (a == i)
                            {
                                battleList2.Remove(i);
                            }
                        }
                    }
                }
                #endregion Lv.2

                #region Lv.3
                // *3.5倍
                foreach (int i in battleList3.ToArray())
                {
                    name_h = heroesInfoList[i].Name;
                    attack_m = monsterInfoList[round - 1].Attack;
                    sum4Attack_m = attack_m * attackCount;

                    name_m = monsterInfoList[round - 1].Name;

                    #region 角色素質提升
                    if (i == 2)//Hp:165(阿杜恩) 
                    {
                        hp_h = heroesInfoList[i].Hp + 412;
                    }
                    else if (i == 4)//Hp:180(克萊斯) 
                    {
                        hp_h = heroesInfoList[i].Hp + 450;
                    }
                    else if (i == 5 || i == 7)//Hp:140(愛里、洛克) 
                    {
                        hp_h = heroesInfoList[i].Hp + 350;
                    }
                    else if (i == 10)//Hp:150(馬洛斯) 
                    {
                        hp_h = heroesInfoList[i].Hp + 375;
                    }
                    else//Hp:100(亥犽、薇拉、克里希、特爾安娜絲、菲尼克、莉莉安) 
                    {
                        hp_h = heroesInfoList[i].Hp + 250;
                    }
                    #endregion 角色素質提升

                    hpAfterBattle_h = hp_h - sum4Attack_m;

                    if (hpAfterBattle_h > 0)
                    {
                        //Console.WriteLine("hpAfterBattle:{0}", hpAfterBattle_h);
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t的血量剩下{4}", name_m, name_h, attack_m, name_h, hpAfterBattle_h);
                    }
                    else//有hero死亡
                    {
                        Console.WriteLine("【{0}】\t對\t【{1}】\t造成 {2} 傷害，\t【{3}】\t死亡", name_m, name_h, attack_m, name_h);
                        foreach (int a in battleList3.ToArray())
                        {
                            if (a == i)
                            {
                                battleList3.Remove(i);
                            }
                        }
                    }
                }
                #endregion Lv.3

                if (battleList1.Count == 0 && battleList2.Count==0 && battleList3.Count==0)
                {
                    isPlayerWin = false;
                    Judge(round, money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList, monsterInfoList, isPlayerWin);
                    isAllDead = true;
                }
                #endregion Monster attack heroes

                attackCount++;
            }
            while (isAllDead == false);

        }//end static void Battle

        static void Judge(int round,int money, List<int> chooseList4Lv1, List<int> chooseList4Lv2, List<int> chooseList4Lv3, List<info4Heroes> heroesInfoList, List<info4Monster> monsterInfoList,bool isPlayerWin)
        {
            int finalMoney = 0;
            Console.WriteLine("\n");
            if (isPlayerWin == true)
            {
                if (round == 7)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("WIN.玩家取得最終勝利!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("第{0}回合玩家勝利!", round);
                    Console.ResetColor();
                    if (round < 3)
                    {
                        finalMoney = money + round + 5;
                    }
                    else if (round < 5)
                    {
                        finalMoney = money + round + 7;
                    }
                    else if(round <= 7)
                    {
                        finalMoney = money + round + 10;
                    }
                    money = finalMoney;
                    //Console.WriteLine("money:{0}", money);
                    Heroes(round + 1,money, chooseList4Lv1, chooseList4Lv2, chooseList4Lv3, heroesInfoList);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GAME OVER.電腦勝利!", round);
                Console.ResetColor();
                Console.ReadLine();
            }
            Console.ReadLine();
            System.Environment.Exit(0);
        }////end static void Judge

    }//end class Program
}//end namespace
