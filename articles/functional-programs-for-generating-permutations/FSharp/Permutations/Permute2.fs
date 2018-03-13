module rec Permutations.Permute2

    let removeFirst (list: List<'t>) (item: 't): List<'t> =
        // match against the head and the tail
        match list with
        // base case: when the list is empty, return it
        | [] -> []
        // base case: when the head equals the element to remove, return the tail
        | head::tail when head = item -> tail
        // recursive step: prepend the head to the result of the recursive call
        | head::tail -> head :: (removeFirst tail item)

    // appends a to each element of ps in turn,
    // using the accumulator qs to avoid an explicit concatenation operation
    let rec mapcons (a: 't) (ps: List<List<'t>>) (qs: List<List<'t>>): List<List<'t>> =
        match ps with
        | [] -> qs
        | head::tail -> (a :: head) :: mapcons a tail qs

    // iterates thru the elements a of x;
    // appends each element of y in turn 
    // to the permutations of the remaining elements in x
    let rec mapperm (x: List<'t>) (y: List<'t>): List<List<'t>> = 
        match y with 
        // base case: y has no elements
        // this happens on the recursive call to mapperm with the tail of y
        | [] -> []
        | head::tail -> 
            // remove the first item from x
            // recursively call permute with the result
            // until we have iterated thru all the x elements
            let permuteNext = permute (removeFirst x head)
            // recursively call mapperm with x and the tail of y
            // until we have iterated thru all the y elements
            let mappermNext = mapperm x tail
            // append the next element of y (head), 
            // to the permutation of the remaining elements of x,
            // passing an accumulator
            mapcons head permuteNext mappermNext

    // TODO Define unit test.
    // TODO implement function.
    let rec permute (x: List<'t>) : List<List<'t>> = 
        match x with 
        // base case: we've iterated thru all the items in x via mapPerm
        | [] -> [ [] ]
        | _ -> mapperm x x