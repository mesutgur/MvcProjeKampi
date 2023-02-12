using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD işlemleri
        // Type Name ();

        // 1. Meodumuz listeleme metodu. Türü List olan ve ismide List olan bir metot tanımladım.
        List<T> List();

        // 2. Metodumuz ekleme metodu.
        void Insert(T p);

        // 3. Metodumuz güncelleme metodu.
        void Update(T p);

        //4. Metodumuz Silme metodu.
        void Delete(T p);

        //************* YUKARIDA CRUD OPERASYONLARININ GERÇEKLEŞECEĞİ METODLARI TANIMLADIM. ****************

        // Şartlı listeleme için kullanacağım bir metod yazıyorum.

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
