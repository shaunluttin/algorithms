// See 
// docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-fsharp-with-dotnet-test


module Tests

open System
open Xunit
open FSharp.ConsoleApp

[<Fact>]
let ``permute1`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Fact>]
let ``mapinsert`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Fact>]
let ``insert`` () = 
    // Arrange
    // Act
    // Assert
    Assert.True(false)

[<Fact>]
let ``put`` () = 
    // Arrange
    let a = 0
    let p = [1; 2; 3]
    let q = 3

    // Act
    let result = Permutations.put a p q

    // Assert
    Assert.True(false)