using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson5
{

    //(*) На перегрузку операторов.
    //Описать класс комплексных чисел.
    //Реализовать операцию
    //                     сложения,
    //                     вычитания,
    //                     умножения,
    //                     проверку на равенство двух комплексных чисел.
    //Переопределить метод ToString() для комплексного числа.
    //Протестировать на простом примере.

    class ComplexNumber
    {
        private int _realVal;        //действительная часть
        private int _imaginaryVal;   //мнимая часть

        public int RealVal
        {
            get { return _realVal; }
            set { _realVal = value; }
        }
        public int ImaginaryVal
        {
            get { return _imaginaryVal; }
            set { _imaginaryVal = value; }
        }

        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber cn = new ComplexNumber();
            cn._realVal = cn1._realVal + cn2._realVal;
            cn._imaginaryVal = cn1._imaginaryVal + cn2._imaginaryVal;
            return cn;
        }

        public static ComplexNumber operator -(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber cn = new ComplexNumber();
            cn._realVal = cn1._realVal - cn2._realVal;
            cn._imaginaryVal = cn1._imaginaryVal - cn2._imaginaryVal;
            return cn;
        }

        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            ComplexNumber cn = new ComplexNumber();
            cn._realVal = cn1._realVal * cn2._realVal - cn1._imaginaryVal * cn2._imaginaryVal;
            cn._imaginaryVal = cn1._imaginaryVal * cn2._realVal + cn1._realVal * cn2._imaginaryVal;
            return cn;
        }

        public override string ToString()
        {
            if (_imaginaryVal >= 0)
                return $"{_realVal} + {_imaginaryVal}*i";
            else
                return $"{_realVal} - {Math.Abs(_imaginaryVal)}*i";
        }

        public static bool operator ==(ComplexNumber cn1, ComplexNumber cn2)
        {
            return cn1.Equals(cn2);
        }

        public static bool operator !=(ComplexNumber cn1, ComplexNumber cn2)
        {
            return !cn1.Equals(cn2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            ComplexNumber cn = (ComplexNumber)obj;

            if (_realVal != cn._realVal)
                return false;

            return _imaginaryVal == cn._imaginaryVal;
        }

        public override int GetHashCode()
        {
            return _realVal ^ _imaginaryVal;
        }
    }
}
