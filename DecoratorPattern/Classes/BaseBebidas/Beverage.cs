using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DecoratorPattern.Classes.BaseBebidas
{
    public abstract class Beverage
    {

        public  string description = "Unknown Beverage";

        public enum SIZE
        {
            TALL,
            GRANDE,
            VENTI
        };


        SIZE size = SIZE.TALL;


        /// <summary>
        /// Identificador del caso
        /// </summary>
        public SIZE Size
        {
            get
            { return this.size; }
            set
            { this.size = value; }
        }

        public virtual string getDescription()
        {
            return description;

        }

       
        public abstract double cost();

        
    }
}
