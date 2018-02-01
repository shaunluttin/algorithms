namespace FSharp.ConsoleApp

module Permutations =

    /// <param name="x"></param>
    /// <returns>returns a list of all permutations of the elements in the list x</returns>
    let permute1 x = raise (System.NotImplementedException())

    /// constructively puts a in to p immediately before q
    /// <returns></returns>
    let rec put (a: 't) (p: List<'t>) (q: List<'t>) : List<'t> = 
        if p = q then a :: q
        else p.Head :: put a p.Tail q

    /// puts a in to p immediately before q and each subsequent position of p
    /// <param name="a">an item</param>
    /// <param name="p">a list of items</param>
    /// <param name="q">a sublist of p</param>
    /// <param name="ps">an accumulator which avoids an explicit concatenation operation in mapinsert</param>
    /// <returns></returns>
    let rec insert (a: 't) (p: List<'t>) (q: List<'t>) (ps: List<'t>) : List<'t> = 
        if q.Length = 0 then (put a p q) @ ps
        else (put a p q) @ (insert a p q.Tail ps)

    /// appends the results of inserting a at each position of each permutation in ps
    /// <param name="a"></param>
    /// <param name="ps"></param>
    /// <returns></returns>
    let rec mapinsert (a: 't) (ps: List<'t>) : List<'t> = 
        if ps.Length = 0 then List.empty<'t>
        else insert a [ps.Head] [ps.Head] (mapinsert a ps.Tail)
