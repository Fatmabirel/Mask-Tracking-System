# Maske Takip Sistemi📝
Bu proje [Engin Demiroğ](https://github.com/engindemirog) ve ekibi tarafından, Yazılım Geliştirici Yetiştirme Kampı (C#) çerçevesinde geliştirilmiş bir ödev olarak hazırlanmıştır. 

#### GEREKSİNİMLER 🛠
- [x] Web projesi: 
  ![Asp.NET Web API](https://img.shields.io/badge/asp.net%20web%20api-%231BA3E8.svg?style=for-the-badge&logo=dotnet&logoColor=white)


#### PROJEDE KULLANILAN TEKNOLOJİLER VE KÜTÜPHANELER 🛠️
<p>
  <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white" />
  <img alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
  <img alt="Entity Framework" src="https://img.shields.io/badge/entity%20framework-%2358B9C9.svg?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img alt="Visual Studio" src="https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visualstudio&logoColor=white" />
  <img alt="Github" src="https://img.shields.io/badge/github-%23121011.svg?style=for-the-badge&logo=github&logoColor=white" />
</p>


#### 📫 NASIL BİR PROJE OLUŞTURDUK?
<p>Bu proje, pandemi sebebiyle ortaya çıkan maske ihtiyacını gidermek amacıyla vatandaşlara maske dağıtmayı sağlayan basit ve kullanıcı dostu bir web projesidir. Sistem, kullanıcıların maske talep etmelerine olanak sağlar.</p>

<p> İki tip kullanıcı bulunmaktadır: </p>

➡️ 1- Vatandaş 

- [x] Hasta maske talebinde bulunabilir.

➡️ 2- Dağıtıcı 
- [x] Dağıtıcı, hastanın bilgilerini MERNİS doğrulaması ile kontrol ederek maske dağıtımını sağlar.

## PROJE DETAYLARI📝

Projemiz, .Net teknolojisiyle oluşturulmuş basit bir web uygulamasıdır.

Proje geliştirilirken, yazılımın sürdürülebilirliğini ve genişletilebilirliğini sağlamak amacıyla **SOLID** prensiplerine uygun bir yaklaşım benimsenmiştir. Bu sayede, sistemin bakım ve geliştirme süreçleri daha kolay ve verimli bir şekilde yürütülebilmektedir.

Ek olarak kullanıcıların kimlik doğrulama süreçlerini daha güvenli ve verimli hale getirmek için Mernis doğrulama hizmetini mikroservis mimarisi ile entegre ettik. Bu mikroservis, kimlik doğrulama işlemlerini merkezi bir noktada toplayarak, sistemin genel performansını ve güvenliğini artırmaktadır.

🎯 Projede MERNIS doğrulama işlemleri, PersonManager sınıfının IApplicantService arayüzünü implement ettiği bir yapıda gerçekleştirilmiştir. Bu sayede, doğrulama işlemleri merkezi bir noktada, PersonManager sınıfında yönetilerek, uygulama içinde doğrudan bağlantı kodları yazma ihtiyacı ortadan kaldırılmıştır.

```c#
 public bool CheckPerson(Person person)
{
    KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

    var response = client.TCKimlikNoDogrulaAsync(
        person.NationalIdentity,
        person.FirstName,
        person.LastName,
        person.DateOfBirthYear
    ).Result;

    return response.Body.TCKimlikNoDogrulaResult;
}
```
<p> 🛠️ Proje, mevcut haliyle temel maske dağıtım ihtiyaçlarını karşılayan basit bir şekilde çalışmaktadır. Ancak, sistemin fonksiyonelliğini artırmak ve kullanıcı deneyimini geliştirmek amacıyla üzerinde sürekli olarak iyileştirme ve ek geliştirmeler yapılacaktır. Bu kapsamda, kullanıcı geri bildirimlerine ve değişen ihtiyaçlara göre proje ilerleyen dönemlerde güncellenmeye devam edecektir.</p>

Görüşürüz 🎉
