# TextboxEBook

TextboxEBook, modern bir kitap satış sitesi örneğidir. Proje .NET Core 3.1, Bootstrap, HTML ve CSS kullanılarak geliştirilmiştir. Clean architecture yapılandırılmış olan bu proje; temiz kod yapısı, sürdürülebilirlik ve genişletilebilirlik gibi yazılım prensipleri göz önünde bulundurularak oluşturulmuştur.

---

##  Özellikler

-  Kitap listeleme ve detay sayfaları
-  Katmanlı mimari (UI, Business, DAL, Entity)
-  Responsive arayüz tasarımı (Bootstrap destekli)
-  Kolay geliştirme ve özelleştirme için modüler yapı
-  Temel CRUD operasyonları için hazır altyapı

---

##  Kullanılan Teknolojiler ve Kütüphaneler

| Teknoloji/Kütüphane | Açıklama |
|---------------------|----------|
| [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet/3.1) | Uygulama çatısı ve backend geliştirme |
| **C#** |
| **ASP.NET Core MVC** | Web uygulaması mimarisi |
| **Entity Framework Core** | ORM (Veritabanı işlemleri için) |
| **HTML5** | Web sayfası iskeleti |
| **CSS3** | Stil ve görünüm |
| [Bootstrap 4+](https://getbootstrap.com/) | Duyarlı ve modern tasarım için CSS framework |
---

##  Proje Mimarisi

Proje 4 ana katmandan oluşur:

- **TextboxBook.UI** – Kullanıcı arayüzü (View + Controller)
- **TextboxBook.Business** – İş mantığı ve servisler
- **TextboxBook.Dal** – Veri erişim katmanı (Repository Pattern)
- **TextboxBook.Entity** – Veri modelleri (POCO sınıfları)

---

##  Kurulum ve Çalıştırma

### 1. Depoyu Klonlayın

```bash
git clone https://github.com/megfb/TextboxEBook.git
```

### 2. Projeyi Açın

Visual Studio 2019/2022 veya Visual Studio Code ile `TextboxBook.sln` dosyasını açın.

### 3. Gerekli NuGet Paketlerini Yükleyin

```bash
dotnet restore
```

### 4. Uygulamayı Başlatın

```bash
dotnet run --project TextboxBook.UI
```

Tarayıcınızdan aşağıdaki adreslerden erişim sağlayabilirsiniz:

- http://localhost:5000
- https://localhost:5001

---


## 🤝 Katkıda Bulunma

Her katkı değerlidir! Katkı sağlamak için şu adımları izleyebilirsiniz:

1. Bu repoyu **fork**'layın.
2. Yeni bir branch oluşturun: `git checkout -b feature/yenilik`
3. Geliştirmelerinizi yapın ve commit edin: `git commit -m "Yeni özellik eklendi"`
4. Branch'i push edin: `git push origin feature/yenilik`
5. Pull Request oluşturun.

---

> Geliştirici: [megfb](https://github.com/megfb)  
> Proje: **TextboxEBook**  
