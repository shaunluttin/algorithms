module Permutations.Permute5

// ps: the previous permutation
// qs: the first sublist of ps whose head is less than the head of rs.
// rs: the first sublist of ps whose head is greater than its predecessor's.

// "find the first sublist r of p whose hd, a, is greater than its predecessor.
// "If there is no such sublist, then the elements are in reverse order and we 
// "return NONE since there is no successor." 
// (Topor, 1982)
let rec firstUp ps  = 
    match ps with 
    | [ _ ] -> []
    | head::tail when head < tail.Head -> tail
    | _::tail -> firstUp tail
    | _ -> failwith "Invalid argument"

// "find the first sublist q of p whose head is less than a..."
// (Topor, 1982)
let rec firstLess ps a = 
    match ps with 
    | head::_ when head < a -> ps 
    | _::tail -> firstLess tail a 
    | _ -> failwith "Invalid argument"

// "exchange the hd's of q and r,
// "and reverse the elements of p up to but excluding q"
// (Topor, 1982)
let next3 ps qs rs = 

    let rec genRev (ps: 't list) qs rs ss =
        match ps with 
        | _ when ps = rs -> ss
        | _ when ps = qs -> genRev ps.Tail qs rs (rs.Head::ss)
        | _ -> genRev ps.Tail qs rs (ps.Head::ss)

    genRev ps qs rs (qs.Head::rs.Tail)