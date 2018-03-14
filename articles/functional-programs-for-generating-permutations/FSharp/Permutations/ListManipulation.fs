module Permutations.ListManipulation

let rec removeFirst item list =
    match list with
    | [] -> []
    | head::tail when head = item -> tail
    | head::tail -> head :: (removeFirst item tail)

let rec move x i j : 't list = 
    []

let rec put a x j : 't list = 
    []
