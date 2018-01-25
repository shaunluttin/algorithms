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

    /// <summary>puts a in to p immediately before q and each subsequent position of p</summary
    /// <param name="a"></param>
    /// <param name="p"></param>
    /// <param name="q">a sublist of p</param>
    /// <param name="ps">an accumulator which avoids an explicit concatenation operation in mapinsert</param>
    /// <returns></returns>
    let insert a p q ps = raise (System.NotImplementedException())

    /// <summary>constructively puts a in to p immediately before q</summary
    /// <returns></returns>
    let put (a: 't) (p: List<'t>) (q : 't) = raise (System.NotImplementedException())
