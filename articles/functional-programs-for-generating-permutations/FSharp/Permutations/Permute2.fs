module rec Permutations.Permute2

open ListManipulation

let mapcons a ps qs =
    let prepended = List.map (fun p -> a :: p) ps
    prepended @ qs

// The recursive version is here for posterity.
let mapconsRecursive a ps qs =
    match ps with
    | [] -> qs
    | head::tail -> (a :: head) :: mapcons a tail qs

let mapperm x y =
    match y with 
    | [] -> []
    | head::tail -> 
        let permuteNext = permute (removeFirst x head)
        let mappermNext = mapperm x tail
        mapcons head permuteNext mappermNext

let permute x =
    match x with 
    | [] -> [ [] ]
    | _ -> mapperm x x