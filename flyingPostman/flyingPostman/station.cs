namespace flyingPostman
{
    class Station
    {
        private string sname;
        private int sxAxis;
        private int syAxis;

        public Station(string name, int xAxis, int yAxis) {
            sname = name;
            sxAxis = xAxis;
            syAxis = yAxis;
        }

        public string Sname { get => this.sname; set => this.sname = value; }
        public int SxAxis { get => this.sxAxis; set => this.sxAxis = value; }
        public int SyAxis { get => syAxis; set => syAxis = value; }
    }
}
