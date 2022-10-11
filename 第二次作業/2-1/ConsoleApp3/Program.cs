using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] curriculum = new string[8, 7] ;
            string name;
            string[] tran ;
            int week, begin, end;
            Boolean addok = true;
            Boolean delete = false;
            Dictionary<string, int[]> classname = new Dictionary<string, int[]>();
            while (true)
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式 ");
                Console.Write("請輸入數字選擇功能：");
                int ask = int.Parse(Console.ReadLine());
                switch (ask)
                {
                    case 1:
                        Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
                        tran = Console.ReadLine().Split(' ');
                        name = tran[0];
                        week = Int32.Parse(tran[1]);
                        begin = Int32.Parse(tran[2]);
                        end = Int32.Parse(tran[3]);
                        for(int i = begin - 1 ; i < end; i++)
                        {
                            if(classname.ContainsKey(name))
                            {
                                Console.WriteLine("課程重複！\n");
                                addok = false;
                                break;
                            }
                            else if(curriculum[i , week] != null)
                            {
                                Console.WriteLine("課程衝堂！\n");
                                addok = false;
                                break;
                            }
                        }
                        if (addok)
                        {
                            for(int i = begin - 1; i < end; i++)
                            {
                                curriculum[i, week] = name;
                            }
                            Console.WriteLine("成功加入課程！\n");
                            classname.Add(name, null);
                        }
                        addok = true;
                        break;
                    case 2:
                        Console.Write("請輸入要刪除的課程代號：" );
                        name = Console.ReadLine();
                        for(int i = 0; i < 8; i++)
                        {
                            for(int j = 0; j < 7; j++)
                            {
                                if(curriculum[ i , j ] == name)
                                {
                                    curriculum[i, j] = null;
                                    delete = true;
                                }                                
                            }
                        }
                        if (delete)
                        {
                            Console.WriteLine("成功刪除課程：" + name + "\n");
                        }
                        else if (!delete)
                        {
                            Console.WriteLine("課程 " + name + " 不在課表中\n");
                        }
                        delete = false;
                        break;
                    case 3:
                        for(int i = 0; i < 9; i++)
                        {
                            for(int j = 0; j < 8; j++)
                            {
                                if(j == 0 && i == 0)
                                {
                                    Console.Write("      ");
                                }
                                else if(j == 0 && i!= 0)
                                {
                                    Console.Write(i.ToString().PadRight(6));
                                }
                                else if(i == 0 && j != 0){
                                    if(j == 1) { Console.Write("Sun   "); }
                                    if(j == 2) { Console.Write("Mon   "); }
                                    if(j == 3) { Console.Write("Tue   "); }
                                    if(j == 4) { Console.Write("Wed   "); }
                                    if(j == 5) { Console.Write("Thu   "); }
                                    if(j == 6) { Console.Write("Fri   "); }
                                    if(j == 7) { Console.Write("Sat   "); }
                                }
                                else if(i != 0 && j != 0)
                                {
                                    if(curriculum[i - 1 , j - 1 ] != null)
                                    {
                                        Console.Write(curriculum[i - 1, j - 1].PadRight(6));
                                    }
                                    else
                                    {
                                        Console.Write("".PadRight(6));
                                    }
                                   
                                }
                                if( j == 7)
                                {
                                    Console.Write("\n");
                                }
                            }
                        }
                        break;
                    case 4:
                        int num = 0 ;
                        for(int i = 0; i < 8; i++)
                        {
                            for(int j = 0; j < 7; j++)
                            {
                                if(curriculum[i , j] != null)
                                {
                                    num += 1;
                                }
                            }
                        }
                        Console.WriteLine(num);
                        break;
                    case 5:
                        return;
                }
            }
        }
    }
}
