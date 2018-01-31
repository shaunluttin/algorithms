namespace FSharp.ConsoleApp

module Permutations =

    /// <summary></summary
    /// <param name="x"></param>
    /// <returns>returns a list of all permutations of the elements in the list x</returns>
    let permute1 x = raise (System.NotImplementedException())

    /// <summary>appends the results of inserting a at each position of each permutation in ps</summary
    /// <param name="a"></param>
    /// <param name="ps"></param>
    /// <returns></returns>
    let mapinsert a ps = raise (System.NotImplementedException())

    /// <summary>constructively puts a in to p immediately before q</summary
    /// <returns></returns>
    let rec put (a: 't) (p: List<'t>) (q: List<'t>) : List<'t> = 
        if p = q then a :: q
        else p.Head :: put a p.Tail q

    /// <summary>puts a in to p immediately before q and each subsequent position of p</summary
    /// <param name="a">an item</param>
    /// <param name="p">a list of items</param>
    /// <param name="q">a sublist of p</param>
    /// <param name="ps">an accumulator which avoids an explicit concatenation operation in mapinsert</param>
    /// <returns></returns>
    let rec insert (a: 't) (p: List<'t>) (q: List<'t>) (ps: List<'t>) : List<'t> = 
        if q.Length = 0 then (put a p q) @ ps
        else (put a p q) @ (insert a p q.Tail ps)
