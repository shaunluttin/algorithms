namespace FSharp.ConsoleApp

module rec Permute2 =

    // TODO Define unit test.
    // TODO implement function.
    let removeFirst (x: List<'t>) (y: 't): List<'t> =
        raise (System.NotImplementedException(""))

    // TODO Define unit test.
    // TODO implement function.
    let rec mapcons (a: 't) (ps: List<List<'t>>) (qs: List<List<'t>>): List<List<'t>> =
        raise (System.NotImplementedException(""))

    // TODO Define unit test.
    // TODO implement function.
    let rec mapperm (x: List<'t>) (y: List<'t>): List<List<'t>> = 
        raise (System.NotImplementedException(""))
        let mp = mapperm x y.Tail
        let rm = removeFirst x y.Head
        let pm = permute2 rm
        mapcons y.Head pm mp

    // TODO Define unit test.
    // TODO implement function.
    let rec permute2 (x: List<'t>) : List<List<'t>> = 
        raise (System.NotImplementedException(""))
        mapperm x x