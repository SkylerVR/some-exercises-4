//1.შექმენით მეთოდი, რომელსაც პარამეტრად გადაეცემა სტრინგ ტიპის მონაცემთა ლისტი, და ბეჭდავს ლისტის თითოეულ ელემენტს.
List<string> strings = new List<string>() { "test", "gg" };
static void PrintList(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}
PrintList(strings);

//2. შექმენით ორი ლისტი, პირველი ლისტის ელემენტები დააკოპირეთ მეორეში, დაასორტირეთ ლისტი, და გამოიტანეთ მონაცემები კონსოლში.
List<int> first = new List<int>() { 1, 2 };
List<int> second = new List<int>() { 23, 24 };

first.AddRange(second);
first.Sort();
foreach (var item in first)
{
    Console.WriteLine(item);
}

//3.შექმენით ორი ლისტი, პირველი ლისტის ელემენტების იდენტური ელემენტები წაშალეთ მეორედან , 
//დაასორტირეთ  მეორე ლისტი, და გამოიტანეთ მონაცემები კონსოლში.

List<int> firstList = new List<int>() { 1, 2, 3, 4, 5 };
List<int> secondList = new List<int>() { 6, 7, 8, 9, 10 };
firstList.AddRange(secondList);

List<int> uniqueList = firstList.Distinct().ToList();

foreach (var item in uniqueList)
{
    Console.WriteLine(item);
}

//4.შექმენით QUEUE დაამატეთ მასში მონაცემები, წაშალეთ პირველი ელემენტი

Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Dequeue();

//5.შექმენით ორი HashSet, გააერთიანეთ და კონსოლში გამოიტანეთ
HashSet<int> firsHash = new HashSet<int>() { 101, 102 };
HashSet<int> secondHash = new HashSet<int>() { 101, 102, 103 };
firsHash.UnionWith(secondHash);

foreach (var item in firsHash)
{
    Console.WriteLine(item);
}

//6.შექმენით Dictionary, სადაც Key იქნება Id , ხოლო მნიშვნელობა: მანქანის დასახელება
Dictionary<int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Bmw");
dict.Add(2, "Audi");
dict.Add(3, "Mercedes");