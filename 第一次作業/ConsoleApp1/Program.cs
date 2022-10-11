using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static int inputMoney = 0, allMoney = 0, oneOuput = 0, allOutput = 0;
        static Dictionary<string,int> outputMoney = new Dictionary<string, int>();
        static List<string> items = new List<string>();    //自行新增的儲存陣列
        static void Main(string[] args)
        {
            while (true)
            { 
                Console.Write("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式 \n");
                Console.Write("輸入數字選擇功能： ");
                int ask = int.Parse(Console.ReadLine());
                switch (ask)
                {
                    case 1:
                        Console.Write("輸入金額：");
                        try
                        {
                            Income(inputMoney = int.Parse(Console.ReadLine()));
                        }
                        catch
                        {
                            Console.Write("請輸入數字\n");
                        }
                        Console.Write("\n");
                        break;
                    case 2:
                        Output();
                        
                        break;
                    case 3:
                        if(items.Count == 5)
                        {
                            Console.Write("已無法再新增支出項目\n\n");
                        }
                        else
                        {
                            Console.Write("輸入項目名稱： ");
                            Additem(Console.ReadLine());
                            Console.Write("\n");
                        }                       
                        break;
                    case 4:
                        if (!items.Any())
                        {
                            Console.Write("已無法再刪除支出項目\n");
                        }
                        else
                        {
                            Console.Write("輸入項目名稱：");
                            Delete(Console.ReadLine());
                        }
                        break;
                    case 5:
                        Rate();
                        break;
                    case 6:
                        Console.Write("目前總支出" + allOutput + "\n");
                        Console.Write("輸入要查詢的項目：");
                        string tem = Console.ReadLine();  /////////////要查詢的項目
                        if (!items.Contains(tem))
                        {
                            Console.Write("此項目不存在");
                        }
                        else
                        {
                            Console.Write(tem + "：" + outputMoney[tem] + "\n");
                        }
                        break;
                    case 7:

                        Console.Write("剩餘金額為：" + (allMoney - allOutput)+ "\n");
                        Console.Write("\n");
                        break;
                    case 8: return;
                }
            }
        }

        

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        private static void Income(int inputMoney)
        {
            if(inputMoney < 0)
            {
                Console.Write("收入不可為負數\n");
            }
            else
            {
                allMoney += inputMoney;
            }
        }





        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        private static void Rate()
        {
            for(int i = 0; i < items.Count; i++)
            {   
                if(allOutput == 0)
                {
                    allOutput = 1;
                    Console.Write("(" + (i + 1) + ")"+ items[i] + "：" + (double)outputMoney[items[i]] / allOutput * 100 + "%");
                    Console.Write("\n");
                    allOutput = 0;
                }
                else
                {
                    Console.Write("(" + (i + 1) + ")" + items[i] + "：" + (double)outputMoney[items[i]] / allOutput * 100 + "%");
                    Console.Write("\n");
                }
                
            }
            Console.Write("\n");
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Additem(String item)       //自行新增
        {
            if (!items.Contains(item))  //如果沒搜到
            {
                items.Add(item);
                outputMoney.Add(item, 0);                //////////////////創一個項目，但沒有錢

            }
            else
            {
                Console.Write("支出項目已存在 ");
                Console.Write(" \n");
            }
                
        }

        /// ///////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Output(int type, int total)     ///////////////////type是第幾個項目，total是錢錢
        {
            if (allMoney - total < 0)
            {
                Console.Write("存款不足\n\n");
            }
            else
            {
                allOutput += total;
                outputMoney[items[type - 1]] += total;                //////////////////dictionary[value]
            }

        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////////

        private static void Output()
        {
            if (!items.Any())
            {
                Console.Write("請新增支出項目 \n\n");
            }
            else
            {
                for(int i = 0; i < items.Count; i++)
                {
                    Console.Write("(" + (i+1) + ")" + items[i]);
                }
                Console.Write("\n輸入數字選擇支出項目：");
                int ask = int.Parse(Console.ReadLine());
                if(ask > items.Count)
                {
                    Console.Write("此數字不在範圍中\n\n");
                }
                else
                {
                    Console.Write("輸入支出金額： ");
                    oneOuput = int.Parse(Console.ReadLine());   //好像是錢錢
                    Output(ask, oneOuput); //不小心多載了
                    Console.Write("\n");
                }            
            }
        }


        /// ///////////////////////////////////////////////////////////////////////////////////////////////////
        private static void Delete(string item)
        {
            
            if (items.Contains(item))
            {
                allOutput -= outputMoney[item];
                outputMoney.Remove(item);
                items.Remove(item);
                Console.Write("\n");
            }
            else
            {
                Console.Write("此項目不存在\n");
            }
        }
    }


}

