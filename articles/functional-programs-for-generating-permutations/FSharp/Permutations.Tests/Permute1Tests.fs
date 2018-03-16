module Permute1Tests

open Xunit
open Permutations.Permute1

[<Theory>]
[<MemberData("kpermuteTestValues")>]
let ``kpermute`` (k, x, expected: 't list list) = 
    // Arrange // Act                             
    let actual = kpermute k x
                                                
    // Assert                                     
    Assert.Equal<'t list list>(expected, actual);          

[<Theory>]
[<MemberData("permuteTestValues")>]
let ``permute`` (x, expected: 't list list) = 
    // Arrange // Act                             
    let actual = permute x
                                                
    // Assert                                     
    Assert.Equal<'t list list>(expected, actual);          

[<Theory>]
[<MemberData("mapinsertTestValues")>]
let ``mapinsert`` (a, ps, expected) = 
    // Arrange // Act                             
    let actual = mapInsert a ps      
                                                
    // Assert                                     
    Assert.Equal<'t list>(expected, actual);          

[<Theory>]
[<MemberData("insertTestValues")>]
let ``insert`` (a, p, q, ps, expected) = 
    // Arrange // Act                                      
    let actual = insert a p q ps              
                                                        
    // Assert                                              
    Assert.Equal<'t list>(expected, actual);                   

[<Theory>]
[<MemberData("putTestValues")>]
let ``put`` (a, p, q, expected) = 
    // Arrange // Act                       
    let actual = put a p q     
                                            
    // Assert                               
    Assert.Equal<'t>(expected, actual);    

// Permutations with repeated elements.
// let rpermuteTestValues : obj array seq =                                                            
//     seq {                                                                                         
//     }                                                                                             

// Permutations of length K <= N
let kpermuteTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| 0; ["A";"B"]; [List.empty<string>] |]
        yield [| 1; List.empty<string>; List.empty<string list> |] 
        yield [| 1; ["A";"B"]; [["A"];["B"]] |]
        yield [| 2; ["A";"B"]; [["A";"B"];["B";"A"]] |]
        yield [| 2; ["A";"B";"C"]; [["A";"B"];["B";"A"];["A";"C"];["C";"A"];["B";"C"];["C";"B"]] |]
    }                                                                                             

// Permutations of length N = N
let permuteTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| ["A";"B"]; [["A";"B"]; ["B";"A"]] |]
        // These values are here instead of in the shared TestData.fs file,
        // because the values are specific to the Permute1 algorithm, 
        // which returns permutations in neither lexographic nor reverse-lexographic order.
        yield [| ["A";"B";"C"]; [["A";"B";"C"]; ["B";"A";"C"]; ["B";"C";"A"]; ["A";"C";"B"]; ["C";"A";"B"]; ["C";"B";"A"]] |]
    }                                                                                             

let mapinsertTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| "A"; List.empty<string list>; List.empty<string list> |]
        yield [| "B"; [["A"]]; [["B";"A"]; ["A";"B"]] |]
    }                                                                                             
                                                                                                  
let insertTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| "A"; ["B";"C"]; ["C"]; List.empty<string list>; [["B";"A";"C"]; ["B";"C";"A"]] |]
    }                                                                                             
                                                                                                  
let putTestValues : obj array seq =                           
    seq {                                                     
        yield [| "A"; ["B";"C";"D"]; List.empty<string>; ["B";"C";"D";"A"] |]      
        yield [| "A"; ["B";"C";"D"]; ["D"]; ["B";"C";"A";"D"] |]                  
        yield [| "A"; ["B";"C";"D"]; ["C";"D"]; ["B";"A";"C";"D"] |]                
        yield [| "A"; ["B";"C";"D"]; ["B";"C";"D"]; ["A";"B";"C";"D"] |]              
    }                                                         
