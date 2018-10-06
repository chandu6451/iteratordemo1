using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IteratorDemo1
{
    public class DayofTheWeek : IEnumerable
    {
        string[] m_day = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        //public string GetDays()
        //{
        //    for (int i = 0; i < m_day.Length; i++)
        //    {
        //        return m_day[i];
        //    }

        //    return "";
        //}

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < m_day.Length; i++)
            {
                yield return m_day[i];
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DayofTheWeek week = new DayofTheWeek();

            foreach (var item in week)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
        }
    }
}
