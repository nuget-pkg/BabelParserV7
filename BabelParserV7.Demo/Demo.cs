//using System;
using Global;
using static Global.EasyObject;
//using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main()
    {
        var parser = new BabelParserV7();
        var code = """
            var a = 11 + 22;
            """;
        var astJson = parser.Parse(code, includeLocation: false);
        //var astJson = parser.Parse(code, includeLocation: true);
        Echo(astJson, "astJson");
   }
}