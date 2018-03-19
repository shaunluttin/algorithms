module Permutations.Permute5

// Return the tail of the first list that starts in lexographic order.
// Recursively process the the tail of the current list until we find one.
let rec firstUp ps  = 
    match ps with 
    | _::tail when tail.IsEmpty -> []
    | head::tail when head < tail.Head -> tail
    | _::tail -> firstUp tail
    | _ -> failwith "Invalid argument"

// Return the first list that has a head value that is less than `a`.
// Recursively remove the head of the current list until we find one.
let rec firstLess ps a = 
    match ps with 
    | head::_ when head < a -> ps 
    | _::tail -> firstLess tail a 
    | _ -> failwith "Invalid argument"
