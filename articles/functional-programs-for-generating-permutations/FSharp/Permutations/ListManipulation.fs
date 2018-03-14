module Permutations.ListManipulation

let rec removeFirst x xs =
    match xs with
    | [] -> []
    | head::tail when head = x -> tail
    | head::tail -> head :: (removeFirst x tail)

let rec put x j xs =
    match j with 
    | 0 -> x::xs
    | _ -> xs.Head :: (put x (j-1) xs.Tail)

let rec move i j (xs: 't list) : 't list = 
    match i with 
    | 1 -> put xs.Head (j-1) xs.Tail
    | _ -> xs.Head :: move (i-1) (j-1) xs.Tail
