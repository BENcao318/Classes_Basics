// See https://aka.ms/new-console-template for more information
using Classes_Basics;

Human denis = new Human("Denis", "Panjuta", 36);
denis.IntroduceMyself();

Human michael = new Human("Mike", "Cao", 1);
michael.IntroduceMyself();

Human basicHuman = new Human();
basicHuman.IntroduceMyself();

Human Natalie = new Human("Natalie");
Natalie.IntroduceMyself();

Box box = new Box();
//box.length = 3;
box.SetLength(3);

box.height = 4;
box.width = 5;
Console.WriteLine("Box's volume is {0}", box.GetVolume());

box.DisplayInfo();
