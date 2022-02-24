using GarbageCollector;

using (var c = new MyClass())
{

}

Test();
GC.Collect();
Console.ReadLine();

static void Test()
{
    using (var c = new MyClass())
    {

    }
}