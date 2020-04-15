


Entity Framework:

Entity Framework bir ORM mimarisidir.Entity Framework ORM Mimarisi gereði uygulama içerisindeki objelerin  herbirinin karþýlýðýnýn databasede olmasýný gerektiren ve bunun için bize CodeFirst yada DatabaseFirst gibi yaklaþýmlarla yardýmcý olan bir Framwork'tür.

Object Relation Mapping (ORM): Veritabanýmýzda yaratmýþ olduðumuz her bir nesneye karþýlýk kod tarafýnda bir nesne oluþturan mimaridir. Bu programlar code generation tekniði kullanarak bizim yazmamýz gereken kodu otomatik oalrak üretir. OOP mantýðýna uygun bir þekilde veritabanýmýzda bulunan tablolarý birer nesne örneklerini oluþturuyoruz.

Entity Framework'ün en büyük faydalarýnda biride bizim kod  tarafýnda yazdýðýmýz linq to' larý DbSet aracýlýðýyla SQL'e Gönderir SQL tarafýnda bunlar T-SQL Convert edilir gerekli sorgular atýlýr ve sorgular sonucunda bize dönen veri kümeleri tekrardan projeye geri döner Db Set vasýtasýyla . Linq tolarýn çalýþma mantýðýda budur.DB context Databasemi temsil eder DbSet ' te tablolarýmý
               

Database yansýmasýný yani örneklemini projeye entegre eden bir framwwork'tür. Bu framework'ün 3 tane yaklaþýmý vardýr. Bunlar:

1.Database First Yaklaþýmý: Bu örnekte kullandýðýmýz yaklaþýmdýr. Hazýr bir database varsa ve bunu kulalnacaksam ilgili database yansýmasýný uygulamaya ekliyoruz. Sonuç olarak database'de bulunan tablolarý projeme class olarak ekler. Kod tarafýnda yani visiual studio'da bu yansýma üzerinde çalýþýrýz. CRUD operasyonlarýmýnýzý yürütürüz. Çok büyük projelerin ihtiyacý olan geniþ çaplý database'lerde bu yaklaþým performans kayýplarýna neden olur. Ama database nin tekrardan kod tarafýnda yansýmasýnýn yazýlmasýnýn maliyetli olacaðý durumlarda günü kurtarmak için tercih edileblir daha sonra code first yaklaþýmýna geçilebilir. 

2.Model First: Proje tarafýnda database oluþturulur, tablolar projede oluþturulur daha sonra bu tabloalrýn yansýmasý yani þemasý database çýkartýlýr. Hiç kullanan görmedim :D

3.Code First Yaklaþýmý: Herhangi bir yansýma yoktur. Tamamen yansýmayý developer visual studio ortamýnda oluþturur yani model'i biz yazarýz. Örneðin employee tablom olacak bunun için gidið employee class'ýný kendimiz yazarýz, daha sonra program çalýþtýðýnda yada migration gerçekleþtiðinde oluþturduðumuz class'lar database'ye gidip tablo olarak ayaðý kalkarlar.

Adým Adým E-Commercial DataBase:

1.Ýlk Adýmda yeni bir proje açarýz:Ancak Otomatik ayný ismi verdiði Solution Name ve Project Name'in çakýþmamasý için Project Name'e (Solution Name + .UI) ismini veririz.

2.Proje açýldýktan sonra Solution üzerinde sað click yapýp new project deyip Library den Class Library(.Net Framework) seçilir.Adýna ise SolutionName+Katman ismi verilir.

   2.1. Açýlan yeni proje içindeki class1 silinir.
   2.2. Ýçerisine yeni katmanýmýz olan Enities katmaný içerisine Abstraction Concrete ve Enums klasörleri açýlýr.
     2.2.1. Abstraction Klasörlerinin içine Interface gibi soyut sýnýflar açýlýr.
     2.2.2. Concrete Klasörünün içine DataBase de Tablo oluþturacak ve Kalýtým yolula yetenek kazanacak classlarýmýzý açýyoruz.Product,Supplier,Category..vb.
     2.2.3. Enums Klasörünün içindede enum classlarýmýzý barýndýrýyoruz.

3.Entities Katmaný tamamlandýktan sonra 3. Katmanýmý Solution üzerinde sað click yapýp Add New Project deyip librarydan yeni Class Library(.Net Framework) açýlýr ve ismine yine solution Name+Katman Adý verilir.Açtýðýmýz Bu Katmandaki açýlan class1'i siler içerisine Databasele Baðlantý kuracaðým class olan Context clasýný barýndýrýrým.
  3.1 Ýlkönce Context Adýnda açýlan dosyanýn içerisine ProjectContext Adýnda class açýlýr ve Açýlan ProjectContext classýyla :DbContext ile ki bunu Bana Entity Framework saðladýðý için önce proje üzerine gelip Manage Nuget Packages ý týklayýp Browse týklayýp Entity Framework 6.4.0 versiyonu indirilir.ProjectContext sýnýfýmda Database de tablo olarak ayaða kalkacaðým  sýnýflarý belirtir ve databasele baðlantý kurulmasý için ctor+tap+tap yapýlýp constractor metodu içerisine Databasebaðlantýmý yazarým.

4.Tüm Bu iþlemler yapýldýktan sonra proje build edilir bir hata yoksa Tools Manage Nuget Packages + Package Manager Consol'a týklanýp altta açýlan Default Project'te DataAccess Katmaný seçilip console kýsmýna enable+migrations denildikten sonra ekranda çýkan false yazan kýsým true olarak deðiþtirilir ve tekrardan update-database enter yapýldýktan sonra Tablolar SQl de kontrol edilir.

Not: Açýlan He Katmanda Enity Framework tekrardan yüklenir.

