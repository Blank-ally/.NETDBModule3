namespace Module3
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
          /* 
            Console.WriteLine($"{pi:p2}");
            Console.WriteLine($"{pi:c2}");
          //utc universal time code which will
            var now = DateTime.UtcNow;*/


           var date = DateTime.Now;

           Console.WriteLine($"1. {date,40:MMMM d, yyyy}");
           Console.WriteLine($"2.{date:yyyy.MM.dd}");
           Console.WriteLine($"3.Day {date:dd} of { date:MMMM,yyyy}");
           Console.WriteLine($"4. Year:{date:yyyy} Month:{date:MM} Day:{date:dd} ");
           Console.WriteLine($"5.{date,10:ddddd}");
           Console.WriteLine($"6.{date,10:t}{date,10:ddddd}");
           Console.WriteLine($"7.h:{date:hh},m:{date:mm},s:{date:ss}");
           Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");

           var pi = Math.PI;
           Console.WriteLine($"{pi:c2}");
           Console.WriteLine($"{pi,10:N3}");
        }



    }
    
}