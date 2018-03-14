module Permutations.ListManipulation

let rec removeFirst x xs =
    match xs with
    | [] -> []
    | head::tail when head = x -> tail
    | head::tail -> head :: (removeFirst x tail)

let rec move xs i j : 't list = 
    []

// TODO put xs as the last parameter to help with currying.
let rec put a xs j =
    match j with 
    | 0 -> a::xs
    | _ -> []
