// See 
// docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-fsharp-with-dotnet-test

module Permute1Tests

open Xunit
open Permutations

[<Theory>]
[<MemberData("permute1TestValues")>]
let ``permute1`` (x, expected) = 
    // Arrange // Act                             
    let actual = Permute1.permute1 x
                                                
    // Assert                                     
    Assert.Equal<List<int>>(expected, actual);          

[<Theory>]
[<MemberData("mapinsertTestValues")>]
let ``mapinsert`` (a, ps, expected) = 
    // Arrange // Act                             
    let actual = Permute1.mapinsert a ps      
                                                
    // Assert                                     
    Assert.Equal<List<int>>(expected, actual);          

[<Theory>]
[<MemberData("insertTestValues")>]
let ``insert`` (a, p, q, ps, expected) = 
    // Arrange // Act                                      
    let actual = Permute1.insert a p q ps              
                                                        
    // Assert                                              
    Assert.Equal<List<int>>(expected, actual);                   

[<Theory>]
[<MemberData("putTestValues")>]
let ``put`` (a, p, q, expected) = 
    // Arrange // Act                       
    let actual = Permute1.put a p q     
                                            
    // Assert                               
    Assert.Equal<int>(expected, actual);    

let permute1TestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| [0;1]; [[0;1]; [1;0]] |]
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