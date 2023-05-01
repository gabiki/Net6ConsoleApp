using ExcerciseConsole;
using Spectre.Console;
using System.Collections.Generic;
using System.Drawing;
using Color = Spectre.Console.Color;

List<SingleUser> usersList = new List<SingleUser>();
Service service = new Service(); 

int exit = 0;

string currentENV = Environment.GetEnvironmentVariable("cheer");
var initialmessage = "";
if (currentENV == "Hello World")
{
    initialmessage = "Hello World";
}
else if (currentENV == "Hello")
{
    initialmessage = "Hello";
}
else
{
    initialmessage = "User favorito";
}

AnsiConsole.Write(new FigletText(initialmessage).Color(Color.Cyan1));

while (exit == 0)
{
    exit = service.choose(usersList);
};

