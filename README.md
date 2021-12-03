# C# Kalıtım/Miras (Inheritance) Nedir?

## Merhaba 👋

C# ile nesne tabanlı programlama dökümanlarında bugün **Kalıtım ve Türetme**'nin dökümanını hazırladım.

## Kalıtım  Nedir?

Programlama kısmından önce okul hayatımızda bile karşımıza çıkan anne ve babamızdan bize geçen genetik/kalıtsal özellikler olarak öğretilen Kalıtım konusu C#'ta çok önemli bir yere sahiptir.

Bir örnek daha verelim, **Car Picker** firmasının **Alien** adlı bir araba ürettiğini varsayalım. Aynı firma daha sonra Alien SUV, E-Alien, Alien Pickup gibi modeller de üretebilir. Sonradan üretilen tüm modeller ilk modelin kalıtımsal özelliklerini taşırlar.

> Bu örneklerden anlaşılacağı gibi, kalıtım sayesinde hızlı üretim yapılır.

Programlama kısmında ise Kalıtım nesne tabanlı programlamanın en önemli konularından biridir. 
Genel olarak kalıtım sınıflar arası hiyerarşik yapıyı oluşturmak için kullanılır. Elimizde olan bir sınıfı temel olarak kabul ederek o sınıftan türetilmiş sınıflar elde edebiliyoruz. Böylece her sınıfta ortak olacak özellikleri tek bir sınıfta topluyoruz. Böylelikle **kod yazım kolaylığı** oluyor ve **sistem yavaşlamıyor** bu da bir yazılımcı için gerçekten mükemmel bir özelliktir.


>Ufak bir bilgi vereyim

Büyük yazılım projelerinde genellikle önce temel sınıf oluşturulur daha sonra program küçük parçalara bir nevi modüllere bölünür. Her modül farklı bir yazılımcı tarafından yazılır. Böylelikle hem belli bir temel mantığı kullanarak kod yazarlar ve projeyi daha hızlı geliştirirler çünkü temel sınıfta ihtiyaç duyulan çoğu veri ve metot kendilerine hazır olarak verilir.

## Miras Nedir?

En basit tanımı ile bir sınıfı miras alarak, onun metotlarını kullanan başka sınıflar türetebilmemizi sağlayan kavramdır.

> Miras veren sınıfa **Based** class, miras alan sınıfa **Drived** class denir.


### Sınıfı Abstract İle Soyutlama

Sınıfın sadece türetileceğini belirtmek için sınıfı **Abstract** keyword'ü ile soyuladım.
```C#
    public abstract class Person
```

### Değişken Tanımlama

Türetilecek olan sınıflarda kullanılması için 4 tane değişken tanımladım.

```C#
 protected string Adı;
        protected string Soyadı;
        protected DateTime DogumTarihi;
        protected string Cinsiyeti;
```

### makeAction Methodu

Türetilen sınıflarda methodun içinin doldurulması için **abstract** olarak makeAction methodu kullandım.

```C#
        public abstract void makeAction();
        public abstract void YemekYe();
        public abstract void SuIc();
        public abstract void Calis();
        public abstract void Uyu();

```

**Abstract** methodlar kesinlikle türetildikleri sınıflarda da tanımlanmalıdır.
Eğer burada tanımlanan **abstract** methodlar türetildikleri sınıflar kullanılmazlarsa 
**'Student' does not implement inherited abstract member 'Person.Deneme()'** şeklinde bir hata alırız.


> Dökümanları kendimi geliştirmek için hazırlıyorum. Kesinlikle eğitim amaçlı değildir.





