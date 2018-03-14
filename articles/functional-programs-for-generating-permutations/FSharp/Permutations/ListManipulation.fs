module Permutations.ListManipulation

let rec removeFirst x xs =
    match xs with
    | [] -> []
    | head::tail when head = x -> tail
    | head::tail -> head :: (removeFirst x tail)

let rec move x i j : 't list = 
    []

let rec put a x j : 't list = 
    []
