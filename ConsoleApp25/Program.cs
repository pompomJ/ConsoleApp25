using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; true; i++)
            {
                if (i < 8)
                {
                    continue; //カウンターを更新してループの先頭に戻る
                }
                else if (i == 10)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
