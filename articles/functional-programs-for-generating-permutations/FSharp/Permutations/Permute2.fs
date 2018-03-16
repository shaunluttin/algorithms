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

let mapperm xs ys =
    match ys with 
    | [] -> []
    | head::tail -> 
        let permuteNext = permute (removeFirst head xs)
        let mappermNext = mapperm xs tail
        mapcons head permuteNext mappermNext

let permute xs =
    match xs with 
    | [] -> [ [] ]
    | _ -> mapperm xs xs

let kpermute k xs =
    failwith "Not implemented"