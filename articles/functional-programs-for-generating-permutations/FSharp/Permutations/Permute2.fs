module rec Permutations.Permute2

    let removeFirst (list: List<'t>) (item: 't): List<'t> =
        match list with
        | [] -> []
        | head::tail when head = item -> tail
        | head::tail -> head :: (removeFirst tail item)

    let rec mapcons (a: 't) (ps: List<List<'t>>) (qs: List<List<'t>>): List<List<'t>> =
        match ps with
        | [] -> qs
        | head::tail -> (a :: head) :: mapcons a tail qs

    let rec mapperm (x: List<'t>) (y: List<'t>): List<List<'t>> = 
        match y with 
        | [] -> []
        | head::tail -> 
            let permuteNext = permute (removeFirst x head)
            let mappermNext = mapperm x tail
            mapcons head permuteNext mappermNext

    let rec permute (x: List<'t>) : List<List<'t>> = 
        match x with 
        | [] -> [ [] ]
        | _ -> mapperm x x