--DERS 7--

Kampımızla beraber paralelde geliştireceğimiz bir projemiz daha olacak. Araba kiralama sistemi yazıyoruz.

Yepyeni bir proje oluşturunuz. Adı ReCapProject olacak.

Entities, DataAccess, Business ve Console katmanlarını oluşturunuz.

Bir araba nesnesi oluşturunuz. "Car"

Özellik olarak : Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekleyiniz. (Brand = Marka)

InMemory formatta GetById, GetAll, Add, Update, Delete oprasyonlarını yazınız.

Consolda test ediniz.

--DERS 8--

Car nesnesine ek olarak;

1) Brand ve Color nesneleri ekleyiniz(Entity)

Brand-->Id,Name

Color-->Id,Name

2) Sql Server tarafında yeni bir veritabanı kurunuz. Cars,Brands,Colors tablolarını oluşturunuz. (Araştırma)

3) Sisteme Generic IEntityRepository altyapısı yazınız.

4) Car, Brand ve Color nesneleri için Entity Framework altyapısını yazınız.

5) GetCarsByBrandId , GetCarsByColorId servislerini yazınız.

6) Sisteme yeni araba eklendiğinde aşağıdaki kuralları çalıştırınız.

Araba ismi minimum 2 karakter olmalıdır

Araba günlük fiyatı 0'dan büyük olmalıdır.

--DERS 9--

