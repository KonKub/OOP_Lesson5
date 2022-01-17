using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson5
{
    //1. + Создать класс рациональных чисел.
    //   + В классе два поля – числитель и знаменатель.
    //   + Предусмотреть конструктор.
    //   + Определить операторы ==, != (метод Equals()),
    //   +   <, >, <=, >=,
    //   +   +, – , ++, --.
    //   + Переопределить метод ToString() для вывода дроби.
    //   + Определить операторы преобразования типов между типом дробь, float, int.
    //   + Определить операторы *, /, %.
    class RationalNumber
    {
        private int _numerator;   //числитель
        private int _denominator; //знаменатель
        public int Numerator
        {
            get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            get 
            {
                return _denominator;
            }
            set
            {
                if (value == 0) _denominator = 1;
                else _denominator = value;
            }
        }

        public RationalNumber()
        {
            _numerator = 1;
            _denominator = 1;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }

        public static bool operator ==(RationalNumber rn1, RationalNumber rn2)
        {
            return rn1.Equals(rn2);
        }

        public static bool operator !=(RationalNumber rn1, RationalNumber rn2)
        {
            return !rn1.Equals(rn2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            RationalNumber rn = (RationalNumber)obj;

            if (_numerator != rn._numerator)
                return false;

            return  _denominator == rn._denominator;
        }

        public override int GetHashCode()
        {
            return _numerator ^ _denominator;
        }

        public static bool operator <(RationalNumber rn1, RationalNumber rn2)
        {
            if ((float)rn1 < (float)rn2)
                return true;
            else return false;
        }

        public static bool operator >(RationalNumber rn1, RationalNumber rn2)
        {
            if ((float)rn1 > (float)rn2)
                return true;
            else return false;
        }

        public static bool operator <=(RationalNumber rn1, RationalNumber rn2)
        {
            if (rn1.Equals(rn2)) return true;
            if ((float)rn1 < (float)rn2)
                return true;
            else return false;
        }

        public static bool operator >=(RationalNumber rn1, RationalNumber rn2)
        {
            if (rn1.Equals(rn2)) return true;
            if ((float)rn1 > (float)rn2)
                return true;
            else return false;
        }

        public static RationalNumber operator +(RationalNumber rn1, RationalNumber rn2)
        {
            RationalNumber rn = new RationalNumber();
            rn._numerator = rn1._numerator * rn2._denominator + rn2._numerator * rn1._denominator;
            rn._denominator = rn1._denominator * rn2._denominator;
            return rn;
        }

        public static RationalNumber operator -(RationalNumber rn1, RationalNumber rn2)
        {
            RationalNumber rn = new RationalNumber();
            rn._numerator = rn1._numerator * rn2._denominator - rn2._numerator * rn1._denominator;
            rn._denominator = rn1._denominator * rn2._denominator;
            return rn;
        }

        public static RationalNumber operator ++(RationalNumber rn)
        {
            rn._numerator = rn._numerator + rn._denominator;
            return rn;
        }

        public static RationalNumber operator --(RationalNumber rn)
        {
            rn._numerator = rn._numerator - rn._denominator;
            return rn;
        }

        //Определить операторы *, /, %.
        public static RationalNumber operator *(RationalNumber rn1, RationalNumber rn2)
        {
            RationalNumber rn = new RationalNumber();
            rn._numerator = rn1._numerator * rn1._numerator;
            rn._denominator = rn1._denominator * rn2._denominator;
            return rn;
        }

        public static RationalNumber operator /(RationalNumber rn1, RationalNumber rn2)
        {
            RationalNumber rn = new RationalNumber();
            rn._numerator = rn1._numerator * rn2._denominator;
            rn._denominator = rn1._denominator * rn2._numerator;
            return rn;
        }

        public static int operator %(RationalNumber rn1, RationalNumber rn2)
        {
            RationalNumber rn = new RationalNumber();
            int dec1 = rn1._numerator / rn1._denominator;
            int dec2 = rn2._numerator / rn2._denominator;
            if (dec2 == 0) return 0;
            else return dec1 % dec2;
        }

        //Определить операторы преобразования типов между типом дробь, float, int.
        public static explicit operator float(RationalNumber rn)
        {
            return (float)rn._numerator / (float)rn._denominator;
        }

        public static implicit operator int(RationalNumber rn)
        {
            return rn._numerator / rn._denominator;
        }
    }
}
