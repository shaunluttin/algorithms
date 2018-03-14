module rec Permutations.Permute3

open ListManipulation

let mapperm x y p ps =
    match y with
    | [] -> ps
    | head::tail ->
        let genpermNext = genperm (removeFirst x head) (head::p) ps
        mapperm x tail p genpermNext

let genperm x p ps =
    match x.Tail with
    | [] -> (x.Head :: p) :: ps
    | _ -> mapperm x x p ps

let permute x =
    match x with
    | [] -> [ [] ]
    | _ -> genperm x [] []
