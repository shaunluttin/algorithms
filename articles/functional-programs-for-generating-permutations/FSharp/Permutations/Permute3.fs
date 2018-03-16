module rec Permutations.Permute3

open ListManipulation

let mapperm x y p ps =
    match y with
    | [] -> ps
    | head::tail ->
        let genpermNext = genperm (removeFirst head x) (head::p) ps
        mapperm x tail p genpermNext

let genperm x p ps =
    match x.Tail with
    | [] -> (x.Head :: p) :: ps
    | _ -> mapperm x x p ps

let permute x =
    match x with
    | [] -> [[]]
    | _ -> genperm x [] []

(*
    "permute3 can be revised in an analogous way [as permute2], but it is awkward
    to modify permute4 to solve this [permutations of length K <= N] problem as 
    it has no explicit pointer to the partial permutation p." (Topor 1982)
*)
let rec kpermute k (xs: 't list) = 
    // TODO Implement permute3 for K <= N once we've implemented the article's other examples.
    failwith "Not implemented"
