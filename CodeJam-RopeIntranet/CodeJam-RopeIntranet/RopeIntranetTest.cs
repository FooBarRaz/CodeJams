using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CodeJam_RopeIntranet
{
    [TestFixture]
    class RopeIntranetTest
    {
        [Test]
        public void IntersectingRopes_FindsIntersection()
        {
            var ropes = new Rope[3] 
            { 
                new Rope(1, 10),
                new Rope(5, 5),
                new Rope(3, 4)
            };

            RopeIntranet sut = new RopeIntranet(ropes);
            Assert.That(sut.AreIntersecting(ropes[1], ropes[0]), Is.True);
            Assert.That(sut.AreIntersecting(ropes[1], ropes[2]), Is.False);

        }
    }

    internal class RopeIntranet
    {
        public RopeIntranet(Rope[] ropes)
        {
            this.Ropes = ropes;
        }

        public Rope[] Ropes { get; set; }

        internal bool AreIntersecting(Rope rope1, Rope rope2)
        {
            return rope1.StartPoint < rope2.StartPoint
                ? rope1.EndPoint > rope2.EndPoint
                : rope1.EndPoint < rope2.EndPoint;
        }
    }

    internal class Rope
    {
        public Rope(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public int EndPoint { get; set; }

        public int StartPoint { get; set; }
    }
}
