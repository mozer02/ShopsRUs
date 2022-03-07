# ShopsRUs

Projenin UML Diagramı

![UmlDiagram](https://user-images.githubusercontent.com/93456131/156902331-4eb125c7-57a6-480c-bd8d-eabf73df48b2.JPG)

.Net Core ile yaptığımız indirim oranları hesaplayan ShopsRUs Perakende Mağaza projemizde modeller ve servislerin yaptığı işlemler açıklama satırları ile belirtilmiştir.
Projemizde veritabanı olmadığından FakeData oluşturulup içerisine kullanıcılar ve ürünler eklendi.
Projeyi çalıştırdığımızda aşağıda görüldüğü gibi Api üzerinden faturamızın oluşturulması için gerekli istekler istenmektedir (identityNumber,barcode,quantity). 
Bu istekleri aşağıdaki gibi FakeData daki veriler ile uygun şekilde doldurmamız gerekmektedir.

![ApiInvoice](https://user-images.githubusercontent.com/93456131/156902686-5f829717-1e87-46a9-8c1b-86bee11471f4.JPG)

Yapılan isteklere karşılık servisimizde gerekli indirimleri yaparak indirim dahil nihai fatura tutarının sonucunu kullanıcıya aşağıdaki şekilde vermektedir.

![toplam](https://user-images.githubusercontent.com/93456131/156902818-c71c48a1-7aa7-424d-a6b3-e3d32faa9b06.JPG)

# Mvc teknolojisi ile yaptığımız Unit Test çalışmasının görüntüleri aşağıda yer almaktadır.

![unitTest](https://user-images.githubusercontent.com/93456131/157029161-519e8b95-3715-485c-a542-a3ea641f2da4.jpg)

