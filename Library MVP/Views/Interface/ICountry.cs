using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface ICountry
    {
        int ID { get; set; }

        string CountryName { get; set; }
    }
}
