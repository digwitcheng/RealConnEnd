using AGV_V1._0.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV_V1._0.Agv
{
    class Vehicle
    {
        public uint Id { get; private set; }
        public AgvInfo agvInfo { get; set; }

        private List<MyPoint> route = new List<MyPoint>();
        public List<MyPoint> Route
        {
            get
            {
                return route;
            }
            set
            {
                route = value;
            }
        }
        public Vehicle(uint id)
        {
            this.Id = id;
        }
    }
}
