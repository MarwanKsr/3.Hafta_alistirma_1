using System;

namespace alistirma
{
    class Program
    {
        static void Main(string[] args)
        {   Console.Write("istedigin cumleyi giriniz: ");
            string sen = Console.ReadLine();
            int word=0, sart = 0, bas=0;
            do
            {
                for (int i = 0; i < sen.Length; i++)
                {
                    if (sen[i] != ' ')
                    {
                        sart++;
                        bas = i+1;
                        word = 1;
                        break;
                    }
                }
            } while (sart == 0);
            for (int i=bas; i<sen.Length; i++)
            {
                
                if (sen[i-1] == ' ' && sen[i] != ' ')
                {
                    word++;
                }
            }
            Console.WriteLine("cumledeki kelime sayisi " + word);
        }
    }
}