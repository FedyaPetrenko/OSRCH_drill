﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSRCH_drill
{
    public class Drill
    {
        #region Singleton
        private static Drill instance;
        private static Random rand;
        private static readonly int _minTemperature = 25;
        private static readonly int _maxTemperature = 250;

        static Drill()
        {
            rand = new Random();
        }

        public Drill()
        {
            Bits = new List<DrillBit>
            {
                new DrillBit
                {
                    DrillBitId = 1,
                    Diameter = 3,
                    Height = 10,
                    Image = "Images/bit1.png"
                },
                new DrillBit
                {
                    DrillBitId = 2,
                    Diameter = 5,
                    Height = 10,
                    Image = "Images/bit2.png"
                },
                new DrillBit
                {
                    DrillBitId = 3,
                    Diameter = 10,
                    Height = 30,
                    Image = "Images/bit3.png"
                },

            };
            ActiveBit = Bits.First();
        }

        public static Drill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Drill();
                }
                return instance;
            }
        }
        #endregion

        public bool isOn { get; set; } = false;
        public int RPM { get; set; }
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int positionZ { get; set; }
        public int WaterInputFrequency { get; set; }
        public DrillBit ActiveBit { get; set; }
        public List<DrillBit> Bits { get; set; }
        public int DrillTemp
        {
            get
            {
                return rand.Next(_minTemperature, _maxTemperature);
            }
        }

        public bool LaunchMachine()
        {
            isOn = true;
            return isOn;
        }

        public bool StopMachine()
        {
            isOn = false;
            return !isOn;
        }

        public int MoveX(int distance)
        {
            return positionX += distance;
        }
        public int MoveY(int distance)
        {
            return positionY += distance;
        }
        public int MoveZ(int distance)
        {
            return positionZ += distance;
        }

        public int SetRPM(int rpm)
        {
            return RPM = rpm;
        }
        public void ChangeDrill(int drillId)
        {
            if (Bits.Any(bit => bit.DrillBitId == drillId))
            {
                ActiveBit = Bits.FirstOrDefault(bit => bit.DrillBitId == drillId);
            }
        }

        public int SetWaterInputFrequency(int count)
        {
            WaterInputFrequency = count;
            return WaterInputFrequency;
        }

        public string GetCurrentDrillTemperature()
        {
            return "Drill temperature: " + DrillTemp;
        }

    }

    public class DrillBit
    {
        public int DrillBitId { get; set; }
        public int Diameter { get; set; }
        public int Height { get; set; }
        public string Image { get; set; }
    }
}
