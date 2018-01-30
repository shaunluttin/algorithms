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

[<Fact(Skip = "TODO")>]
let ``mapinsert`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Fact(Skip = "TODO")>]
let ``insert`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Theory>]
[<MemberData("putTestValues")>]
let ``put`` (a, p, q, expected) = 
    // Arrange // Act
    let actual = Permutations.put a p q

    // Assert
    Assert.Equal<int>(expected, actual);

let putTestValues : obj array seq = 
    seq {
        yield [|0; [1;2;3]; 3; [1;2;0;3]|]
        yield [|0; [1;2;3]; 2; [1;0;2;3]|]
        yield [|0; [1;2;3]; 1; [0;1;2;3]|]
    }
