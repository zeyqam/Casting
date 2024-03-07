
//boxing-unboxing
//boxing value type objecte cevirmek 
//unboxing objecti value type cevirmek
//int a = 5;
////object b = a;
//int a = 6;

//object b = a;

//int c = (int)b;
// umumi olaraq casting adlanir

//implicit ve expilisit
using Casting;

//byte num = 50;

//int num2 = num;
//expilisit
//int a = 10;

//byte b =(byte) a;

//Console.WriteLine(b);
// bir deyer type onun intervalina daxildirse onu ona cevirmek impilisit

//upcasting ve downcasting
// bir objecti  ozunden yuxari miras aldigina cast elemekdir,tipini cevirmekdir
//Fish fish = new Fish();

//Animal animal1 = fish;

//downcasting
//Animal animal2 = new Animal();

//Fish fish1 = (Fish)animal2;

//Animal animal3 = new Dog();

//Animal animal4 = new Fish();

//Animal animal = new();
//Fish fish1 = (Fish)animal;

//Dog dog = new Dog();
////object[] datas = { 1, 2, true, "salam" };
//object[] animals = { animal1, animal3, animal4,dog,"name" };
//foreach(var item  in animals)
//{

//    if(item is Animal a)
//    {
//        a.Name = "Toplan";

//        Console.WriteLine(a.Name);
//    }


//}

//DataList dataList = new DataList();

//dataList[0] = "salam";
//dataList[1] = "sagol";
//Console.WriteLine(dataList[0]);

Employee employee = new Employee();
employee.Id = 1;
employee.Age = 25;


Employee employee2 = new Employee();
employee2.Id=2;
employee2.Age = 30;
Console.WriteLine(employee > employee2);


