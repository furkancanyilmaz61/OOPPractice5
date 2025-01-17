# 🚗 Araba Sınıfı Uygulaması

Bu proje, bir **Araba** sınıfını tanımlayarak sınıf özelliklerinin kontrolünü sağlamayı ve kapsülleme (encapsulation) kullanarak doğru veri girişini garanti altına almayı amaçlar. Özellikle kapı sayısının belirli bir aralıkta kontrol edilmesiyle hata yönetimi uygulanmıştır.

---

## 🚀 Proje Özellikleri

### 📦 Araba Sınıfı

`Araba` sınıfı, bir araba nesnesinin temel özelliklerini içerir:

- **Marka (string)**: Arabanın markası.
- **Model (string)**: Arabanın modeli.
- **Renk (string)**: Arabanın rengi.
- **KapiSayisi (int)**: Arabanın kapı sayısı. _(Kapsülleme ile kontrol edilir, yalnızca 2 veya 4 olabilir.)_

---

### 🔨 Özellikler ve Kapsülleme

1. **KapiSayisi Özelliği**:
   - `get`: Kapı sayısını döndürür.
   - `set`: Yalnızca **2** veya **4** değerlerini kabul eder. Geçersiz bir değer girilirse:
     - Konsola bir uyarı mesajı yazdırılır.
     - Kapı sayısı otomatik olarak `-1` olarak ayarlanır.

   Örnek Uyarı Mesajı:
   ```plaintext
   Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Geçersiz değer atandı, Kapı Sayısı -1 olarak ayarlandı.
