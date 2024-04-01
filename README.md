# EFCore-CaloriProject
Lose it!

Kullanılan Teknolojiler

Geliştirme Ortamı: Ms Visual Studio 2022

Kod Altyapısı: C#, .NET CORE 8.0

Mimari Tasarım: N-Tier Katmanlı Mimari

Veri Tabanı: Ms SQL Server

Veri Erişim Teknolojisi: Entity Framework CORE (CodeFirst)

Arayüz Tasarımı: Windows Forms Application

Versiyon Kontrol Sistemi: Git

Projeyi Başlatma

CaloriProject.DAL katmanında bulunan CaloriDBContext.cs dosyasındaki server bağlantısını düzenleyin.

PM Console'da add-migration [Migration Adı] komutunu yazıp çalıştırın.

PM Console'da update-database diyerek veritabanını oluşturun.

KULLANICI KARSILAMA EKRANI
![1](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/f87f7c68-7e2b-4d72-b74b-eceb89d3988b)

KULLANICI YENI KAYIT EKRANI

• Kisiye ait tüm verilerin eksiksiz doldurulmasi ve gerekli kontrollerle istenilen formatlarda ve kriterlerde bilgi alinmasi saglanmistir.
![2](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/d98d6660-7ae0-40b5-aae6-652c8866e254)

KULLANICI GIRIS EKRANI

• Kullaniciya ait e-mail ve sifre ile giris yapilan ve sonraki sayfalara aynı kullanicinin verilerini referans verecek olan giris ekranidir.
![3](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/3fa3ffda-2d15-4632-81a7-79ea3406daa6)





ANASAYFA

• Kullaniciyi kendi verileriyle karsilayan ve ogun islemleri, yiyecek ekleme, raporlar ve ayarlar sayfalarına yonlendirmesini saglayan anasayfa ekranidir. Kullanici cikis yap butonuna basarsa kendi profilinden cikisi yapilir ve tekrar kullanici giris ekranina yonlendirilir. Program hic kapanmadan istenilen miktarda kullanici profili ile giris ve cikis yapilabilmektedir.
![4](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/d5584cf1-e083-4738-879d-9bdf7f464fa9)





OGUN ISLEMLERI

• Kullanici kendi mevcut verilerine istinaden burada eski ogun islemlerini gorebilir, diledigi kadar ogun ekleme,silme ve guncelleme islemlerini sorunsuz gerceklestirebilir.
![5](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/aae2e68e-6e36-405b-8e80-f9f5e852346a)





KULLANICI AYAR SAYFASI

• Kullanici kendi profil olusturma verilerini ekranda görür ve programcının izin verdigi olcude kisisel bilgilerini guncelleyebilir.
![6](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/6b304ed5-707b-4e29-8191-f609fb378b32)





RAPOR SAYFASI - GUN SONU RAPORU

• Kullanici bu ekranda üstteki tarihi secerek o gune ait ogun verilerini ve toplam alınan miktari kalori cinsinden gorur.
![7](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/c59f28b1-8306-4d90-8db1-8dbf05625ff8)





RAPOR SAYFASI - KIYAS RAPORU

• Kullanici bu ekranda kendine ve diger kullanicilara ait yakın tarihli verileri gorup, detayli inceleyebilir.
![8](https://github.com/BurakGonca/EFCore-CaloriProject/assets/154968593/88fcadeb-c4bc-4a72-bc66-9e64a1201e9e)





## Contributors

- [@furkanbaybura](https://github.com/furkanbaybura)
- [@mehmetcagri39](https://github.com/mehmetcagri39)




