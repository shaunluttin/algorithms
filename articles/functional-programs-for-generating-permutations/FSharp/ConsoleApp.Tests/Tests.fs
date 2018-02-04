// See 
// docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-fsharp-with-dotnet-test

module Tests

open System
open Xunit
open FSharp.ConsoleApp

[<Theory>]
[<MemberData("permute1TestValues")>]
let ``permute1`` (x, expected) = 
    // Arrange // Act // Assert
    Assert.True(false)

[<Theory>]
[<MemberData("mapinsertTestValues")>]
let ``mapinsert`` (a, ps, expected) = 
    // Arrange // Act // Assert
    Assert.True(false)

[<Theory>]
[<MemberData("insertTestValues")>]
let ``insert`` (a, p, q, ps, expected) = 
    // Arrange // Act // Assert
    Assert.True(false)

[<Theory>]
[<MemberData("putTestValues")>]
let ``put`` (a, p, q, expected) = 
    // Arrange // Act // Assert
    Assert.True(false)
