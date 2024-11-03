using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampı301.EntityLayer.Concrete
{

    public class Category
    {

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatus {  get; set; }
        // Sadece oluşturacağımız kategori tablosuna ait değerleri tutacak.        KategorıId, KategoriAdı, KategoriDurumu gibi sütunların karşılığı burada tutacak.


    }
}
