#load "Permute2.fs";

open Permutations;

let list = [1;2;3;4;5]

// remove an item from a list
Permute2.removeFirst list 3;

// append an item to a list
(0 :: list)