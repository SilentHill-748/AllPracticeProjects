using System;
using System.Collections.Generic;

namespace alg_6_lab
{
    /*
     * Поступающие запросы ставятся в соответствующие приоритетам очереди. Сначала обрабатываются задачи из очереди F0. 
     * Если она пуста, можно обрабатывать задачи из очереди F1. Если и она пуста, то можно обрабатывать задачи из очереди F2. 
     * Если все очереди пусты, то система находится в ожидании поступающих задач (процессор свободен), либо в режиме обработки 
     * предыдущей задачи (процессор занят). 
     * 
     * Если поступает задача с более высоким приоритетом, чем обрабатываемая в данный момент, то обрабатываемая помещается в стек, 
     * если она выполнена менее чем на половину по времени, и может обрабатываться тогда и только тогда, когда все задачи с более 
     * высоким приоритетом уже обработаны.
     */

    public class Program
    {
        static void Main()
        {
            Queue<object[]> F = new Queue<object[]>();
            Queue<object[]> F2 = new Queue<object[]>();
            Queue<object[]> F3 = new Queue<object[]>();
            Stack<object[]> S = new Stack<object[]>();
            Random rand = new Random();

            object[] task = new object[4]; //задача с 3 параметрами (имя/приоритет/время исполнения/для проверки времени)
            object[] processor = new object[4]; // Массив на 3 элемента - задача с 3 параметрами.
            int tasks; // заданное число задач
            int counter = 0; // счетчик сщзданных задач.
            int compTask = 0; // счетчик выполненных задач.
            int prior; // приоритет задачи
            int time; // время задачи.

            Console.WriteLine("Введите число задач.");
            tasks = byte.Parse(Console.ReadLine());
            do
            {
                //генерируем задачу, заполняем ее в свою очередь.
                if( counter < tasks )
                {
                    prior = (byte)rand.Next(0, 3);
                    time = (byte)rand.Next(2, 8);
                    task = GenerateTask(task, prior, counter, time); // метод генерирует задачу
                    SetQueue(F, F2, F3, task);
                    counter++;
                }

                //основное тело программы: исходя из условий кидаем задачу из очереди в процессор или в стек
                if( F.Count > 0 ) // 0 приор
                {
                    //если проц пуст, кидаем задачу в него, т.к. первая очередь имеет самые приоритетные задачи.
                    if( processor[0] == null )
                    {
                        GetTaskToProcessor(F, "F0", ref processor);
                    }
                    else
                    {
                        //проверяем, приоритетна ли задача в проце, чем в очереди и время её обраотки
                        if ((int)processor[1] < (int)ReadF(F)[1] && (int)processor[2] > (int)processor[3] / 2)
                        {
                            GetTaskToStack(F, S, "F0", ref processor);
                        }    
                    }
                }

                if( F2.Count > 0 ) // 1 приор
                {
                    if( S.Count == 0 )
                    {
                        if (processor[0] == null)
                        {
                            GetTaskToProcessor(F2, "F1", ref processor);
                        }
                        else
                        {
                            if ((int)processor[1] < (int)ReadF(F2)[1] && (int)processor[2] > (int)processor[3] / 2)
                            {
                                GetTaskToStack(F2, S, "F1", ref processor);
                            }
                        }
                    }
                    else
                    {
                        if( processor[0] == null )
                        {
                            if ((int)ReadS(S)[1] > (int)ReadF(F2)[1])
                            {
                                processor = GetS(S);
                            }
                            else
                            {
                                processor = GetF(F2);
                            }
                        }
                    }
                }

                if( F3.Count > 0 ) // 2 приор
                {
                    if( S.Count == 0 )
                    {
                        if (processor[0] == null)
                        {
                            GetTaskToProcessor(F3, "F2", ref processor);
                        }
                        else
                        {
                            int x = (int)processor[3] / 2;
                            int y = (int)processor[2];
                            if ((int)processor[1] < (int)ReadF(F3)[1] && (int)processor[2] > (int)processor[3] / 2)
                            {
                                GetTaskToStack(F3, S, "F2", ref processor);
                            }
                        }
                    }
                    else
                    {
                        if (processor[0] == null)
                        {
                            if ((int)ReadS(S)[1] > (int)ReadF(F3)[1])
                            {
                                processor = GetS(S);
                            }
                            else
                            {
                                processor = GetF(F3);
                            }
                        }
                    }
                }

                //на случай, если в стеке останутся задачи при пустых очередях.
                if( S.Count > 0 )
                {
                    if (processor == null)
                        GetTaskFromStack(S, ref processor);
                }

                Work(ref processor, ref compTask);
            }
            while ( compTask != tasks );

            Console.WriteLine("Работа программы завершена успешно!");
        }

        // генерируем задачу
        static object[] GenerateTask(object[] task, int prior, int count, int time)
        {
            task = new object[4] { $"Task_{count}", prior, time, time };
            Console.WriteLine($"Сгенерирована задача {task[0]}.");
            return task;
        }

        //заполняем в очередь
        static void SetQueue(Queue<object[]> F, Queue<object[]> F2, Queue<object[]> F3, object[] task)
        {
            switch( (int)task[1] )
            {
                case 0:
                    {
                        task[1] = 2;
                        PutF(F, task);
                        Console.WriteLine($"Задача {task[0]} помещена в очередь F0");
                    }
                    break;
                case 1:
                    {
                        PutF(F2, task);
                        Console.WriteLine($"Задача {task[0]} помещена в очередь F1");
                    }
                    break;
                case 2:
                    {
                        task[1] = 0;
                        PutF(F3, task);
                        Console.WriteLine($"Задача {task[0]} помещена в очередь F2");
                    }
                    break;
            }
        }

        //Если очередь не пуста, то метод закидывает в процессор задачу исходя из условий работы.
        static void GetTaskToProcessor(Queue<object[]> F, string numF, ref object[] processor)
        {
            processor = GetF(F);
            Console.WriteLine($"Задача {processor[0]} помещена в процессор из очереди {numF}.");
        }

        //если проц занят, то метод выполняет выкидывание задачи из проца в стек, а из очереди в проц, при истинности условия в программе
        static void GetTaskToStack(Queue<object[]> F, Stack<object[]> S, string numF, ref object[] processor)
        {
            PutS(S, processor);
            Console.WriteLine($"Задача {processor[0]} помещена в стек.");
            processor = GetF(F);
            Console.WriteLine($"Задача {processor[0]} помещена в процессор из очереди {numF}.");
        }

        static void GetTaskFromStack(Stack<object[]> S, ref object[] processor)
        {
            processor = GetS(S);
            Console.WriteLine($"Задача {processor[0]} перемещена со стека в процессор.");
        }

        //Метод реализует работу процессора, т.е. снижает время обработки задачи до 0
        static void Work(ref object[] processor, ref int count)
        {
            int time;
            if( processor[0] != null)
            {
                if ((int)processor[2] != 0)
                {
                    time = (int)processor[2];
                    time--;
                    processor[2] = time;
                }
                else
                {
                    Console.WriteLine($"Задача {processor[0]} обработана процессором.");
                    processor = new object[4];
                    count++;
                }
            }
            else
            {
                count++;
            }
        }


        // далее идут перечисления действий над очередями/стеком.
        static object[] ReadF(Queue<object[]> F)
        {
            return F.Peek();
        }

        static object[] GetF(Queue<object[]> F)
        {
            return F.Dequeue();
        }

        static void PutF(Queue<object[]> F, object[] task)
        {
            F.Enqueue(task);
        }

        static void DoneF(Queue<object[]> F)
        {
            F = null; //разрываем ссылку к объекту очереди. В последствии объекты очереди будут удалены.
        }

        static object[] ReadS(Stack<object[]> S)
        {
            return S.Peek();
        }

        static object[] GetS(Stack<object[]> S)
        {
            return S.Pop();
        }

        static void PutS(Stack<object[]> S, object[] task)
        {
            S.Push(task);
        }

        static void DoneS(Stack<object[]> S)
        {
            S = null;
        }
    }
}
