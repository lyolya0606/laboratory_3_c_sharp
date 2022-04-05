using System;
using System.Collections.Generic;

namespace laboratory_3 {
    public class WitchOfAgnesi {
        private double coefficient;
        private double leftBorder;
        private double rightBorder;
        private double step;
        public Dictionary<double, double> pairs { get; set; }

        public WitchOfAgnesi(double coefficient, double leftBorder,
            double rightBorder, double step) {
            this.coefficient = coefficient;
            this.leftBorder = leftBorder;
            this.rightBorder = rightBorder;
            this.step = step;
        }

        public double CountingFunction(double x) {
            if (Math.Abs(coefficient) < 0.00001 && Math.Abs(x) < 0.00001) {
                return Double.NaN;
            }
            return Math.Round(Math.Pow(coefficient, 3) / (Math.Pow(coefficient, 2) + Math.Pow(x, 2)), 4);
        }

        public Dictionary<double, double>  GetPairs() {
            Dictionary<double, double> pairs = new Dictionary<double, double>();
            int leftSide = (int)(leftBorder / step);
            int rightSide = (int)(rightBorder / step);
            for (int i = leftSide; i <= rightSide; i++) {
                double x = step * i;
                pairs.Add(x, CountingFunction(x));
            }
            this.pairs = pairs;
            return pairs;
        }
    }
}
