using System.Collections.Generic;
using CDON.Marketplace.Contracts;

namespace CDON.Marketplace.Factories
{
    public class BrandListFactory
    {
        public IEnumerable<Brand> Create(IReadOnlyList<string> brands)
        {
            var i = 1;
            foreach (var brand in brands)
            {
                yield return new Brand
                {
                    Id = i++,
                    Attributes = new[]
                    {
                        new CdonAttribute
                        {
                            Id = "BrandName",
                            Value = brand
                        }
                    }
                };
            }
        }
    }
}
