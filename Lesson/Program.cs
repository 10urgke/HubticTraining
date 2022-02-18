// See https://aka.ms/new-console-template for more information

using Lesson;
using SuggestEyeColor;

/*



var child = new ChildHuman("Child", "ChildSurname", 43);

child.Think();
child.Cry();


var human = new Human("asd", "1eqe", 123);


var monkey = new Monkey("monkey", "monkey");


*/


var mother = new Woman("Kadın", "Blue");
var father = new Man("Erkek", "Brown");

var child = mother.CreateChild(father, "Child");


child.Growth();

var child2 = new Child(father, mother);

var eyeColor = child2.GetEyeColorWith();

Console.WriteLine($"Child2 Eye Color: {eyeColor}");

Console.WriteLine($"Child Eye Color: {child.GetEyeColor()}");

Console.WriteLine($"Child Age: {child.GetAge()}");
Console.WriteLine($"Child Age: {child.GetAge()}");
Console.WriteLine($"Childness: {child.Childness}");