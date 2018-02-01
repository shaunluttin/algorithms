// See 
// docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-fsharp-with-dotnet-test


module Tests

open System
open Xunit
open FSharp.ConsoleApp

[<Fact(Skip = "TODO")>]
let ``permute1`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Theory>]
[<MemberData("mapinsertTestValues")>]
let ``mapinsert`` (a, ps, expected) = 
    // Arrange // Act
    let actual = Permutations.mapinsert a ps

    // Assert
    Assert.Equal<int>(expected, actual);

[<Theory>]
[<MemberData("insertTestValues")>]
let ``insert`` (a, p, q, ps, expected) = 
    // Arrange // Act
    let actual = Permutations.insert a p q ps 

    // Assert
    Assert.Equal<int>(expected, actual);

[<Theory>]
[<MemberData("putTestValues")>]
let ``put`` (a, p, q, expected) = 
    // Arrange // Act
    let actual = Permutations.put a p q

    // Assert
    Assert.Equal<int>(expected, actual);

let mapinsertTestValues : obj array seq = 
    seq {
        yield [|0; [2;3]; [0;2;  2;0;  0;3;  3;0]|]
        yield [|0; [3]; [0;3;  3;0]|]
    }

let insertTestValues : obj array seq = 
    seq {
        yield [|0; [2]; [2]; [0;3;  3;0]; [0;2;  2;0;  0;3;  3;0]|]
        yield [|0; [3]; [3]; List.empty<int>; [0;3;  3;0]|]

        yield [|0; [1;2;3]; List.empty<int>; List.empty<int>; [1;2;3;0]|]
        yield [|0; [1;2;3]; [3]; List.empty<int>; [1;2;0;3;  1;2;3;0]|]
        yield [|0; [1;2;3]; [2;3]; List.empty<int>; [1;0;2;3;  1;2;0;3;  1;2;3;0]|]
        yield [|0; [1;2;3]; [1;2;3]; List.empty<int>; [0;1;2;3;  1;0;2;3;  1;2;0;3;  1;2;3;0]|]
    }

let putTestValues : obj array seq = 
    seq {
        yield [|0; [1;2;3]; List.empty<int>; [1;2;3;0]|]
        yield [|0; [1;2;3]; [3]; [1;2;0;3]|]
        yield [|0; [1;2;3]; [2;3]; [1;0;2;3]|]
        yield [|0; [1;2;3]; [1;2;3]; [0;1;2;3]|]
    }
