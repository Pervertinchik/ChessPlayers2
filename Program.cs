using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игроки_в_шахматы
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Russian_players("Top100ChessPlayers.csv");
            
            Console.ReadKey();
        }

        static void Russian_players(string path)
        {
            List<ChessPlayer> list = File.ReadAllLines(path)


           .Skip(1)   //Пропускаем первую строчку, т.к. она идёт как описание
           .Select(x => ChessPlayer.ParseFideCsv(x)) //Производит трансформацию элемента string в тип IEnumerable.ChessPlayer
           .Where(player => player.Country == "RUS")  //Проверяет элементы,  возвращая true только тем элементам, которые хочет видеть

           .OrderBy(player => player.B_Year) //Отсортировать по    убыванию по рейтингу
             .Take(1000)

            .ToList();

            
           


                       Console.WriteLine($"The oldest Russian: {list.Min(x => x.B_Year)}");
                       Console.WriteLine($"The youngest Russian: {list.Max(x => x.B_Year)}");

            Console.WriteLine($"Total Russian players: {list.Count}\n");

            for (int aa = list.Count -1; aa >= 0; aa--)
            {
                Console.WriteLine(list[aa]);
            }

            







        }

    }





}
