using System;
using System.ComponentModel.DataAnnotations;
using Hotel_IPT_App.Models.Reservas;

namespace Hotel_IPT_App.Data
{
    public class InitialDateAttribute : ValidationAttribute
    {
        public InitialDateAttribute()
        {
        }

        public override bool IsValid(object value)
        {
            var dt = (DateTime)value;
            if (dt >= )
            {
                return true;
            }
            return false;
        }
    }
}
