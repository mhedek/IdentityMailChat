# ✉️ ASP.NET Core Identity ile Kullanıcı Kayıt & Mesajlaşma Uygulaması

🚀 ASP.NET Core MVC & Identity kullanılarak geliştirilmiş, kullanıcıların sisteme **kayıt olabildiği**, **giriş yapabildiği**, **profilini görüntüleyebildiği** ve birbirlerine **mesaj gönderip alabildiği** dinamik bir web uygulamasıdır.
📌 **Bu proje, M&Y Yazılım Eğitim Akademisi 7. Dönem kapsamında, Murat Yücedağ yönetiminde geliştirilmiştir.**

## 📌 Özellikler

✅ Kullanıcı Kayıt (Register)  
✅ Güçlü şifre zorunluluğu (Özelleştirilmiş Türkçe hata mesajları)  
✅ Kullanıcı Giriş (Login)  
✅ Profil Bilgisi Görüntüleme  
✅ Mesaj Gönderme (Sendbox)  
✅ Gelen Kutusu (Inbox)  
✅ Mesaj Detayları  
✅ Entity Framework ile veri tabanı işlemleri  
✅ ViewModel yapısı ile katmanlı mimari

## Kullanılan Teknolojiler

- ASP.NET Core MVC
- ASP.NET Core Identity
- Entity Framework Core
- SQL Server

## Katmanlar

- **Controller'lar**
  - `RegisterController`: Kayıt işlemlerini yönetir.
  - `LoginController`: Giriş işlemlerini yönetir.
  - `MessageController`: Mesaj gönderme, alma ve kullanıcı profili işlemlerini yürütür.

- **ViewModel'ler**
  - `RegisterViewModel`: Kayıt için gerekli kullanıcı bilgilerini içerir.
  - `LoginViewModel`: Giriş bilgilerini içerir.

- **Veri Tabanı**
  - `CaseContext`: Identity veritabanına ek olarak `Messages` tablosunu içerir.

- **Özelleştirme**
  - `CustomIdentityValidator`: Şifre politikaları için özel hata mesajları tanımlar.

---
📂 NuGet Bağımlılıkları

Projenin çalışabilmesi için aşağıdaki NuGet paketlerinin yüklü olması gerekir:

Microsoft.AspNetCore.Identity.EntityFrameworkCore

Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools

Microsoft.AspNetCore.Identity

Microsoft.EntityFrameworkCore

Microsoft.EntityFrameworkCore.Design

| Sayfa            | Yol                      |
| ---------------- | ------------------------ |
| 📝 Kayıt Sayfası | `/Register/CreateUser`   |
| 🔑 Giriş Sayfası | `/Login/UserLogin`       |
| 💌 Mesaj Gönder  | `/Message/CreateMessage` |
| 📥 Gelen Kutusu  | `/Message/Inbox`         |
| 📤 Giden Kutusu  | `/Message/Sendbox`       |
| 🙍 Profil        | `/Message/Profile`       |

---
🔐 Şifre Kuralları
🔡 En az bir küçük harf içermeli

🔠 En az bir büyük harf içermeli

🔢 En az bir rakam içermeli

🔣 En az bir özel karakter içermeli

📏 En az 6 karakter uzunluğunda olmalı
---

💡 Geliştirici Notları

Tüm kullanıcı işlemleri ASP.NET Identity tarafından yönetilir.

ViewModel yapıları ile yalnızca gerekli alanlar işlenir.

Şifreler sistem tarafından otomatik olarak hashlenir, ekstra işlem gerekmez.

TempData kullanılarak mesaj gönderimi sonrası kullanıcı bilgilendirilir.
---

## 📸 Uygulama Ekran Görüntüleri
Aşağıda uygulamanın temel sayfalarına ait ekran görüntüleri yer almaktadır:

---

### 📝 Kayıt Sayfası (Register)

Yeni kullanıcıların sisteme kaydolabildiği sayfadır. ASP.NET Identity ile entegre olup şifre kuralları özel olarak tanımlanmıştır.

![Register Page](https://github.com/user-attachments/assets/40fe8edd-26d8-49eb-ac67-6765978e0031)

---

### 🔐 Giriş Sayfası (Login)

Kullanıcıların sisteme erişebilmesi için kullanıcı adı ve şifre bilgilerini girdiği sayfadır. Başarılı giriş sonrası gelen kutusuna yönlendirme yapılır.

![Login Page](https://github.com/user-attachments/assets/2c0e939d-9480-4bc1-98c9-a4588a5e05f9)

---

### 💌 Mesaj Oluşturma Sayfası

Kullanıcının yeni bir mesaj yazıp başka bir kullanıcıya gönderebildiği sayfadır. Gönderim sonrası giden kutusuna yönlendirme yapılır.

![Create Message Page](https://github.com/user-attachments/assets/64cb5688-8aee-4a23-a0b6-d4ae527f8508)

---

### 📤 Giden Kutusu (Sendbox)

Kullanıcının daha önce gönderdiği tüm mesajları listeleyen sayfadır. Mesaj detaylarına erişim mümkündür.

![Inbox Page](https://github.com/user-attachments/assets/f3d2d362-3c89-4814-b33e-335b670f33b9)

---

### 👤 Profilim Sayfası

Bu sayfada oturum açmış olan kullanıcının kişisel bilgileri (ad, soyad, e-posta) görüntülenir.  
Ayrıca kullanıcıya özel olarak gelen ve gönderilen mesaj sayıları istatistiksel olarak sunulur.

![Profilim Page](https://github.com/user-attachments/assets/d5cf0def-32c6-44e2-90b3-ae592ad802b7)

---

### 📄 Mesaj Detayları Sayfası

Kullanıcı, gelen veya giden kutusundaki herhangi bir mesaja tıklayarak bu detay sayfasına ulaşabilir.  
Mesajın konusu, içeriği, gönderici/alıcı bilgisi ve gönderim tarihi gibi tüm ayrıntılar burada yer alır.

![Message Details Page](https://github.com/user-attachments/assets/f6373da5-3d5c-4c4b-abf1-21edc671c65a)

--
