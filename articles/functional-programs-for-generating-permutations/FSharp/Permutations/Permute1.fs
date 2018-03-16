module Permutations.Permute1

let rec put a ps qs =
    if ps = qs then a :: qs
    else ps.Head :: (put a ps.Tail qs)

let rec insert a p (q: 't list) ps =
    match q with 
    | [] -> (put a p q) :: ps 
    // this pattern allows permutations with repeated elements
    | _ when a = q.Head -> (put a p q) :: ps 
    | _ -> (put a p q) :: (insert a p q.Tail ps) 

let rec mapInsert a (ps: 't list list) =
    if ps.IsEmpty then []
    else insert a ps.Head ps.Head (mapInsert a ps.Tail)

// Returns all permutations of length N out of a set of N elements.
// Returns all permutations of length N out of a multiset of N elements.
let rec permute (xs: 't list) =
    if xs.IsEmpty then [xs]
    else mapInsert xs.Head (permute xs.Tail)

// Returns all permutations of length K out of a set of N elements.
// The canonical name for this is probably k-permutation.
// See https://www.statlect.com/mathematical-tools/k-permutations
let rec kpermute k (xs: 't list) =

    let rec mapInsert a ps qs = 
        match ps with 
        | [] -> qs
        | head::tail -> 
            let mapInsertNext = mapInsert a tail qs
            insert a head head mapInsertNext

    match k with 
    | 0 -> [[]]
    | _ when xs.Length < k -> []
    | _ -> 
        let permuteK = kpermute k
        let permuteKminus1 = kpermute (k-1)
        mapInsert xs.Head (permuteKminus1 xs.Tail) (permuteK xs.Tail) 
