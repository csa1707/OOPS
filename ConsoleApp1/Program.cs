// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


//Car objcar = new Car();

//Console.WriteLine(objcar.colour);



var objcar1 = new Car("BMW");

//objcar1.colour = "red";

//objcar1.maxSpeed = 100;

Console.WriteLine(objcar1.model);

Console.WriteLine(objcar1.colour);

Console.WriteLine(objcar1.maxSpeed);

objcar1.drivername(" kumar");

objcar1.drivername(" vijay",120);


//about aeroplabne
aeroplane objaero = new aeroplane();
Console.WriteLine(objaero.name);
Console.WriteLine(objaero.modelno);




//about vegetables
var objveg = new vegetable("carrot");
Console.WriteLine(objveg.models1);



//about stduent

student objstu = new student();
Console.WriteLine(objstu.stuname);
Console.WriteLine(objstu.marks);



//about animals
//animals objani = new animals("hyena");
//Console.WriteLine(objani.models2);



//about laptops

laptop objlaptop = new laptop();
Console.WriteLine(objlaptop.brandname);
Console.WriteLine(objlaptop.cost);



//about mobiles

Mobiles objmobiles = new Mobiles();

//Console.WriteLine(objmobiles.name);

//Console.WriteLine(objmobiles.price);





//about books

Author objautor = new Author();
Console.WriteLine(objautor.bookname);
Console.WriteLine(objautor.authorname);


//animals


Dog objdog = new Dog();
objdog.eat();
objdog.bark();



//state

country objcou = new country();
objcou.trichy();
objcou.india();


//Vehicle

honda objhon = new honda();
objhon.brake();
objhon.wire();


//Animal with polymorphism
//
Animal objanimal = new Animal();
objanimal.animalSound();


Animal objdog1 = new Dog();
objdog1.animalSound();

Animal objcat = new Cat();
objcat.animalSound();


//with abstract 

DogAbs objanimalabs = new DogAbs();
objanimalabs.animalSound();

//interface
HP objhp = new HP();
objhp.laptopOS();



//Ipl Poly
Ipl objipl = new Ipl();
objipl.Winners();

Ipl objcsk = new Csk();
objcsk.Winners();

Ipl objrcb = new Rcb();
objrcb.Winners();


//Student Poly
Student objstud = new Student();
objstud.StudentID();

Student objname = new StudentName();
objname.StudentID();

Student objage = new StudentAge();
objage.StudentID();

//IplAbs
CskAbs objcl = new CskAbs();
objcl.Ipls();

RcbAbs objrcbabs = new RcbAbs();
objrcbabs.Ipls();



//interface
Pigs objpls = new Pigs();
objpls.Dogs();







//var Ajith = "kumar"  var is dynamic declared type


//enum 


int a = 50;
int b = 70;

int c = a + b;

Console.WriteLine(c);


