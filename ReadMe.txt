


Entity Framework:

Entity Framework bir ORM mimarisidir.Entity Framework ORM Mimarisi gere�i uygulama i�erisindeki objelerin  herbirinin kar��l���n�n databasede olmas�n� gerektiren ve bunun i�in bize CodeFirst yada DatabaseFirst gibi yakla��mlarla yard�mc� olan bir Framwork't�r.

Object Relation Mapping (ORM): Veritaban�m�zda yaratm�� oldu�umuz her bir nesneye kar��l�k kod taraf�nda bir nesne olu�turan mimaridir. Bu programlar code generation tekni�i kullanarak bizim yazmam�z gereken kodu otomatik oalrak �retir. OOP mant���na uygun bir �ekilde veritaban�m�zda bulunan tablolar� birer nesne �rneklerini olu�turuyoruz.

Entity Framework'�n en b�y�k faydalar�nda biride bizim kod  taraf�nda yazd���m�z linq to' lar� DbSet arac�l���yla SQL'e G�nderir SQL taraf�nda bunlar T-SQL Convert edilir gerekli sorgular at�l�r ve sorgular sonucunda bize d�nen veri k�meleri tekrardan projeye geri d�ner Db Set vas�tas�yla . Linq tolar�n �al��ma mant���da budur.DB context Databasemi temsil eder DbSet ' te tablolar�m�
               

Database yans�mas�n� yani �rneklemini projeye entegre eden bir framwwork't�r. Bu framework'�n 3 tane yakla��m� vard�r. Bunlar:

1.Database First Yakla��m�: Bu �rnekte kulland���m�z yakla��md�r. Haz�r bir database varsa ve bunu kulalnacaksam ilgili database yans�mas�n� uygulamaya ekliyoruz. Sonu� olarak database'de bulunan tablolar� projeme class olarak ekler. Kod taraf�nda yani visiual studio'da bu yans�ma �zerinde �al���r�z. CRUD operasyonlar�m�n�z� y�r�t�r�z. �ok b�y�k projelerin ihtiyac� olan geni� �apl� database'lerde bu yakla��m performans kay�plar�na neden olur. Ama database nin tekrardan kod taraf�nda yans�mas�n�n yaz�lmas�n�n maliyetli olaca�� durumlarda g�n� kurtarmak i�in tercih edileblir daha sonra code first yakla��m�na ge�ilebilir. 

2.Model First: Proje taraf�nda database olu�turulur, tablolar projede olu�turulur daha sonra bu tabloalr�n yans�mas� yani �emas� database ��kart�l�r. Hi� kullanan g�rmedim :D

3.Code First Yakla��m�: Herhangi bir yans�ma yoktur. Tamamen yans�may� developer visual studio ortam�nda olu�turur yani model'i biz yazar�z. �rne�in employee tablom olacak bunun i�in gidi� employee class'�n� kendimiz yazar�z, daha sonra program �al��t���nda yada migration ger�ekle�ti�inde olu�turdu�umuz class'lar database'ye gidip tablo olarak aya�� kalkarlar.

Ad�m Ad�m E-Commercial DataBase:

1.�lk Ad�mda yeni bir proje a�ar�z:Ancak Otomatik ayn� ismi verdi�i Solution Name ve Project Name'in �ak��mamas� i�in Project Name'e (Solution Name + .UI) ismini veririz.

2.Proje a��ld�ktan sonra Solution �zerinde sa� click yap�p new project deyip Library den Class Library(.Net Framework) se�ilir.Ad�na ise SolutionName+Katman ismi verilir.

   2.1. A��lan yeni proje i�indeki class1 silinir.
   2.2. ��erisine yeni katman�m�z olan Enities katman� i�erisine Abstraction Concrete ve Enums klas�rleri a��l�r.
     2.2.1. Abstraction Klas�rlerinin i�ine Interface gibi soyut s�n�flar a��l�r.
     2.2.2. Concrete Klas�r�n�n i�ine DataBase de Tablo olu�turacak ve Kal�t�m yolula yetenek kazanacak classlar�m�z� a��yoruz.Product,Supplier,Category..vb.
     2.2.3. Enums Klas�r�n�n i�indede enum classlar�m�z� bar�nd�r�yoruz.

3.Entities Katman� tamamland�ktan sonra 3. Katman�m� Solution �zerinde sa� click yap�p Add New Project deyip librarydan yeni Class Library(.Net Framework) a��l�r ve ismine yine solution Name+Katman Ad� verilir.A�t���m�z Bu Katmandaki a��lan class1'i siler i�erisine Databasele Ba�lant� kuraca��m class olan Context clas�n� bar�nd�r�r�m.
  3.1 �lk�nce Context Ad�nda a��lan dosyan�n i�erisine ProjectContext Ad�nda class a��l�r ve A��lan ProjectContext class�yla :DbContext ile ki bunu Bana Entity Framework sa�lad��� i�in �nce proje �zerine gelip Manage Nuget Packages � t�klay�p Browse t�klay�p Entity Framework 6.4.0 versiyonu indirilir.ProjectContext s�n�f�mda Database de tablo olarak aya�a kalkaca��m  s�n�flar� belirtir ve databasele ba�lant� kurulmas� i�in ctor+tap+tap yap�l�p constractor metodu i�erisine Databaseba�lant�m� yazar�m.

4.T�m Bu i�lemler yap�ld�ktan sonra proje build edilir bir hata yoksa Tools Manage Nuget Packages + Package Manager Consol'a t�klan�p altta a��lan Default Project'te DataAccess Katman� se�ilip console k�sm�na enable+migrations denildikten sonra ekranda ��kan false yazan k�s�m true olarak de�i�tirilir ve tekrardan update-database enter yap�ld�ktan sonra Tablolar SQl de kontrol edilir.

Not: A��lan He Katmanda Enity Framework tekrardan y�klenir.

