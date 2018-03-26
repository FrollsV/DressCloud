using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.ClothesPicker.Models
{
    public class Outfit
    {   
        public Outfit()
        {
            Accessories = new Accessory();
        }

        public Accessory Accessories { get; private set; }
        
    }
}
