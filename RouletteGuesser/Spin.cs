using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteGuesser
{
    public enum SpinColor
    {
        Red,
        Black,
        Green
    }

    public class Spin
    {
        public string Value { get; set; }

        private int NumValue => int.Parse(Value);

        public bool IsFirst12 => NumValue >= 1 && NumValue <= 12;
        public bool IsSecond12 => NumValue >= 13 && NumValue <= 24;
        public bool IsThird12 => NumValue >= 25 && NumValue <= 36;

        public bool IsFirstColumn => NumValue != 0 && NumValue % 3 == 1;
        public bool IsSecondColumn => NumValue != 0 && NumValue % 3 == 2;
        public bool IsThirdColumn => NumValue != 0 && NumValue % 3 == 0;

        public bool IsEven => NumValue != 0 && NumValue % 2 == 0;
        public bool IsOdd => NumValue != 0 && NumValue % 2 == 1;

        public bool IsLowNumbers => NumValue >= 1 && NumValue <= 18;
        public bool IsHighNumbers => NumValue >= 19 && NumValue <= 36;

        public SpinColor Color {
            get {
                if (Value == "0" || Value == "00")
                {
                    return SpinColor.Green;
                }
                else if (new List<int> { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 }.Contains(NumValue))
                {
                    return SpinColor.Red;
                }
                else
                {
                    return SpinColor.Black;
                }
            }
        }

        public Spin(string value)
        {
            Value = value;
        }
    }
}
