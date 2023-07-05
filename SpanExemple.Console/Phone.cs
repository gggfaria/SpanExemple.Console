using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpanExemple.Console
{
    [MemoryDiagnoser]
    public class Phone
    {
        private static readonly string _phoneString = "+5524955556342";


        [Benchmark]
        public string GetAreaCode()
        {
            var areaCode = _phoneString.Substring(3, 2);
            return areaCode;
        }

        [Benchmark]
        public ReadOnlySpan<char> GetAreaCodeSpan()
        {
            ReadOnlySpan<char> phoneSpan = _phoneString;
            var areaCode = phoneSpan.Slice(3, 2);
            return areaCode;
        }

    }
}
