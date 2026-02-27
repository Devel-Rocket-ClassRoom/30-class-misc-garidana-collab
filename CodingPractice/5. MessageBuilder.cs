using System;
using System.Collections.Generic;
using System.Text;

class MessageBuilder
{
    private string _message = "";

    public MessageBuilder AddText(string text)
    {
        _message += text;
        return this;  // return this 가 MessageBuilder 데이터 형으로 값 반환.
    }

    public MessageBuilder AddSpace()
    {
        _message += " ";
        return this;
    }
    public MessageBuilder AddNewLine()
    {
        _message += "\n";
        return this;
    }

    // 최종적으로 MessageBuilder를 string 데이터형으로 변환 후 _message 반환
    public string Build()  
    {
        return _message;
    }
}