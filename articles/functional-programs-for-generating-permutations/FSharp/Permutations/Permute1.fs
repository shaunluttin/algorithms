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

let rec permute (x: 't list) =
    if x.IsEmpty then [x]
    else mapinsert x.Head (permute x.Tail)