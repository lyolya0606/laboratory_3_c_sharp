using System;
using System.Collections.Generic;

namespace laboratory_3 {
    public class WitchOfAgnesi {
        private double coefficient;
        private double leftBorder;
        private double rightBorder;
        private double step;

        public WitchOfAgnesi(double coefficient, double leftBorder,
            double rightBorder, double step) {
            this.coefficient = coefficient;
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.step = step;
        }

        public double CountingFunction(double x) {
            if (Math.Abs(coefficient) < 0.0001 && Math.Abs(x) < 0.0001) {
                return Double.NaN;
            }
            return Math.Round(Math.Pow(coefficient, 3) / (Math.Pow(coefficient, 2) + Math.Pow(x, 2)), 4);
        }

        public Dictionary<double, double>  GetPairs() {
            Dictionary<double, double> pairs = new Dictionary<double, double>();
            for (double x = leftBorder; x <= rightBorder; x += step) {
                pairs.Add(x, CountingFunction(x));
            }
            return pairs;
        }
    }
}
