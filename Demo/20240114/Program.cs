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

// 类和基类
Point a = new(10, 20);
Point b = new Point3D(10, 20, 30);

EditBox editBox = new();
IControl control = editBox;
IDataBound dataBound = editBox;
Console.WriteLine(editBox);
Console.WriteLine($"{control},{dataBound}");

var turnip = SomeRootVegetable.Turnip;
var spring = Seasons.Spring;
var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
var theYear = Seasons.All;

Console.WriteLine(turnip);
Console.WriteLine($"{spring},{startingOnEquinox},{theYear}");

int? optionalInt = default;
optionalInt = 5;
string? optionalText = default;
optionalText = "Hello World";
Console.WriteLine($"{optionalInt},{optionalText}");

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
