using System;
using System.Collections.Generic;

namespace CSharpSupportEngineer.Model
{
    public sealed class NumberCache
    {
        private List<Number> _numberCache = new List<Number>();
        public void BuildCache(List<Number> numbers)
        {
            Seed(numbers);
        }

        public void Seed(List<Number> numbers)
        {
            numbers.ForEach(s =>
            {
                _numberCache.Add(s);
            });
        }
    }
}
