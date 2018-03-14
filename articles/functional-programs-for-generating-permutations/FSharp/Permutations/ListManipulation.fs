module Permutations.ListManipulation

let rec removeFirst x xs =
    match xs with
    | [] -> []
    | head::tail when head = x -> tail
    | head::tail -> head :: (removeFirst x tail)

let rec move xs i j : 't list = 
    []

let rec put a j xs =
    match j with 
    | 0 -> a::xs
    | _ -> xs.Head :: (put a (j-1) xs.Tail)
