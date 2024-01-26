-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 23 Oca 2024, 18:19:09
-- Sunucu sürümü: 10.4.32-MariaDB
-- PHP Sürümü: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `personelotomasyon`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_izin`
--

CREATE TABLE `tbl_izin` (
  `id` int(11) NOT NULL,
  `adsoyad` varchar(255) NOT NULL,
  `sebep` varchar(255) NOT NULL,
  `sicil_no` varchar(255) NOT NULL,
  `baslangic_tarih` date NOT NULL,
  `bitis_tarih` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `tbl_izin`
--

INSERT INTO `tbl_izin` (`id`, `adsoyad`, `sebep`, `sicil_no`, `baslangic_tarih`, `bitis_tarih`) VALUES
(79, ' Melisa Kale', 'ads', '1045', '2024-01-07', '2024-01-07'),
(78, ' sıla çatak', 'asd', '21', '2024-01-07', '2024-01-07');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_mesai`
--

CREATE TABLE `tbl_mesai` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `sicil_no` varchar(50) NOT NULL,
  `tarih_saat` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_ozelgun`
--

CREATE TABLE `tbl_ozelgun` (
  `id` int(11) NOT NULL,
  `tarih` date NOT NULL,
  `ad` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `tbl_ozelgun`
--

INSERT INTO `tbl_ozelgun` (`id`, `tarih`, `ad`) VALUES
(22, '2024-08-30', 'zafer bayramı'),
(24, '2024-01-01', 'yılbaşı');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_personel`
--

CREATE TABLE `tbl_personel` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `rol` varchar(50) NOT NULL DEFAULT 'Kullanıcı',
  `sicil_no` int(11) NOT NULL,
  `kadro_tipi` varchar(255) NOT NULL,
  `unvan` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `sifre` varchar(255) NOT NULL,
  `telefon` varchar(50) NOT NULL,
  `tc_no` varchar(50) NOT NULL,
  `adres` varchar(300) NOT NULL,
  `izin_1` varchar(50) NOT NULL,
  `izin_2` varchar(50) DEFAULT NULL,
  `prim` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `tbl_personel`
--

INSERT INTO `tbl_personel` (`id`, `ad`, `soyad`, `rol`, `sicil_no`, `kadro_tipi`, `unvan`, `email`, `sifre`, `telefon`, `tc_no`, `adres`, `izin_1`, `izin_2`, `prim`) VALUES
(18, 'Yıldırım', 'Karagül', 'Yönetici', 103, 'İşçi', 'Güvenlik', 'ykaragul@mail.com', '123123', '05555555555', '11111111111', '', 'Sunday', 'Monday', 24000),
(19, 'Melisa', 'Kale', 'Kullanıcı', 1045, 'Memur', 'Güvenlik', 'mkale@mail.com', '123123', '1221231', '11111111111', 'Adana', 'Monday', 'Yok', 48000),
(22, 'sıla', 'çatak', 'Kullanıcı', 21, 'İşçi', 'akademisyen', 'sıla@mail.com', '123123', '555555', '1111111', 'manisa', 'Friday', 'Monday', NULL),
(26, 'Feyziye', 'Kaymaz', 'Yönetici', 7, 'İşçi', 'Hayatımın Anlamı', 'feyziye@gmail.com', '777', '7777', '777', 'asd', 'Monday', 'Monday', NULL);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tbl_vardiya`
--

CREATE TABLE `tbl_vardiya` (
  `id` int(11) NOT NULL,
  `ad` varchar(255) NOT NULL,
  `soyad` varchar(255) NOT NULL,
  `sicil_no` varchar(100) NOT NULL,
  `tarih_gun` date NOT NULL,
  `tarih_saat` varchar(50) NOT NULL,
  `bolge` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Tablo döküm verisi `tbl_vardiya`
--

INSERT INTO `tbl_vardiya` (`id`, `ad`, `soyad`, `sicil_no`, `tarih_gun`, `tarih_saat`, `bolge`) VALUES
(874, 'Yıldırım', 'Karagül', '103', '2024-01-07', '09:00-17:00', 'Kampus Ici'),
(875, 'Feyziye', 'Kaymaz', '7', '2024-01-07', '00:00-08:00', 'Kampus Girisi'),
(876, 'Yıldırım', 'Karagül', '103', '2024-01-08', '09:00-17:00', 'Kampus Ici'),
(877, 'Melisa', 'Kale', '1045', '2024-01-08', '00:00-08:00', 'Kampus Girisi'),
(878, 'sıla', 'çatak', '21', '2024-01-08', '08:00-16:00', 'Kampus Girisi'),
(879, 'Feyziye', 'Kaymaz', '7', '2024-01-08', '16:00-24:00', 'Kampus Girisi');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `tbl_izin`
--
ALTER TABLE `tbl_izin`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_mesai`
--
ALTER TABLE `tbl_mesai`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_ozelgun`
--
ALTER TABLE `tbl_ozelgun`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_personel`
--
ALTER TABLE `tbl_personel`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `tbl_vardiya`
--
ALTER TABLE `tbl_vardiya`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `tbl_izin`
--
ALTER TABLE `tbl_izin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=80;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_mesai`
--
ALTER TABLE `tbl_mesai`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=174;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_ozelgun`
--
ALTER TABLE `tbl_ozelgun`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_personel`
--
ALTER TABLE `tbl_personel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- Tablo için AUTO_INCREMENT değeri `tbl_vardiya`
--
ALTER TABLE `tbl_vardiya`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=888;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
