using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace CSharp_Modulo_Benchmark
{
    public class ModuloBenchmark
    {
        [Params(36)]
        public int Length { get; set; }

        [Params(10000)]
        public int Iterations { get; set; }

        [Benchmark]
        public int Modulo()
        {
            var result = 0;

            var index = 0;

            for(var i = 0; i < Iterations; i++)
            {
                index = i;

                result = index % Length;
            }

            return result;
        }

        [Benchmark]
        public int Bruteforce()
        {
            var result = 0;

            var index = 0;

            for (var i = 0; i < Iterations; i++)
            {
                index = i;

                if (index >= Length)
                {
                    index = 0;
                }

                result = index;
            }

            return result;
        }

        private IEnumerable<int> _enumerable()
        {
            var index = 0;

            if (++index >= Length)
            {
                index = 0;
            }

            yield return index;
        }

        [Benchmark]
        public int Enumerable()
        {
            var result = 0;

            var index = 0;

            var iteration = 0;

            foreach(var x in _enumerable())
            {
                index = x;

                if (++iteration >= Iterations)
                {
                    break;
                }
            }

            return result;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ModuloBenchmark>();
        }
    }
}
