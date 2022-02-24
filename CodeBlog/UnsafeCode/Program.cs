unsafe
{
    int x = 10;

    int[] nums = { 1,2,3,4,5 };
    int* pointerArr = stackalloc int[9];
    int* itemArray = pointerArr;

    for (int i = 0; i < 10; i++, itemArray++)
    {
        *itemArray = i;
        Console.WriteLine(*itemArray);
    }

    Console.WriteLine();
    fixed (int* item = nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(*(item + i));
        }
    }

    A a = new();
    a.X = 250;

    Console.WriteLine();
    Console.WriteLine(GC.CollectionCount(0));
    Console.WriteLine(GC.CollectionCount(1));
    Console.WriteLine(GC.CollectionCount(2));
    fixed (int* p = &a.X)
    {
        Console.WriteLine(*p);
    }
    Console.WriteLine(GC.CollectionCount(0));
    Console.WriteLine(GC.CollectionCount(1));
    Console.WriteLine(GC.CollectionCount(2));
}
GC.Collect();
Console.WriteLine(GC.CollectionCount(0));
Console.WriteLine(GC.CollectionCount(1));
Console.WriteLine(GC.CollectionCount(2));



unsafe public class A
{
    public int X;
}