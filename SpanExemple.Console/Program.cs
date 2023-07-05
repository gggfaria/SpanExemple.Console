// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using SpanExemple.Console;


var phone = new Phone();
Console.WriteLine(phone.GetAreaCodeSpan().ToString());

BenchmarkRunner.Run<Phone>();
