module TestData

type PermuteLexographic () = 
    let values : obj array seq =                                                            
        seq {                                                                                         
            yield [| ["A";"B"]; [["A";"B"]; ["B";"A"]] |]
            yield [| [0;1;2]; [[0;1;2]; [1;0;2]; [1;2;0]; [0;2;1]; [2;0;1]; [2;1;0]] |]
        }                                                                                             

    interface seq<obj[]> with 
        member this.GetEnumerator () = values.GetEnumerator()
        member this.GetEnumerator () = 
            values.GetEnumerator() :> System.Collections.IEnumerator
