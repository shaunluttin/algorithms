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
    Assert.Equal<int>(expected, actual);    

let kpermuteTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| 0; [0;1]; [List.empty<int>] |]
        // TODO: Gracefully handle the error that occurs when K exceeds N.
        // yield [| 1; List.empty<int>; List.empty<int> |] 
        yield [| 1; [0;1]; [[0];[1]] |]
        yield [| 2; [0;1]; [[0;1];[1;0]] |]
        yield [| 2; [0;1;2]; [[0;1];[1;0];[0;2];[2;0];[1;2];[2;1]] |]
    }                                                                                             

let permuteTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| [0;1]; [[0;1]; [1;0]] |]
        // The expected result is in neither lexographic nor reverse-lexographic order.
        yield [| [0;1;2]; [[0;1;2]; [1;0;2]; [1;2;0]; [0;2;1]; [2;0;1]; [2;1;0]] |]
    }                                                                                             

let mapinsertTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| 0; List.empty<List<int>>; List.empty<List<int>> |]
        yield [| 1; [[0]]; [[1;0]; [0;1]] |]
    }                                                                                             
                                                                                                  
let insertTestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| 0; [1;2]; [2]; List.empty<List<int>>; [[1;0;2]; [1;2;0]] |]
    }                                                                                             
                                                                                                  
let putTestValues : obj array seq =                           
    seq {                                                     
        yield [| 0; [1;2;3]; List.empty<int>; [1;2;3;0] |]      
        yield [| 0; [1;2;3]; [3]; [1;2;0;3] |]                  
        yield [| 0; [1;2;3]; [2;3]; [1;0;2;3] |]                
        yield [| 0; [1;2;3]; [1;2;3]; [0;1;2;3] |]              
    }                                                         
