using Exercice02;
using Exercice02Test;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]


Fib _fibTest = new Fib(6);
List<int> listResult = new List<int>();
listResult = _fibTest.GetFibSeries();

List<int> test = new List<int>() { 5, 4, 2, 6643, 434 };
var ListOrderAsc = test.OrderBy(x => x).ToList();

foreach (int i in expectedList)
{
    Console.WriteLine(i);
}