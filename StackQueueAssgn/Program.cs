// See https://aka.ms/new-console-template for more information
using StackAssgn;

Console.WriteLine("Stack Program!");
StackPgm Stackobj = new StackPgm();
Stackobj.Push(70);
Stackobj.Push(30);
Stackobj.Push(56);
Stackobj.Display();
Stackobj.Peek(); 
Stackobj.Pop();
Stackobj.IsEmpty();
Stackobj.Display();
Console.ReadKey();
