# Projenin Amacı
Kullanıcının girdiği son 3 yıla ait ekonomik verileri (Dolar, Euro, Altın) temel alarak, geçmiş trendler doğrultusunda gelecek 5 yılın kur tahminlerini hesaplamak ve kullanıcının ana parasını en iyi şekilde nasıl değerlendirebileceğine dair veri temelli bir tavsiye sunmaktır.

# Kullanılan Teknikler & Özellikler
* Bileşik Büyüme Modeli: Her yılın tahmini, hesaplanan ortalama artış oranına göre bir önceki yılın üzerine eklenerek hesaplanır.
* Bölgesel Format Uyumu: "en-US" entegrasyonu ile ondalık sayı girişlerindeki (nokta/virgül) hatalar engellenmiştir.
* Karar Mekanizması: 5. yılın sonundaki toplam bakiye tahminlerini karşılaştırarak en kârlı yatırım aracını dinamik olarak seçer.
* Döngüsel Hesaplama: Gelecek 5 yılın verilerini "for" döngüsü ile sistematik olarak listeler.

# Nasıl Çalışır?
1. Program kullanıcıdan Dolar, Euro ve Altın'ın son 3 yıllık birim fiyatlarını ister.
2. Yazılım, bu verilerden yıllık ortalama artış oranlarını türetir.
3. Kullanıcı yatırım yapmak istediği ana parayı (TL) girer.
4. Program, 5 yıllık projeksiyonu listeler ve 5. yılın sonunda en yüksek getiriyi sağlayacak varlığı "Yatırım Danışmanı Önerisi" olarak sunar.
