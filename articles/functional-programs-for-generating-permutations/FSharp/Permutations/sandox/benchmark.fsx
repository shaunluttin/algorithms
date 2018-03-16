#load "ListManipulation.fs";
#load "Permute1.fs";
#load "Permute2.fs";
#load "Permute3.fs";
#load "Permute4.fs";

let input = [0..7];
let sw = new System.Diagnostics.Stopwatch();

sw.Restart();
let permute1 = Permutations.Permute1.permute input
let t1 = sw.ElapsedTicks; 

sw.Restart();
let permute2 = Permutations.Permute2.permute input
let t2 = sw.ElapsedTicks; 

sw.Restart();
let permute3 = Permutations.Permute3.permute input
let t3 = sw.ElapsedTicks; 

sw.Restart();
let permute4 = Permutations.Permute4.permute input
let t4 = sw.ElapsedTicks; 

// t1 143231L
// t2 399989L
// t3 142340L
// t4 27414L
