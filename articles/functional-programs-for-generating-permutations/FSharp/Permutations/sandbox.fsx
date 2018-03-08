// Alt Enter on a line to run that line. 
// Highlight block and do the same thing. 
// Command Pallete > FSI to see re

// Load a file by name and then use its namespace > module > 
#load "Permute1.fs";
#load "Permute2.fs";

// Use .dll if it isn't in the GAC (E.g. NuGet package)
// #r "SomeAssemblyName.dll"; 

let add a b = a + b;

let answer = add 5 10

answer + 4

Permutations.Permute1.permute []

printfn "[0].Head %A" [0].Head
printfn "[0].Tail %A" [0].Tail

printfn "[0;1;2].Head %A" [0;1;2].Head
printfn "[0;1;2].Tail %A" [0;1;2].Tail

Permutations.Permute1.permute [1;2;3] |> List.iter (printf "%A ")

let list = [1;2;3;4;5]
let result = Permutations.Permute2.removeFirst list 3
printfn "%A" result

printfn "%A" (0 :: list)