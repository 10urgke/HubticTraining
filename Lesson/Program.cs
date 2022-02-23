// See https://aka.ms/new-console-template for more information

using Lesson;
using SuggestEyeColor;
using Human = Lesson.Human;

/*



var child = new ChildHuman("Child", "ChildSurname", 43);

child.Think();
child.Cry();


var human = new Human("asd", "1eqe", 123);


var monkey = new Monkey("monkey", "monkey");


*/
// /*
//
// var mother = new Woman("Kadın", "Blue");
// var father = new Man("Erkek", "Brown");
//
// var child = mother.CreateChild(father, "Child");
//
//
// child.Growth();
//
// var child2 = new Child(father, mother);
//
// var eyeColor = child2.GetEyeColorWith();
//
// Console.WriteLine($"Child2 Eye Color: {eyeColor}");
//
// Console.WriteLine($"Child Eye Color: {child.GetEyeColor()}");
//
// Console.WriteLine($"Child Age: {child.GetAge()}");
// Console.WriteLine($"Child Age: {child.GetAge()}");
// Console.WriteLine($"Childness: {child.Childness}");
//
//
// */
//
// var man = new Man("Name", "Blue");
// var woman = new Woman("Woman", "Brown");
// var parent = new Parent("qqwe", "qwe", false);
//
// //okul
// Parent manParent = man;
// SuggestEyeColor.Human manHuman = man;
//
//
// IHuman human = new SuggestEyeColor.Human("q123","123");
// IHuman manHuman2 = man;


IHuman onur = new Onur();
IHuman fatih = new Fatih();

//onur.Breath();
//onur.Think();
//fatih.Breath();
//fatih.Think();


Deneme deneme = new Deneme();

deneme.Deniyorum(onur);
deneme.Deniyorum(fatih);



class Deneme
{

    public void Deniyorum(IHuman human)
    {
        human.Think();
        human.Breath();
        Console.WriteLine("--------------------------");

    }
}

/*
human.Think();

var life = new Life();

life.Work(man);
life.School(man);
life.Humanity(man);


class Life
{
    public void Work(Man man)
    {
        Console.WriteLine($"My power is {man.Power}");
    }

    public void School(Parent parent)
    {
        Console.WriteLine($"My age is {parent.GetAge()}");
        Console.WriteLine($"My hair color is {parent.GetHairColor()}");
    }

    public void Humanity(SuggestEyeColor.Human human)
    {
        Console.WriteLine($"My eye color is {human.GetEyeColor()}");
        Console.WriteLine($"My hair color is {human.GetHairColor()}");
    }
}

*/



