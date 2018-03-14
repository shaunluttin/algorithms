module Permutations.ListManipulation

let rec removeFirst item list =
    match list with
    | [] -> []
    | head::tail when head = item -> tail
    | head::tail -> head :: (removeFirst item tail)