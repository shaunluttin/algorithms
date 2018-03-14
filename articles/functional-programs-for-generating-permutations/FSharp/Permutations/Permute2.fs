module rec Permutations.Permute2

let removeFirst (list: 't list) (item: 't) : 't list =
    match list with
    | [] -> []
    | head::tail when head = item -> tail
    | head::tail -> head :: (removeFirst tail item)

let mapcons (a: 't) (ps: 't list list) (qs: 't list list): 't list list =
    match ps with
    | [] -> qs
    | head::tail -> (a :: head) :: mapcons a tail qs

let mapperm (x: 't list) (y: 't list): 't list list = 
    match y with 
    | [] -> []
    | head::tail -> 
        let permuteNext = permute (removeFirst x head)
        let mappermNext = mapperm x tail
        mapcons head permuteNext mappermNext

let permute (x: 't list) : 't list list = 
    match x with 
    | [] -> [ [] ]
    | _ -> mapperm x x