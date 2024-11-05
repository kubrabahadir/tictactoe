# Tic Tac Toe Oyunu - README

---

## Genel Bakış

**Tic Tac Toe Oyunu** projesine hoş geldiniz! Bu proje, tasarım kalıplarını kullanarak klasik XOX oyununun verimli ve ölçeklenebilir bir yapıda kodlanmasını sağlamak amacıyla geliştirilmiştir. C# dilinde yazılan proje, kod organizasyonunu öğrenmek ve oyun geliştirmede kullanılan tasarım kalıplarını incelemek isteyenler için harika bir referans niteliğindedir.

---

## Özellikler

- **Tasarım Kalıbı Kullanımı**: Kod yapısı, oyunun verimli ve yeniden kullanılabilir olmasını sağlayan çeşitli tasarım kalıplarını kullanarak organize edilmiştir.
- **Klasik XOX Kuralları**: 3x3'lük ızgarada iki oyuncu ("X" ve "O") ile oynanır.
- **Basit ve Kullanıcı Dostu Arayüz**: Konsol tabanlı arayüz sayesinde oyun kolayca oynanabilir.

---

## Gereksinimler

- **Platform**: .NET Framework veya .NET Core (uyumlu bir IDE, örneğin Visual Studio, `.sln` dosyasını açabilmelidir).

---

## Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza klonlayın veya indirin.
2. Visual Studio veya uyumlu bir IDE ile projeyi açın.
3. Proje klasöründe bulunan `.sln` dosyasını bulun ve açın.
4. Projeyi çalıştırmadan önce derleyin ve tüm bağımlılıkların yüklendiğinden emin olun.
5. Projeyi çalıştırarak oyunu başlatın.

---

## Oynanış

1. `.sln` dosyasını açarak projeyi çalıştırın.
2. Oyun, bir konsol penceresinde 3x3'lük bir ızgara ile başlar.
3. Oyuncular, sırasıyla 1'den 9'a kadar olan pozisyonları girerek "X" veya "O" simgelerini yerleştirir.
4. Bir oyuncu ardışık üç sembolü yatay, dikey veya çapraz sıraya dizdiğinde oyun biter. Eğer ızgara dolarsa ve kimse kazanamazsa oyun berabere sonuçlanır.

![image](https://github.com/user-attachments/assets/202ac569-ee17-4448-b89f-8baaa585f561)


---

## Tasarım Kalıpları

Bu projede kullanılan başlıca tasarım kalıpları şunlardır:

- **Factory Pattern (Fabrika Kalıbı)**: Oyuncu ve hücre gibi oyun objelerini yaratmak için kullanılır.
- **Observer Pattern (Gözlemci Kalıbı)**: Oyun durumu ve ekran güncellemelerinin eş zamanlı olarak yapılmasını sağlar.
- **Strategy Pattern (Strateji Kalıbı)**: Farklı oyun kuralları veya kazanma koşullarının kolayca değiştirilmesine olanak tanır.

---

