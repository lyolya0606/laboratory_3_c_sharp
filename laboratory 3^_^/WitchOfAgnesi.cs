using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratory_3 {
    class WitchOfAgnesi {
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
            return Math.Pow(coefficient, 3) / (Math.Pow(coefficient, 2) + Math.Pow(x, 2));
        }

        public bool IsSpecialSituation() {
            if (coefficient == 0 && leftBorder <= 0 && rightBorder >= 0) {
                return true;
            } else {
                return false;
            }
        }
    }
}
