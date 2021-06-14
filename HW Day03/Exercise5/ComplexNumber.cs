using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class ComplexNumber
    {
        //private double real { set; get; }
        //private double imaginary { set; get; }
        private double real, imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double GetReal()
        {
            return real;
        }

        public void SetReal(double real)
        {
            this.real = real;
        }
        
        public double GetImaginary()
        {
            return imaginary;
        }

        public void SetImaginary(double imaginary)
        {
            this.imaginary = imaginary;
        }

        public new string ToString()
        {
            return "(" + real + "," + imaginary + ")";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((real * real) + (imaginary * imaginary));
        }

        public void Add(ComplexNumber complex)
        {
            real += complex.GetReal();
            imaginary += complex.GetImaginary();
        }
    }
}
