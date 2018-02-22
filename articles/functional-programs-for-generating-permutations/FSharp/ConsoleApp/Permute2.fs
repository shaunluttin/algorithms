namespace FSharp.ConsoleApp

module Permute2 =

    let removeFirst (x: List<'t>) (y: 't)
        raise (System.NotImplementedException(""))

    let rec mapcons (a: 't) (ps: List<List<'t>>) (qs: List<List<'t>>): List<List<'t>> =
        raise (System.NotImplementedException(""))

    let rec mapperm (x: List<'t>) (y: List<'t>): List<List<'t>> = 
        raise (System.NotImplementedException(""))
        let mp = mapperm x y.Tail
        let rm = removeFirst x y.Head

        // How do we call permute2 from mapperm 
        // and call mapperm from permute2?
        let pm = permute2 rm
        mapcons y.Head pm mp

    // x: a list of elements
    // returns a list of permutations
    let rec permute2 (x: List<'t>) : List<List<'t>> = 
        raise (System.NotImplementedException(""))
        mapperm x x