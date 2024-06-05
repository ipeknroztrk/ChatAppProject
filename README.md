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
  
