module Permutations.Permute1

let rec put a p q =
    if p = q then a :: q
    else p.Head :: (put a p.Tail q)

let rec insert a p (q: 't list) ps =
    if q.IsEmpty then (put a p q) :: ps
    else (put a p q) :: (insert a p q.Tail ps) 

let rec mapinsert a (ps: 't list list) =
    if ps.IsEmpty then []
    else insert a ps.Head ps.Head (mapinsert a ps.Tail)

let rec permute (xs: 't list) =
    if xs.IsEmpty then [xs]
    else mapinsert xs.Head (permute xs.Tail)

// TODO: Use the canonical name for selecting all permutations 
// of lengh k from a set of n elements?
let rec permuteOfLength k (xs: 't list) =

    let rec mapInsert a ps qs = 
        match ps with 
        | [] -> qs
        | head::tail -> 
            let mapInsertNext = mapInsert a tail qs
            insert a head head mapInsertNext

    match k with 
    | 0 -> [ List.empty<'t> ]
    | _ when xs.Length < k -> []
    | _ -> 
        let permuteK = permuteOfLength k
        let permuteKminus1 = permuteOfLength (k-1)
        mapInsert xs.Head (permuteKminus1 xs.Tail) (permuteK xs.Tail) 