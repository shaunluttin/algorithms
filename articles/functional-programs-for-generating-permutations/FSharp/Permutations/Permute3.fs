module rec Permutations.Permute3

let permute x =
    match x with 
    | [] -> [ [] ]
    | _ -> genperm x [] []
