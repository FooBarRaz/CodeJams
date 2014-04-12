using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_RopeIntranet
{
    class RopeIntranet
    {
        public RopeIntranet(Rope[] ropes)
        {
            Ropes = ropes.OrderBy(x=>x.StartPoint).ToArray();
        }

        public Rope[] Ropes { get; set; }

        internal bool AreIntersecting(Rope rope1, Rope rope2)
        {
            return rope1.StartPoint < rope2.StartPoint
                ? rope1.EndPoint > rope2.EndPoint
                : rope1.EndPoint < rope2.EndPoint;
        }

        public int FindIntersections()
        {
            return Ropes.Sum(t => Ropes.Where(r => r.StartPoint > t.StartPoint).Count(x => AreIntersecting(t, x)));
        }
    }

}
