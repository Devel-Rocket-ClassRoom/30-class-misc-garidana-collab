using System;
using System.Diagnostics.SymbolStore;
using System.Text;
using static System.Console;
using MB = MessageBuilder;
// README.md를 읽고 아래에 코드를 작성하세요.




// 1
Person person = new();
person.Print("홍길동", 25);
WriteLine();

// 2
Hello hi = new();
hi.Hi();
hi.Bye();
WriteLine();

// 3
WriteLine($"덧셈: {Calculator.Add(10, 20)}");
WriteLine($"뺄셈: {Calculator.Subtract(30, 20)}");
WriteLine($"곱셈: {Calculator.Multiply(5, 6)}");
WriteLine();

// 4
string text = "  hello world      ";
WriteLine(StringHelper.CleanAndUpper(text));
WriteLine(StringHelper.Reverse("Hello"));
WriteLine(StringHelper.IsNullOrEmpty(""));

WriteLine();

// 5
WriteLine($"제곱근: {Math.Sqrt(16)}");
WriteLine($"거듭제곱: {Math.Pow(2, 3)}");
WriteLine($"최댓값: {Math.Max(10, 20)}");
WriteLine($"최솟값: {Math.Min(10, 20)}");

WriteLine();

// 6
StringBuilder sb = new StringBuilder();
sb.Append("Hello");
sb.Append(" ");
sb.Append("World");
string result = sb.ToString();

string result1 = new StringBuilder()
    .Append("Hello")
    .Append(" ")
    .Append("World")
    .ToString();

WriteLine(result);
WriteLine(result1);

WriteLine();

// 7
string message = new MessageBuilder()
    .AddText("안녕하세요!")
    .AddNewLine()
    .AddText("반갑습니다.")
    .AddSpace()
    .AddText("좋은 하루 되세요.")
    .Build();

WriteLine();

// 8 



