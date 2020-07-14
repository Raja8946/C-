using System;
using System.Collections.Generic.Dictionary;
namespace Default
{
    public class MyDictionary : Dictionary<string, int> { }

public class MyMain
{
    public MyMain()
    {
        MyDictionary dictionary = new MyDictionary();
        dictionary.Add("hello", 1);
    }
}
}