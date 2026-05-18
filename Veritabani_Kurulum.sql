--  KursiyerTakipSistemi adında veritabanı oluşturuldu
CREATE DATABASE KursiyerTakipSistemi;
GO

-- Oluşturduğumuz bu veritabanının içine giriş yapıyoruz
USE KursiyerTakipSistemi;
GO

-- 3. Kursların bilgilerini tutacağımız tablo
CREATE TABLE Kurslar (
    KursNumarasi INT PRIMARY KEY IDENTITY(1,1), -- IDENTITY(1,1) sayesinde numaralar 1, 2, 3 diye otomatik artar
    KursAdi NVARCHAR(100) NOT NULL,            -- NOT NULL boş bırakılamaz demektir
    EgitmenAdi NVARCHAR(50)
);

-- Kursiyerlerin bilgilerini tutacağımız ana tablo
CREATE TABLE Kursiyerler (
    KursiyerNumarasi INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    TelefonNumarasi NVARCHAR(15),
    -- Hangi kursa kayıtlı olduğunu belirtmek için Foreign Key ile Kurslar tablosuna bağlıyoruz
    KayitliOlduguKurs INT FOREIGN KEY REFERENCES Kurslar(KursNumarasi)
);

-- Günlük yoklamaları tutacağımız tablo
CREATE TABLE YoklamaDurumlari (
    YoklamaNumarasi INT PRIMARY KEY IDENTITY(1,1),
    KursiyerNumarasi INT FOREIGN KEY REFERENCES Kursiyerler(KursiyerNumarasi), -- Öğrenci tablosuna bağlı
    YoklamaTarihi DATE NOT NULL,
    DerseGeldiMi BIT NOT NULL -- BIT türü C#'taki bool gibidir.
);
-- Sisteme 2 adet örnek kurs ekledik.
INSERT INTO Kurslar (KursAdi, EgitmenAdi) VALUES ('C# ile Görsel Programlama', 'Ali Yılmaz');
INSERT INTO Kurslar (KursAdi, EgitmenAdi) VALUES ('SQL Veritabanı Yönetimi', 'Ayşe Demir');