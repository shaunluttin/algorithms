module Permutations.ListManipulation

let rec removeFirst list item =
    match list with
    | [] -> []
    | head::tail when head = item -> tail
    | head::tail -> head :: (removeFirst tail item)