module rec Permutations.Permute4

open ListManipulation

let mapPerm xs i j ps : 't list list = 
    match i with 
    | eq when i = j -> genPerm xs (eq-1) ps
    | _ -> 
        let moved = move i j xs
        let genPermNext = genPerm moved (j-1) ps
        mapPerm xs (i+1) j genPermNext

let genPerm xs j ps : 't list list = 
    match j with 
    | 1 -> xs::ps
    | _ -> mapPerm xs 1 j ps

let permute xs : 't list list = 
    match xs with 
    | [] -> [[]]
    | _ -> genPerm xs xs.Length []
