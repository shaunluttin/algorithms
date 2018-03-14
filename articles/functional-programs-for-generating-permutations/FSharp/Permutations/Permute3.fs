module rec Permutations.Permute3

let mapperm (x: 't list) (y: 't list) (p: 't list) (ps: 't list list) = 
    match y with 
    | [] -> ps
    | head::tail -> 
        let genpermNext = genperm (Permute2.removeFirst x head) (head::p) ps
        mapperm x tail p genpermNext

let genperm (x: 't list) (p: 't list) (ps: 't list list) = 
    match x.Tail with 
    | [] -> (x.Head :: p) :: ps
    | _ -> mapperm x x p ps

let permute (x: 't list): 't list list =
    match x with 
    | [] -> [ [] ]
    | _ -> genperm x [] [[]]
