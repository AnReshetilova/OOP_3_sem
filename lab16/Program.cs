using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

namespace OOP_Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
           // Task7();
            Console.WriteLine();
            Task8();
        }
        /// <summary>
        /// Используя TPL создайте длительную по времени задачу (на основе
        /// Task) на выбор:
        ///умножение вектора размера 100000 на число,
        /// </summary>
        static void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Task task = new Task(() => MulByVector(10000));
                task.Start();
                Console.WriteLine($"id: {task.Id}, статус: {task.Status}");
                task.Wait();
                Console.WriteLine($"id: {task.Id}, статус: {task.Status}");
                sw.Stop();
                Console.WriteLine($"#1: {sw.ElapsedMilliseconds}ms");
                Console.WriteLine();
            }
        }
        static void MulByVector(int k, object ob = null)
        {
            Random random = new Random();
            List<int> vector = new List<int>();
            for (int i = 0; i < k; i++)
            {
                vector.Add(random.Next(1, 10));
            }
            vector = vector.Select(x => x * 10).ToList();
        }
        /// <summary>
        /// Реализуйте второй вариант этой же задачи с токеном отмены
        ///CancellationToken и отмените задачу
        /// </summary>
        static void Task2()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            Task task = Task.Run(() => MulByVector(1000, cancellation), cancellation.Token);
            try
            {
                cancellation.Cancel();
                task.Wait();
            }
            catch (Exception)
            {
                if (task.IsCanceled)
                    Console.WriteLine("Задача отменена");
            }
        }
        /// <summary>
        /// Создайте три задачи с возвратом результата и используйте их для
        ///выполнения четвертой задачи.Например, расчет по формуле.
        /// </summary>
        static void Task3()
        {
            Task<int> first = new Task<int>(() => new Random().Next(0, 2) * 8);
            Task<int> second = new Task<int>(() => new Random().Next(0, 3) * 10);
            Task<int> third = new Task<int>(() => new Random().Next(3, 6));

            first.Start();
            second.Start();
            third.Start();
            first.Wait();
            second.Wait();
            third.Wait();

            Task<int> number = new Task<int>(() => first.Result + second.Result + third.Result);
            number.Start();
            Console.WriteLine($"Сумма результатов: {number.Result}");
        }
        /// <summary>
        /// Создайте задачу продолжения (continuation task) в двух вариантах:
        ///1) C ContinueWith - планировка на основе завершения множества
        ///предшествующих задач
        ///2) На основе объекта ожидания и методов GetAwaiter(),GetResult();
        /// </summary>
        static void Task4()
        {
            Task<int> task4 = new Task<int>(() => 15 * 6 + 15 + 88);
            Task show = task4.ContinueWith(sum => Console.WriteLine($"Cумма = {sum.Result}"));
            task4.Start();
            show.Wait();

            Task<double> sqrt = new Task<double>(() => Math.Sqrt(81));
            TaskAwaiter<double> awaiter = sqrt.GetAwaiter();
            awaiter.OnCompleted(() => Console.WriteLine($"Корень 81: {sqrt.Result}"));
            sqrt.Start();
            sqrt.Wait();
            awaiter.GetResult();
            Thread.Sleep(10);
        }
        /// <summary>
        /// Используя Класс Parallel распараллельте вычисления циклов For(),
        /// ForEach(). Например, на выбор: обработку(преобразования)
        ///последовательности, генерация нескольких массивов по 1000000
        ///элементов, быстрая сортировка последовательности, обработка текстов
        ///(удаление, замена). Оцените производительность по сравнению с
        ///обычными циклами
        /// </summary>
        static void Task5()
        {
            int[] arr1 = new int[100000];
            int[] arr2 = new int[100000];
            int[] arr3 = new int[100000];

            void Fill(int x)
            {
                arr1[x] = x;
                arr2[x] = x;
                arr3[x] = x;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, 100000, Fill);
            sw.Stop();
            Console.WriteLine($"Параллельный for: {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            for (int i = 0; i < 100000; i++)
            {
                arr1[i] = i;
                arr2[i] = i;
                arr3[i] = i;
            }
            sw.Stop();
            Console.WriteLine($"Нормальный for: {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            Parallel.ForEach(arr1, i => i = 1);
            Parallel.ForEach(arr2, i => i = 1);
            Parallel.ForEach(arr3, i => i = 1);
            sw.Stop();
            Console.WriteLine($"Параллельный foreach: {sw.ElapsedMilliseconds}ms");
        }
        /// <summary>
        /// Используя Parallel.Invoke() распараллельте выполнение блока
        ///операторов
        /// </summary>
        static void Task6()
        {
            int count = 0;
            int maxCount = 100;
            Parallel.Invoke(
            () =>
            {
                while (count < maxCount)
                {
                    count++;
                    Console.WriteLine($"1: {count}");
                }
            },
            () =>
            {
                while (count < maxCount)
                {
                    count++;
                    Console.WriteLine($"2: {count}");
                }
            });
        }
        static void Task7()
        {
            BlockingCollection<string> bc = new BlockingCollection<string>(5);

            Task[] sellers = new Task[10]
            {
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("1"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("2"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("3"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("4"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("5"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("6"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("7"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("8"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("9"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("10"); } })
            };

            Task[] consumers = new Task[5]
            {
                new Task(() => { while (true) { Thread.Sleep(100); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(200); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(300); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(400); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Take(); } })
            };

            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running) i.Start();

            foreach (var i in consumers)
                if (i.Status != TaskStatus.Running) i.Start();

            int count = 0;
            while (true)
            {
                if (bc.Count != count && bc.Count != 0)
                {
                    count = bc.Count;
                    Thread.Sleep(100);
                    Console.WriteLine("Склад");
                    foreach (var i in bc)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        /// <summary>
        /// Используя async и await организуйте асинхронное выполнение любого
        ///метода
        /// </summary>
        static void Task8()
        {
            void Factorial()
            {
                int result = 1;
                for (int i = 1; i <= 5; i++)
                    result *= i;
                Thread.Sleep(100);
                Console.WriteLine($"5! = {result}");
            }
            async void FactorialAsync()
            {
                await Task.Run(() => Factorial());
            }

            FactorialAsync();
            Console.ReadKey();
        }
    }
}
