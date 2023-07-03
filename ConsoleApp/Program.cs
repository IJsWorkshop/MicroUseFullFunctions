// See https://aka.ms/new-console-template for more information


using MicroUseFullFunctions.Output;
using MicroUseFullFunctions.Utility;
using System.Diagnostics;
using ConsoleApp;

var alist = new List<Test>();

alist.Add(new Test { Name = "Ian", Description = "blahb", Height = "10" });
alist.Add(new Test { Name = "Steve", Description = "blasdfdsfdsfsdfb", Height = "5" });
alist.Add(new Test { Name = "John", Description = "bsdfsdflahb", Height = "20" });


alist.ToDebugWindow();

string testString = "said sai 1234567890-abcdefghijk blah blah blah blah";

Debug.WriteLine(testString);

var aList = testString.RemoveString( new string[] { "blah", "1","0", "k", "sai"});

Debug.WriteLine(aList);





