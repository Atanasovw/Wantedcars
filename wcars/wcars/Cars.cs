using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcars
{
    internal abstract class Cars:IPrint
    {
    
        
       
        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        "value"
                    );

                }
                this.brand = value;
            }
        }
        public Cars(string brand)
        {
            this.brand = brand;
        }
        public Cars()
        {

        }
        public virtual string Print()
        {
            return $"{this.brand}";

        }
        

    }
}
