using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CdonMarketplace.Utils
{
    public class SizeEstimator
    {
        private readonly long _batchSizeInBytes;
        private readonly int _nrOfProductsToTest;

        public SizeEstimator(long batchSizeInBytes, int nrOfProductsToTest)
        {
            _batchSizeInBytes = batchSizeInBytes;
            _nrOfProductsToTest = nrOfProductsToTest;
        }

        public IEnumerable<IReadOnlyList<Product.Product>> GetInBatches(IEnumerable<Product.Product> products)
        {
            var size = 0L;
            var productsToTest = new List<Product.Product>(_nrOfProductsToTest);
            var batch = new List<Product.Product>();
            var i = 0;
            foreach (var product in products)
            {
                if (i > 0 && i % _nrOfProductsToTest == 0)
                {
                    size += GetSize(productsToTest);
                    if (size < _batchSizeInBytes)
                    {
                        batch.AddRange(productsToTest);
                    }
                    else
                    {
                        yield return batch;
                        size = 0L;
                        batch = new List<Product.Product>();
                    }
                    productsToTest = new List<Product.Product>(_nrOfProductsToTest);
                }
                productsToTest.Add(product);
                i++;
            }

            if (productsToTest.Count > 0)
            {
                size += GetSize(productsToTest);
                if (size < _batchSizeInBytes)
                {
                    batch.AddRange(productsToTest);
                    yield return batch;
                }
                else
                {
                    yield return batch;
                    yield return new List<Product.Product>(productsToTest);
                }
            }
        }

        private static long GetSize(List<Product.Product> productsToTest)
        {
            using var stream = new MemoryStream();
            XmlUtils.SerializeXmlToStream(productsToTest, stream);
            return stream.Length;
        }
    }
}
