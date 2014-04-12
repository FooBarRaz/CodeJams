using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CodeJam___MinimumScalarProduct
{
    [TestFixture]
    class MinimumScalarProductTest
    {
        [Test]
        public void ReverseSortArrays()
        {
            var xVectors = new[] {1, 3, -5};
            var yVectors = new[] {-2, 4, 1};
            var sut = new MinumumScalarProduct(xVectors, yVectors);

            Assert.That(sut.xVectors, Is.EqualTo(new[] {-5, 1, 3}));
            Assert.That(sut.yVectors, Is.EqualTo(new[] {4, 1, -2}));
        }

        [Test]
        public void GetMinimalScalar()
        {
            var xVectors = new[] { 1, 3, -5 };
            var yVectors = new[] { -2, 4, 1 };
            var sut = new MinumumScalarProduct(xVectors, yVectors);

            var result = sut.GetMinimumScalarVector();

            Assert.That(result, Is.EqualTo(-25));

        }
    }

    internal class MinumumScalarProduct
    {
        public int[] xVectors;
        public int[] yVectors;
        public MinumumScalarProduct(IEnumerable<int> xVectors, IEnumerable<int> yVectors)
        {
            this.xVectors = xVectors.OrderBy(x=>x).ToArray();
            this.yVectors = yVectors.OrderByDescending(y=>y).ToArray();
        }

        public int GetMinimumScalarVector()
        {
            return xVectors.Select((t, i) => t*yVectors[i]).Sum();
        }

    }
}
