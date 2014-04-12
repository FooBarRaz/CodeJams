
namespace CodeJam_RopeIntranet
{
    class Rope
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
