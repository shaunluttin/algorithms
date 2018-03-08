// Press Alt Enter on a line to run that line. 
// Highlight a block and do the same thing to run multiple lines. 
// Go to the Command Pallete and type FSI to see other commands.

// Use #load "SomeFile.fs" to Load a file by name.
#load "Permute1.fs";
#load "Permute2.fs";

// Use #r "SomeAssemblyName.dll" to load an assembly.
// Use the .dll suffix for NuGet packages. 
// If the assembly is in the Global Assembly Cache (GAC), omit the .dll suffix.

// Small interactive demo:
let add a b = a + b;
let answer = add 5 10
answer + 4
