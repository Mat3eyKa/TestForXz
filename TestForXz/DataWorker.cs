using System.Collections.Generic;
using System.Linq;
using TestForXz.Models;

namespace TestForXz
{
    internal class DataWorker
    {
        public static IEnumerable<Person> Seeeder()
        {
            List<Person> list = new()
            {
                new Person{Id = 1, Name="Саша", Amount = 111.1},
                new Person{Id = 2, Name="Петя", Amount = 122.1},
                new Person{Id = 3, Name="Вася", Amount = 133.1},
                new Person{Id = 4, Name="Саша", Amount = 144.1},
                new Person{Id = 5, Name="Дима", Amount = 155.1},
                new Person{Id = 6, Name="Саша", Amount = 166.1},
                new Person{Id = 7, Name="Мотя", Amount = 177.1},
                new Person{Id = 8, Name="Саша", Amount = 188.1},
                new Person{Id = 9, Name="Саша", Amount = 199.1},
                new Person{Id = 10, Name="Мотя", Amount = 200.1},
                new Person{Id = 11, Name="Саша", Amount = 211.1},
                new Person{Id = 12, Name="Вася", Amount = 222.1},
                new Person{Id = 13, Name="Саша", Amount = 233.1},
                new Person{Id = 14, Name="Саша", Amount = 244.1},
                new Person{Id = 15, Name="Дима", Amount = 255.1},
                new Person{Id = 16, Name="Саша", Amount = 266.1},
                new Person{Id = 17, Name="Саша", Amount = 277.1},
                new Person{Id = 18, Name="Саша", Amount = 288.1},
                new Person{Id = 19, Name="Саша", Amount = 299.1},
                new Person{Id = 20, Name="Саша", Amount = 300.1},
            };
            DataUpdeter(list);
            return list;
        }
        private static void DataUpdeter(IEnumerable<Person> people)
        {
            // не сосвсем понял выбрать и обновить всех пользователей где Name равна "Саша" или только обновить где Name равна "Саша"
            people.Where(x => x.Name == "Саша").ToList().ForEach(x => x.Amount = x.Id * 5 / x.Id - 3);
        }
    }
}
