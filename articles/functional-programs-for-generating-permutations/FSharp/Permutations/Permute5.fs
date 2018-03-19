module rec Permutations.Permute5

open ListManipulation

// Strip the head until we find a list that starts in lexographic order.
// Then return its tail.
let firstUp ps  = 
    match ps with 
    | [] -> failwith "Invalid argument"
    | _::tail when tail.IsEmpty -> []
    | head::tail when head < tail.Head -> tail
    | _::tail -> firstUp tail