using System;
using Global;
using static Global.EasyObject;
using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace Demo;

// ReSharper disable once ArrangeTypeModifiers
static class Program
{
    // ReSharper disable once ArrangeTypeMemberModifiers
    static void Main()
    {
        Echo(BabelParserV7.Add2(11, 22));
   }
}