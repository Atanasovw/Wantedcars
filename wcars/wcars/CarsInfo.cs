using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace wcars
{
    internal class CarsInfo:Cars, IPrint, IComparable<CarsInfo>
    {
        private int licensePlate;

        public int LicensePlate
        {
            get { return licensePlate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Grephka");
                }
                this.licensePlate = value;
            }
        }
        public CarsInfo(string brand, int licensePlate):base(brand)
        {
            this.licensePlate=licensePlate;
        }
        public override string Print()
        {
            base.Print();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand: {Brand} & License Plate: {LicensePlate}");
            return sb.ToString();
        }
        public int CompareTo(CarsInfo obj)
        {
            return LicensePlate.CompareTo(obj.LicensePlate);

        }

    }
}
