# 🎬 MovieApi

`MovieApi`, .NET Core 9.0 kullanılarak geliştirilen ve **IMDB tarzı dizi/film puanlama** hizmeti sunmayı amaçlayan modern bir web API projesidir. Proje, sürdürülebilirlik ve genişletilebilirlik açısından **Onion Architecture (Soğan Mimarisi)** ile yapılandırılmıştır ve güçlü bir yazılım tasarımı için **CQRS (Command Query Responsibility Segregation)** ve **Mediator** desenleri kullanılmaktadır.

> 🔧 Proje hâlen geliştirilme aşamasındadır. Geri bildirimlere ve katkılara açıktır!

---

## 🚀 Özellikler

- 🎯 Modern ve katmanlı **Onion Architecture** yapısı
- 🧠 Ayrık komut ve sorgu işlemleri için **CQRS Pattern**
- 📨 **Mediator Pattern** ile loosely coupled yapı
- 📦 **Entity Framework Core** ile veri erişimi
- 🧪 Entegre **Swagger (OpenAPI)** desteği ile API testleri
- 🗃️ **MS SQL Server** veritabanı entegrasyonu
- 🔐 Kimlik doğrulama ve yetkilendirme (geliştirme planı)
- 📈 Gelişmiş puanlama ve yorum sistemi (planlanan özellik)

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Açıklama |
|----------|----------|
| [.NET Core 9.0](https://dotnet.microsoft.com/) | Web API geliştirme platformu |
| C# | Ana yazılım dili |
| **Onion Architecture** | Katmanlı mimari yaklaşımı |
| **CQRS** | Komut ve sorgu ayrımı |
| **MediatR** | CQRS için mediator yapısı |
| **Entity Framework Core** | ORM aracı |
| **Swagger / Swashbuckle** | API dokümantasyonu ve test |
| **MS SQL Server** | Veritabanı sistemi |
---


## 🧱 Proje Mimarisi

Proje, Onion (Soğan) mimarisine uygun olarak 4 ana katmana ayrılmıştır:

- **MovieApi.API** → Sunum katmanı (Controller, Swagger, Middleware)
- **MovieApi.Application** → Uygulama mantığı (CQRS, MediatR, DTO)
- **MovieApi.Domain** → Temel iş modelleri (Entity, Enum, Interface)
- **MovieApi.Infrastructure** → Veritabanı işlemleri, repository, context

