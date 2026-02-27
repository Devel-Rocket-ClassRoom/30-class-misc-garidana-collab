using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class StringHelper
{
    public static string CleanAndUpper(string input)
    {
        return input.ToUpper().Trim();
    }
    public static string Reverse (string input)
    {
        // 문자 배열을 생성해서 Array. Array.Reverse 사용하고 문자열 생성해서 반환.
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    public static bool IsNullOrEmpty(string input)
    {
        return string.IsNullOrEmpty(input);  // 문자열이 비어있는지 확인하는 메서드
    }
}