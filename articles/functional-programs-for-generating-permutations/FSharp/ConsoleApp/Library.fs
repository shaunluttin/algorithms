namespace FSharp.ConsoleApp

module Permutations =

    let rec put (a: 't) (p: List<'t>) (q: List<'t>) : List<'t> =
        if p = q then a :: q
        else p.Head :: (put a p.Tail q)

    let rec insert a p q ps : List<List<'t>> = 
        (put a p q) :: (insert a p q.Tail ps) 

    let rec mapinsert (a: 't) (ps: List<List<'t>>) : List<List<'t>> =
        insert a ps.Head ps.Head (mapinsert a ps.Tail)

    // x: a list of elements
    // returns a list of permutations (which are lists of elements)
    let rec permute1 (x: List<'t>) : List<List<'t>> = 
        if x.Length = 0 then [x]
        else mapinsert x.Head (permute1 x)
