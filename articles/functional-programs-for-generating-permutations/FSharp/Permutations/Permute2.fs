module rec Permutations.Permute2

open ListManipulation

let mapCons a ps qs =
    let prepended = List.map (fun p -> a :: p) ps
    prepended @ qs

// The recursive version is here for posterity.
let mapConsRecursive a ps qs =
    match ps with
    | [] -> qs
    | head::tail -> (a :: head) :: mapConsRecursive a tail qs

let mapPerm xs ys zs =
    match ys with
    | [] -> []
    // this pattern allows permutations with repeated elements
    | head::tail when zs |> List.contains head -> mapPerm xs tail zs
    | head::tail ->
        let permuteNext = permute (removeFirst head xs)
        let mapPermNext = mapPerm xs tail (head::zs)
        mapCons head permuteNext mapPermNext

let permute (xs : 't list) : 't list list =
    match xs with
    | [] -> [[]]
    | _ -> mapPerm xs xs []

let rec kpermute k (xs: 't list) =

    let rec mapPerm k xs ys =
        match ys with
        | [] -> []
        | head::tail ->
            let kpermuteNext = kpermute (k-1) (removeFirst head xs)
            let mapPermNext = mapPerm k xs tail
            mapCons head kpermuteNext mapPermNext

    match k with
    | 0 -> [[]]
    | _ when xs.Length < k -> []
    | _ -> mapPerm k xs xs
