using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>
            {
                new Entity() { Id = 1, ParentId = 0, Name = "Root entity" },
                new Entity() { Id = 2, ParentId = 1, Name = "Child of 1 entity" },
                new Entity() { Id = 3, ParentId = 1, Name = "Child of 1 entity" },
                new Entity() { Id = 4, ParentId = 2, Name = "Child of 2 entity" },
                new Entity() { Id = 5, ParentId = 4, Name = "Child of 4 entity" }
            };

            var FinalDictionary = SomeMet(entities);

            foreach (var dict in FinalDictionary)
            {
                Console.WriteLine($"Key: {dict.Key}  Value count: {dict.Value.Count}");
            }
        }

        static Dictionary<int, List<Entity>> SomeMet (List<Entity> list)
        {
            Dictionary<int, List<Entity>> dict = new Dictionary<int, List<Entity>>();

            for (int key = 0; key < list.Count; key++)
            {
                var value = list.Where(x => x.ParentId == key).ToList();
                if (value.Count() != 0) 
                { 
                    dict.TryAdd(key, value);
                }
            }

            return dict;
        }

    }
}
