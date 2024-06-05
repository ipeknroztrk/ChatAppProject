CHATAPPROJECT ASP.NET CORE

Bu projenin temeli, ASP.NET Core Identity kullanarak hazırlanmış bir mesajlaşma uygulamasıdır. Kullanıcılar, e-posta adresleriyle kayıt olabilirler ve kayıt olduktan sonra bu e-posta adresleri ve şifreleriyle sisteme giriş yaparlar. Giriş yaptıktan sonra, kullanıcılar yeni mesajlar gönderebilir, gönderdikleri mesajları görüntüleyebilir ve istedikleri zaman silebilirler. Ancak, gönderdikleri mesajlar sadece kendi listelerinden silinir. Aynı şekilde, diğer kullanıcıların gönderdiği mesajları listeleyebilir, okunmamış mesajları belirgin şekilde işaretleyebilir, çöpe taşıyabilir ve kalıcı olarak silebilirler. Mesaj gönderme sayfasında kullanılan bir metin düzenleyici aracı sayesinde, kullanıcılar gönderecekleri mesajın içeriğini şekillendirebilirler (yazı tipi, boyutu, rengi, görsel ekleme, link ekleme vb.).

Kullanılan Teknolojiler ve Yaklaşımlar:

- **ASP.NET Core 6:** Proje, en son .NET Core sürümü olan .NET Core 6 kullanılarak geliştirilmiştir. Bu sürüm, performans iyileştirmeleri ve yeni özelliklerle birlikte gelir, böylece uygulamanın güncel ve verimli olmasını sağlar.

- **Identity:** ASP.NET Core Identity, kullanıcı kimlik doğrulaması ve yetkilendirme işlemlerini sağlar. Bu proje, kullanıcıların kimlik doğrulamasını ve yetkilendirme işlemlerini Identity kullanarak gerçekleştirir.

- **Code First:** Entity Framework Core ile Code First yaklaşımı kullanılarak veritabanı tasarlanır. Bu, veritabanını kod tarafında tanımlamanızı ve Entity Framework'un bunu otomatik olarak veritabanına dönüştürmesini sağlar.

- **Entity Framework:** Entity Framework, veritabanı işlemlerini yönetmek için kullanılan bir ORM (Object-Relational Mapping) aracıdır. Bu projede, Entity Framework Core kullanılarak veritabanı işlemleri gerçekleştirilir.

- **Çok Katmanlı Mimari:** Proje, katmanlı mimari yaklaşımı kullanılarak geliştirilmiştir. Bu yaklaşım, uygulamanın farklı işlevlerini mantıksal olarak ayrılmış katmanlara böler, bu da kodun daha düzenli ve bakımı daha kolay hale gelmesini sağlar.

- **Fluent Validation:** Fluent Validation, giriş doğrulama ve doğrulama kurallarını tanımlamak için kullanılan bir kütüphanedir. Bu proje, Fluent Validation kullanarak giriş doğrulama işlemlerini gerçekleştirir, böylece kullanıcıların geçersiz veri girişlerini önler ve uygulamanın güvenliğini artırır.
  PROJEYE AİT GÖRSELLER
  
<img width="1440" alt="Ekran Resmi 2024-06-05 20 57 26" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/2e332037-9257-4762-9ea7-c34dba718f43">
<img width="1440" alt="Ekran Resmi 2024-06-05 20 57 33" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/d19831df-c084-4afa-9ff4-00df43a55b81">
<img width="1440" alt="Ekran Resmi 2024-06-05 20 57 50" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/63617999-1de5-4ed6-aa54-81b55d05c70a">
<img width="1440" alt="Ekran Resmi 2024-06-05 20 58 54" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/35a09d66-3249-41f0-a1a8-4761fcaa905c">
<img width="1440" alt="Ekran Resmi 2024-06-05 20 59 05" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/52462fef-bc62-4954-aae5-c6e5f65221ab">
<img width="1440" alt="Ekran Resmi 2024-06-05 21 05 51" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/f40fe1a3-f3fb-4d54-8a10-3589c361e94c">
<img width="1440" alt="Ekran Resmi 2024-06-05 21 07 13" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/a34ad5c5-7ab4-4727-866b-7be826e48267">
<img width="1440" alt="Ekran Resmi 2024-06-05 21 21 20" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/e9c1fc25-b2d1-419e-b15a-9d3f5a789b38">
<img width="1006" alt="Ekran Resmi 2024-06-05 21 21 57" src="https://github.com/ipeknroztrk/ChatAppProject/assets/114228895/d5a5526e-b6eb-47fe-abbb-43766ec3112e">
