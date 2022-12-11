using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared
{
    public class Product
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        /*Özelliğin ilk değeri string.Empty olarak ayarlanmıştır, yani ilk değeri boş bir dize olacaktır.*/

        public string Description { get; set; } = string.Empty;

        public string ImageURL { get; set; } = string.Empty;
        public decimal Price { get; set; }



    }
}
