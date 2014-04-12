using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam_RopeIntranet
{
    class RopeIntranet
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

}
