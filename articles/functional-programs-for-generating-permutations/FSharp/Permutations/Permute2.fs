module rec Permutations.Permute2

open ListManipulation

let mapcons a ps qs =
    let prepended = List.map (fun p -> a :: p) ps
    prepended @ qs

// The recursive version is here for posterity.
let mapconsRecursive a ps qs =
    match ps with
    | [] -> qs
    | head::tail -> (a :: head) :: mapcons a tail qs

let mapperm xs ys =
    match ys with 
    | [] -> []
    | head::tail -> 
        let permuteNext = permute (removeFirst head xs)
        let mappermNext = mapperm xs tail
        mapcons head permuteNext mappermNext

let permute xs =
    match xs with 
    | [] -> [ [] ]
    | _ -> mapperm xs xs

let rec kpermute k (xs: 't list) = 

    let rec mapPerm k xs ys =
        match ys with 
        | [] -> []
        | head::tail -> 
            let kpermuteNext = kpermute (k-1) (removeFirst head xs)
            let mapPermNext = mapPerm k xs tail
            mapcons head kpermuteNext mapPermNext

    match k with 
    | 0 -> [ List.empty<'t> ]
    | _ when xs.Length < k -> List.empty<'t list>
    | _ -> mapPerm k xs xs 