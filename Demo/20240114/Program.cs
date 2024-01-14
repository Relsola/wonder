using Learn;

Console.WriteLine("Hello World!");

var s = new Learn.Stack<int>();

s.Push(1);
s.Push(10);
s.Push(100);

Console.WriteLine(s.Pop()); // 100
Console.WriteLine(s.Pop()); // 10
Console.WriteLine(s.Pop()); // 1

// 不使用自动垃圾回收
var p1 = new Point(0, 0);
var p2 = new Point(10, 20);

// 随机生成 Point
var factory = new PointFactory(3);
foreach (var Point in factory.CreatePoints())
{
    Console.WriteLine($"{Point.X},{Point.Y}");
}

// 泛型
var pair = new Pair<int, string>(1, "two");
int first = pair.First;
string two = pair.Second;

Console.WriteLine(first + " " + two);