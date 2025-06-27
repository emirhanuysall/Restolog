# 🍽️ Restolog: Restoran Takip Uygulaması

Bu proje, C# WinForms ile geliştirilmiş, MSSQL veritabanı ve Entity Framework kullanılarak veri işlemleri gerçekleştirilen bir **restoran takip uygulamasıdır**. Katmanlı mimari yapısıyla esnek, sürdürülebilir ve yönetilebilir bir yazılım altyapısı sunar.

---

## 🧱 Proje Mimarisi

Proje katmanları aşağıdaki gibidir:

- **Entities Layer**  
  Uygulamadaki temel veri modellerini içerir (örneğin: Masa, Ürün, Sipariş, Kullanıcı).

- **DataAccess Layer**  
  Entity Framework kullanılarak veritabanı işlemleri burada tanımlanır (DbContext, Repository yapısı).

- **Core Layer**   
  Ortak yardımcı sınıflar, altyapı servisleri (örneğin:loglama, cache vs.)

- **UI Layer (WinForms)**  
  Masaüstü kullanıcı arayüzü. Sipariş alma, masa yönetimi, ürün görüntüleme gibi işlemleri sağlar.

---

## 💾 Kullanılan Teknolojiler

- .NET Framework / .NET 8
- C# WinForms
- MSSQL (SQL Server)
- Entity Framework
- Katmanlı Mimari Yapı

---

## 🚀 Başlangıç

1. **Veritabanı**:  
   `appsettings.json` içerisinde yer alan connection string'i kendi veritabanı bilgilerinizle güncelleyin.

2. **Migration**:  
 -  Paket Yöneticisi Konsolu’ndan:
`Update-Database`

 - Geliştirici Konsolu'ndan: 
`dotnet ef database update`
  
  Komutlarından birini çalıştırın.


3. **Projeyi Başlatın**:  
`Restolo.UI` projesini başlatın.

---

## 📌 Özellikler

- Masa oluşturma ve düzenleme 
- Sipariş oluşturma ve düzenleme
- Ürün ve kategori yönetimi
- Kullanıcı yönetimi (aktif / pasif filtreleme)
- Filtrelenebilir rapor ekranları

---
*Sistem Analizi ve Tasarımı dersi için geliştirilmiştir.* 
