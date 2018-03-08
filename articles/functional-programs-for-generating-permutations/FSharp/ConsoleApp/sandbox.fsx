// Alt Enter on a line to run that line. 
// Highlight block and do the same thing. 
// Command Pallete > FSI to see re

// Load a file by name and then use its namespace > module > 
#load "Permute1.fs";

// Use .dll if it isn't in the GAC (E.g. NuGet package)
// #r "SomeAssemblyName.dll"; 


let add a b = a + b;

let answer = add 5 10

answer + 4

FSharp.ConsoleApp.Permute1.permute1 []