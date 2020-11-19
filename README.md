# React Dokümantasyon

 1. DOM
 2.    Virtual DOM
 3. One-Way Binding (Tek yönlü bağlama) ve Two-Way Binding (Çift yönlü bağlama)
 4. EcmaScript 6 Bilinmesi Gerekenler
	 - Spread Operatör
	 - Array.map() Operatör
	 - Array.Filter Operatör
	- Object.assign
 5. Babel Nedir?
 6. Webpack Nedir?
 7. Create React App
 8. Propslar
	- PropTypes
 9. [Eventler](#Events)

	 

## DOM (Document Object Model)
 DOM web sayfalarının bize görünmesini sağlayan HTML elemanlarının hiyerarşik bir biçimde bir arada bulunması anlamına gelen W3C standardıdır [1].
 
 DOM dokümandaki nesnelere erişmek ve içeriğini, stilini, yapısını değiştirmek için kullanılır [1].
 
 DOM, HTML ile programlama dilleri arasında bir **standart** oluşturarak bu dillerin HTML den bilgi alıp, bilgi vermesine yardımcı olur. **DOM**, Nesneler ve özelliklerden oluşur [2].

> DOM**’da **HTML** ile hazırladığınız sayfa, **_belge_**; bu belgenin içine yerleştirdiğiniz her türlü öğe ise **_nesne_** olarak adlandırılır [2].
 
**DOM** da nesnelerin birer öğe (_element_) olarak kullanılabilmesi için hiyerarşik bir düzen izlenerek çağrılmaları gerekir.  HTML’deki her bir elamanın birbiri ile hiyearşik bir yapı oluşturması ile oluşur [2].

## 1. ve 2. resimleri buraya ekle 
https://webmaster.kitchen/dom-document-object-model-nedir/


**DOM** bir ağaç dizini gibi bütün dokümanları birbirine bağlar. Birden fazla programlama dilleri destekler(_JS, PHP, Java, ASP vb._) ve aynı zamanda dosya oluşturmak, elementleri ve içeriklerini silme/ekleme gibi fonsiyonları vardır [2].

**Virtual Dom**
Virtual Dom ise Dom yapısının key=>value şeklinde memory'de bulunmuş haline denir. Yani Dom'un kopyasını almak gibi düşünebiliriz.

Örneğin: HTML web saayfası üzerinde herhangi bir değişiklik gerçekleşirse değişikliğin ekrana yansıması için bütün DOM taranır. Yani bütün Dom render edilir.

Virtual Dom'da ise herhangi bir güncelleme ve değişiklik olduğunda ilk önce virtual dom üzerinde yani bellekte yapılır. Daha sonra VDom'dan gerçek dom'a aktarılırken VDOM ve DOM arasındaki farklılıklar kontrol edilir ve sadece farklılığın olduğu yerler kontrol edilir.

## **One-Way Binding (Tek yönlü bağlama) ve Two-Way Binding (Çift yönlü bağlama)**

**one-way binding** 
değişkenlerin ve değerlerin view tarafına aktarımıdır. React'ta JSX tarafında kullandığımız **{variable}**  syntax ‘ı buna en güzel örnektir[3].

    import React from  'react';
    class  App extends  React.Component  {
	    state  = {
	    data:  'Hello word'
	    };
    render(){
	   return  (
	   <div>
		   <p>The data is  =>  {this.state.data}</p>
	  </div>
	  );}}
	  export default  App;

**two-way binding**
3.resimi buraya ekle.
View tarafına aktarılan data arka taraftanda dinlenmektedir. data<=>view olayına denir [3].
4.resmi buraya ekle

# EcmaScript 6 Bilinmesi Gerekenler
Ecmascript javascript dilinin standartlaştırılmış sürümünün adıdır.
## Spread Operatör
yaymak anlamına gelir. kopyalayarak kullanır.

    foo(...operate); şeklinde kullanılır.
    
 
**Fonksiyonlara parametre olarak array geçmek gereken durumlarda kullanılabilir.**
 Birden fazla parametre alan bir fonksiyona parametre olarak elimizde bulunan bir arrayi geçmek istediğimizde aşağıdaki şekilde apply kullanmak gerekiyordu [4].
 
    function myFunction(x, y, z) { }  
    var array1 = [0, 1, 2];  
    myFunction.apply(null, array1);
spread operatörü ile bu kullanıma gerek kalmadı.

    myFunction(...array1);

 **Başka arraylari de dahil ederek yeni array oluşturulan durumlarda kullanılabilir.**
  
    var data = [3,4];  
    var newData = [1,2, ...data, 5,6]; //1,2,3,4,5,6 şeklinde olur.

 **Bir arrayden kopya array oluşturmak**
Bir array'i kopyalamak için slice metodu kullanılıyordu. yenisinde kullanım şu şekilde
    
    var arr = [1, 2, 3];  
    var arr2 = [...arr]; // like arr.slice()  
    arr2.push(4);
 

**Math fonksiyonunda kullanmak**

    let numbers = [9, 4, 7, 1];  
    Math.min(...numbers); // 1

 **NodeList’ten dönen değeri diziye çevirmek**

    [...document.querySelectorAll('div')]

## Map Operatör [5]
Array üzerinde gezinme ve işlem yapabilmek için kullanılır. 

> Map array'in kopyasını alarak üzerinde işlem yapar. Foreach direk array üzerinde çalışır.

    const array1 = [1, 4, 9, 16];
    
    // pass a function to map
    const map1 = array1.map(x => x * 2);
    
    console.log(map1);
    // expected output: Array [2, 8, 18, 32]


## Filter Operatör [6]
data içerisinde filtreleme yapmak için kullanılır.

    const words = ['spray', 'limit', 'elite', 'exuberant', 'destruction', 'present'];
    const result = words.filter(word => word.length > 6);
    console.log(result);
    // expected output: Array ["exuberant", "destruction", "present"]

## Object assign []
Objectleri birbiri üzerine kopyalanmasını sağlayan fonksiyondur.

Object.assign(hedef_nesne, ..._kaynak_nesneler_)
Object.assign(kopyalandığı yer, kopyalanan data)

    var obj1 = { a: 1 };
    var obj2={b:2}
    Object.assign(obj1,obj2);
    console.log(obj1); // {a: 1, b: 2}
.

    const personel = {name: "Uğur", surname: "Mamak"};  
    const personel2 = personel;  
    personel2.name = "Uğur2";  
    console.log(personel);  { name: ‘Uğur2’, surname: ‘Mamak’ }
    console.log(personel2);{ name: ‘Uğur2’, surname: ‘Mamak’ }

> nesneleri birbirine eşitleyerek atama işlemi yapabiliriz. Fakat bu şekilde kullanım olursa yukarıdaki gibi personel2'nin değerini değiştirdiğimizde personel değişkeninin de değeri değişir. Çünkü **Javascript’te array ve object tipleri referanstır.** Yani değişkenler, bilgilerin bellekteki adreslerini tutarlar.

# Babel Nedir?
ES6 standdartını ES5 standartına çevirmeyi sağlar. ES6 bütün tarayıcılarda uyumlu olmadığı için bütün tarayıcılarda uyumlu olan ES5'e dönüştürerek kodların çalışabilir olmasını sağlayan açık kaynak kodlu javascript  transcompilerdır.
 
    npm i babel-cli babel-preset-es2015 --save 
    
    start:"babel-node index.js --preset es2015" (package.json'da scripts içine yazılır.)

# Webpack Nedir?
Modül paketleyicisidir. Proje altındaki tüm js, stil, resim vb dosyaları alarak tek bir dosya altında birleştirir.
Daha hızlı yeniden oluşturma için yanlızca src içindeki dosyalar webpack tarafından işlenir. Herhangi bir js ve css dosyasını src içine koymanız gerekir, aksi taktirde webpack bunları görmez.



# Create React App
React kullanıcı arayüzü oluşturmak için kullanılan js kütüphanesidir. Framework değildir. View katmanına odaklanır.

    npm install -g create-react-app (react pc'ye kurulumu sağlar)
    npx create-react-app project-name (proje isimlendirme küçük harf olmak zorunda)
    npm start (uygulamayı başlatır.)

# Propslar
props: Bir componentten farklı bir componente aktarılan data'ya props denir. Props read only'dir yani üzerinde değişiklik yapılamaz sadece okunabilirdir.

state:bir componentin kendisine ait olan data'larına state denir.

> NOT: propslar tekrar render edilemezler. Bir kere renderlanırlar. Eğer
> güncellemek istiyorsak state kullanmalıyız.

### PropTypes
Componente gelen propsların içeriklerini, özelliklerini belirlememize yarar.

> import PropTypes from "prop-types" //kullanılan js dosyasında import edilir.

     //gönderilen propların tipini belirlemek için kullanabiliriz.
     //render'dan önce yazılır. 
     static propTypes={ 	
    	    news:PropTypes.array,  
    		name:PropTypes.string}

   Component dışında aşağıdaki şekilde kullanılır. 

    News.propTypes={ //News component ismi
      name:PropTypes.string
     }

    name:PropTypes.string.isRequired //string olsun ve boş olmasın anlamına gelir.
    
    //oneOfType Birden fazla tipi desteklemeyi sağlar.
    name:PropTypes.oneOfType([
    PropTypes.number,
    PropsTypes.string
    ]).isRequired
    
    //shape gelen props object ise gelen objeyi şekillendirmek için kullanılır.
    newData:PropTypes.shape({
    	title:PropTypes.string,
    	desc:PropTypes.string
    })
    
    //static default props eğer belirlenen componentler gelmez ise varsayılan değer vermek için kullanabiliriz.
    static default Props={
    	name:"Uğur" //eğer name props'u boş gelirse props'a "Uğur" değeri atanmış olur.
    }

# Events

# Kısaltmalar
npm : node package manager
js: javascript
dom: document object model
vdom: virtual dom

## Kaynakça
>[1] [StackEdit](https://biltektasarim.com/blog/html-dom-nedir).
>[2] https://webmaster.kitchen/dom-document-object-model-nedir/#comment-16207
>[3]https://www.mobilhanem.com/reactjs-two-way-binding/#:~:text=One%2Dway%20binding%20kulland%C4%B1%C4%9F%C4%B1m%C4%B1z%20model,%C4%B1%20buna%20en%20g%C3%BCzel%20%C3%B6rnektir.
>[4] https://medium.com/@muratdogan/sen-javascriptin-bir-l%C3%BCtfusun-spread-operat%C3%B6r-extended-version-fa5de70beaeb
>[5]https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/map
[6]https://developer.mozilla.org/tr/docs/Web/JavaScript/Reference/Global_Objects/Array/filter

