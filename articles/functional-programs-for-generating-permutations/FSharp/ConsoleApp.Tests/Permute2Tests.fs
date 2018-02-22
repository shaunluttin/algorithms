module Permute2Tests

open Xunit
open FSharp.ConsoleApp

[<Theory>]
[<MemberData("permute2TestValues")>]
let ``permute2`` (x, expected) = 
    let actual = Permute2.permute2 x
                                                
    // Assert                                     
    Assert.Equal<List<int>>(expected, actual);          

// TODO Share this between the Permute1Tests and the Permute2Tests.
let permute2TestValues : obj array seq =                                                            
    seq {                                                                                         
        yield [| [0;1]; [[0;1]; [1;0]] |]
        yield [| [0;1;2]; [[0;1;2]; [1;0;2]; [1;2;0]; [0;2;1]; [2;0;1]; [2;1;0]] |]
    }                                                                                             
