﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Влади е студент, живее в София и си ходи от време на време до родния град.Той е много запален по
//волейбола, но е зает през работните дни и играе волейбол само през уикендите и в празничните дни.Влади
//играе в София всяка събота, когато не е на работа и не си пътува до родния град, както и в 2/3 от
//празничните дни.Той пътува до родния си град h пъти в годината, където играе волейбол със старите си
//приятели в неделя.Влади не е на работа 3/4 от уикендите, в които е в София.Отделно, през високосните
//години Влади играе с 15% повече волейбол от нормалното.

//Приемаме, че годината има точно 48 уикенда, подходящи за волейбол.

//Напишете програма, която изчислява колко пъти Влади е играл волейбол през годината. Закръглете
//резултата надолу до най-близкото цяло число (например 2.15  2; 9.95  9).
//Входните данни се въвеждат от потребителя, в следния вид:
// Първият ред съдържа думата &quot;leap&quot; (високосна година) или &quot;normal&quot; (невисокосна).
// Вторият ред съдържа цялото число p – брой празници в годината(които не са събота и неделя).
// Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.


namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weekendInSofia = 48 - h;
            //h
            double volleyballHoliday = p * (2.0 / 3);
            double volleyballWeekend = weekendInSofia * (3.0 / 4);
            double vladiPlays = h + volleyballHoliday + volleyballWeekend;
            double vladiPlaysLeap = vladiPlays + (0.15 * vladiPlays);

            if (year == "leap")
            {
                Console.WriteLine($"{Math.Floor(vladiPlaysLeap)}");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(vladiPlays)}");
            }
        }
    }
}
