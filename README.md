<h1>Blog Proje</h1>
<p align="justify">Geliştirilen blog projesi, kullanıcıların kişisel profil sayfalarında kendileri hakkında çeşitli bilgileri paylaştıkları, deneyimlerini, becerilerini ve ilgi alanlarını detaylı bir şekilde açıkladıkları; aynı zamanda diğer kullanıcılarla etkileşimde bulunarak fikir alışverişi yapabildikleri bir platformdur.</p>

<h3>1. Kullanılan Teknolojiler</h3>
Asp.Net Core Mvc & Api, EntityFrameworkCore, FluentValidation, MSSQL, N Tier Architecture
<br><br>
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim1.PNG" height="300px">
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim2.PNG" height="300px">
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim3.PNG" height="300px">
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim4.PNG" height="300px">
Yazar kısmı:
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim5.PNG" height="300px">
Admin kısmı:
<img src="Core_Proje/wwwroot/ProjectImage/Projeresim6.PNG" height="300px">

<h3>2. Projede Kullanılan Mimarinin Genel Hatları </h3>
<img src="Core_Proje/wwwroot/ProjectImage/Blogprojectarch.PNG" height="350px" width="600px">

<h3>3. Kurulum: </h3>
 - Projede DataAccessLayer -> Concrete -> Context.cs dosyasını açınız, UseSqlServer metodunda belirtilen veritabanı bağlantı dizesini kendi veritabanı bağlantı dizenize göre güncelleyiniz.<br>
 - Ardından Visual Studio aracının üst sekmesinden view -> other windows -> package manager console kısmına tıklayınız.<br>
 - Ardından açılan pencerede default project yazan yere tıklayıp açılan seçim ekranından DataAccessLayer katmanını seçiniz.<br>
 - Açılan pencereye "update-database" yazıp enter'a tıklayınız.(ilgili veritabanı ve tabloları SSMS'de oluşacaktır.)<br>
 - Ardından DailyShop.API projesine sağ tık yapıp "Set as Startup Project" deyiniz ve API'yi ayağa kaldırınız.
