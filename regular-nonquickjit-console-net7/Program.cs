Console.WriteLine("Hello, World!");
var result = 0;
var input = "(((9 + 9)))";
var arr = input.ToCharArray();

foreach (var ch in arr)
{
    if (ch == '(')
    {
        result++;
    }
    else
    {
        result--;
    }
}

Console.WriteLine(result);