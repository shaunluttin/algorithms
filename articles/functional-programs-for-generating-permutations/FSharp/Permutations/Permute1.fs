module Permutations.Permute1

    let rec put (a: 't) (p: List<'t>) (q: List<'t>) : List<'t> =
        if p = q then a :: q
        else p.Head :: (put a p.Tail q)

    // a: an element
    // p: a list of elements
    // q: a sublist of p
    // ps: a list of permutations
    let rec insert (a: 't) (p: List<'t>) (q: List<'t>) (ps: List<List<'t>>) : List<List<'t>> =
        if q.IsEmpty then (put a p q) :: ps
        else (put a p q) :: (insert a p q.Tail ps) 

    let rec mapinsert (a: 't) (ps: List<List<'t>>) : List<List<'t>> =
        if ps.IsEmpty then List.empty<List<'t>>
        else insert a ps.Head ps.Head (mapinsert a ps.Tail)

    // x: a list of elements
    // returns a list of permutations
    let rec permute (x: List<'t>) : List<List<'t>> = 
        if x.IsEmpty then [x]
        else mapinsert x.Head (permute x.Tail)