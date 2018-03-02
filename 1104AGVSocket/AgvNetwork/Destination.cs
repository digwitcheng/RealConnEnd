﻿using AGV_V1._0.Network.EnumType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGV_V1._0.Network
{
    class Destination
    {
        private MyPoint midPoint;         //中间位置
        private MyPoint desPoint;         //目标位置
        private AgvDriftAngle desAngle;    //目标方向(坐标x轴正方向的夹角)
        private TrayMotion desMotion;   //目标动作

        #region Properties
        public MyPoint MidPoint
        {
            set
            {
                midPoint = value;
            }
        }
        public MyPoint DesPoint
        {
            set
            {
                desPoint = value;
            }
        }
        public AgvDriftAngle DesAngle
        {
            set
            {
                desAngle = value;
            }
        }
        public TrayMotion Desmotion
        {
            set
            {
                desMotion = value; 
            }
        }
        #endregion

        public Destination(MyPoint midPoint, MyPoint desPoint, AgvDriftAngle desAngle, TrayMotion motion)
        {
            this.MidPoint = midPoint;
            this.DesPoint = desPoint;
            this.desAngle = desAngle;
            this.desMotion = motion;

        }
        public byte[] GetBytes()
        {
            byte[] packData = new byte[19];
            int offset = 0;
            Buffer.BlockCopy(MyBitConverter.GetBytes(midPoint.X), 0, packData, offset, 4);
            offset += 4;     
            Buffer.BlockCopy(MyBitConverter.GetBytes(midPoint.Y), 0, packData, offset, 4);
            offset += 4;     
            Buffer.BlockCopy(MyBitConverter.GetBytes(desPoint.X), 0, packData, offset, 4);
            offset += 4;     
            Buffer.BlockCopy(MyBitConverter.GetBytes(desPoint.Y), 0, packData, offset, 4);
            offset += 4;     
            Buffer.BlockCopy(MyBitConverter.GetBytes(desAngle.Angle), 0, packData, offset, 2);
            offset += 2;
            packData[offset++] = (byte)desMotion;
            return packData;
        }
       
    }
}
