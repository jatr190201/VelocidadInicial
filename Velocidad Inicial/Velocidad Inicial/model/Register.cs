﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velocidad_Inicial.model
{
    class Register
    {
        public const double GRAVITY = 9.8;
        public double Time { get; set; }
        public double Angle { get; set; }
        public double Distance { get; set; }
        public double Vo1 { get; set; }
        public double Vo2 { get; set; }

        public Register(double time, double angle, double distance)
        {
            Time = time;
            Angle = angle;
            Distance = distance;
        }

        public double CalculateVo1()
        {
            return GRAVITY * Time / (2 * Math.Sin(Angle));
        }

        public double CalculateVo2()
        {
            return Math.Sqrt(GRAVITY * Distance / Math.Sin(2 * Angle)); ;
        }

        public double CalculateUncertainty()
        {
            return -1;
        }

        public string GetCsvString()
        {
            return Time.ToString("0.000", CultureInfo.InvariantCulture) + "," +
                Angle.ToString("0.000", CultureInfo.InvariantCulture) + "," +
                Distance.ToString("0.000", CultureInfo.InvariantCulture);
        }
    }
}
