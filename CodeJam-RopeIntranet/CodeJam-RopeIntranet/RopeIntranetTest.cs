using NUnit.Framework;

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

            var sut = new RopeIntranet(ropes);
            Assert.That(sut.AreIntersecting(ropes[1], ropes[0]), Is.True);
            Assert.That(sut.AreIntersecting(ropes[1], ropes[2]), Is.False);

        }

        [Test]
        public void RopeIntranet_FindsNumberOfIntersections()
        {

            var ropes = new Rope[3] 
            { 
                new Rope(1, 10),
                new Rope(5, 5),
                new Rope(3, 4)
            };

            var sut = new RopeIntranet(ropes);
            //sut.FindIntersections();

        }
    }



}