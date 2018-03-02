using AGV_V1._0.Network;
using AGV_V1._0.NLog;
using AGV_V1._0.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV_V1._0.Agv
{
    class VehicleManager
    {
        //新建两个全局对象  小车
        private static Vehicle[] vehicles;
        private bool vehicleInited = false;
        private static Random rand = new Random(1);//5,/4/4 //((int)DateTime.Now.Ticks);//随机数，随机产生坐标


        private static VehicleManager instance;
        public static VehicleManager Instance
        {
            get
            {
                if (null == instance)
                {
                    instance = new VehicleManager();
                }
                return instance;
            }
        }
        private VehicleManager()
        {

        }
        public void InitVehicles()
        {
            vehicleInited = false;
            //初始化小车位置

            int vehicleCount = ConstDefine.VEHICLE_SUM;
            vehicles = new Vehicle[vehicleCount];
            for (int i = 0; i < vehicleCount; i++)
            {
                vehicles[i] = new Vehicle((uint)i);
            }
            vehicleInited = true;
            //////把小车所在的节点设为占用状态
            //RouteUtil.VehicleOcuppyNode(ElecMap.Instance, vehicles);
        }
        public void AddOrUpdate(ushort agvId, AgvInfo info)
        {
            if (vehicleInited == false)
            {
                return;
            }
            if (agvId >= vehicles.Length)
            {
                Logs.Error("程序预设的agv数量少了");
                return;
            }
            if (info == null)
            {
                return;
            }
            vehicles[(int)agvId].agvInfo = info;
        }
    }
}
