//using System;
using Global;
using static Global.EasyObjectClassic;
//using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main(string[] args)
    {
        Echo(new { args = args });
        var parser = new BabelParserV7();
        var code = """
            function add2(a:number, b:number)
            {
                return a + b;
            }
            var x = add2(11, 22);
            console.log(x);
            return x;
            """;
        var astJson = parser.Parse(code, includeLocation: false);
        //var astJson = parser.Parse(code, includeLocation: true);
        Echo(astJson, "astJson");
   }
}