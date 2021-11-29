using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Plant[] plants = { new Plant("flower"), new Plant("bush"), new Plant("tree"), new Plant("rose"), new Plant("grass") };

            Garden gar1 = new Garden();
            gar1.Add(plants[1]);
            gar1.Add(plants[2]);
            gar1.Add(plants[3]);

            Garden gar2 = new Garden();
            gar1.Add(plants[0]);
            gar1.Add(plants[3]);
            gar1.Add(plants[4]);

            Garden gar3 = new Garden();
            gar1.Add(plants[1]);
            gar1.Add(plants[4]);
            gar1.Add(plants[2]);

            HashSet<Garden> gardenList = new HashSet<Garden>();
            gardenList.Add(gar1);
            gardenList.Add(gar2);
            gardenList.Add(gar3);
            gardenList.Add(gar1);

            foreach (Garden g in gardenList)
            {
                Console.WriteLine(g.Contains(plants[1]));
                Console.WriteLine(g.IndexOf(plants[1]));
            }
            #endregion
            #region Task2
            HashSetCollection<Int32> intHashSetCollection = new HashSetCollection<Int32>();
            intHashSetCollection.AddElement(4);
            intHashSetCollection.AddElement(6);
            intHashSetCollection.AddElement(2);
            intHashSetCollection.AddElement(4);
            intHashSetCollection.GetElements();

            HashSetCollection<String> stringHashSetCollection = new HashSetCollection<String>();
            stringHashSetCollection.AddElement("hello");
            stringHashSetCollection.AddElement("hello");
            stringHashSetCollection.AddElement("world");
            stringHashSetCollection.AddElement("!");

            ListCollection<String> listCollection = new ListCollection<string>();
            for (int i = 0; i < stringHashSetCollection.Length; i++)
            {
                listCollection.AddElement(stringHashSetCollection.GetElementByIndex(i));
            }
            listCollection.GetElements();
            Console.WriteLine("index: " + listCollection.FindElement("world"));
            #endregion
            #region Task3
            ObservableCollection<Plant> plant = new ObservableCollection<Plant>
            {
                plants[0],
                plants[1],
                plants[2]
            };

            plant.CollectionChanged += Plants_CollectionChanged;

            plant.Add(plants[3]);
            plant.RemoveAt(1);

            foreach (Plant p in plant)
            {
                Console.WriteLine(p.Name);
            }
        }

        private static void Plants_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Plant newPlant = e.NewItems[0] as Plant;
                    Console.WriteLine($"New object: {newPlant.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Plant oldPlant = e.OldItems[0] as Plant;
                    Console.WriteLine($"Removed: {oldPlant.Name}");
                    break;
            }
        }
        #endregion
    }
}
