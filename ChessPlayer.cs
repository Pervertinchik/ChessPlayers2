using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игроки_в_шахматы
{



    public class ChessPlayer
    {
        public int Rank { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public int Games { get; set; }
        public int B_Year { get; set; }

        public override string ToString()
        {
            return $"Full Name {First_name + " " + Last_name}, Rating = {Rating}, from {Country}, born {B_Year }";
        }

        public static ChessPlayer ParseFideCsv(string line)

        {

            string[] parts = line.Split(';');  //Разделение в файле идёт через ;

            return new ChessPlayer()

            {

                Rank = int.Parse(parts[0]),

                Last_name = parts[1].Split(',')[0].Trim(), //frim чтобы обрезать

                First_name = parts[1].Split(',')[1].Trim(),

                Country = parts[3],

                Rating = int.Parse(parts[4]),

                B_Year = int.Parse(parts[6])

            };


        }
    }
}
