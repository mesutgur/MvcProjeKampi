using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //ContentYazar (İçerik hangi yazar tarafından yazıldı.)

        //ContentBaşlık (İçerik hangi başlık altına yazıldı.)

        //-----------------İLİŞKİLENDİRME-----------------------------------
        //Heading tablosundaki ID ile aynı isme sahip olmalı.
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //Writer tablosundaki ID ile aynı isme sahip olmalı.
        //Bir içeriği bir yazar yazabilir.
        //İçeriğimin yazarId kısmına illa bir değer girişi yapmak zorunda değilim.
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
