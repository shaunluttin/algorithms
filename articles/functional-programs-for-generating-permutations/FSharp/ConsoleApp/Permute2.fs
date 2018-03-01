namespace FSharp.ConsoleApp

module rec Permute2 =

    let removeFirst (list: List<'t>) (removeMe: 't): List<'t> =
        // match against the head and the tail
        match list with
        // base case: when the head equals the element to remove, return the tail
        | head::tail when head = removeMe -> tail
        // recursive step: prepend the head to the result of the recursive call
        | head::tail -> head :: (removeFirst tail removeMe)
        // base case: when the list is empty, return it
        | [] -> []

    // appends a to each element of ps in turn,
    // using the accumulator qs to avoid an explicit concatenation operation
    let rec mapcons (a: 't) (ps: List<List<'t>>) (qs: List<List<'t>>): List<List<'t>> =
        if ps.IsEmpty then qs
        else (a :: ps.Head) :: mapcons a ps.Tail qs

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