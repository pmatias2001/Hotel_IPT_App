using System;
using System.ComponentModel.DataAnnotations;

namespace CustomDataAnnotations
{
    public class CurrentDateAttribute : ValidationAttribute
    {
        public CurrentDateAttribute()
        {
        }
        //se a data representada pelo objeto value for maior que a data atual devolve true, senão false

        public override bool IsValid(object value)
        {
            var dt = (DateTime)value;
            if (dt >= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
