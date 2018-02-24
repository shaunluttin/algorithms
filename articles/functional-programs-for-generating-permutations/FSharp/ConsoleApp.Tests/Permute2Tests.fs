module Permute2Tests

open Xunit
open FSharp.ConsoleApp

[<Theory>]
[<MemberData("removeFirstTestData")>]
let ``removeFirst`` (item, list, expected: List<int>) =
    // Arrange // Act
    let actual = Permute2.removeFirst list item

    // Assert
    Assert.Equal<List<int>>(expected, actual)

[<Fact(Skip = "Not implemented yet")>]
let ``mapcons`` () =
    // Arrange // Act
    let actual = Permute2.mapcons 
                    0 
                    List<List<int>>.Empty 
                    List<List<int>>.Empty

    // Assert
    Assert.True(false)

[<Fact(Skip = "Not implemented yet")>]
let ``mapperm`` () =
    // Arrange // Act
    let actual = Permute2.mapperm 
                    List<int>.Empty 
                    List<int>.Empty

    // Assert
    Assert.True(false)

[<Fact(Skip = "Not implemented yet")>]
let ``permute2`` () =
    // Arrange // Act
    let actual = Permute2.permute2 
                    List<int>.Empty

    // Assert
    Assert.True(false)

let removeFirstTestData : obj array seq = 
    seq {
        // not in list
        yield [| 0; [1;2;3;4]; [1;2;3;4] |]
        // in list once
        yield [| 0; [0;1;2;3]; [1;2;3] |]
        yield [| 0; [1;0;2;3]; [1;2;3] |]
        yield [| 0; [1;2;0;3]; [1;2;3] |]
        yield [| 0; [1;2;3;0]; [1;2;3] |]
        // in list multiple times
        yield [| 0; [0;0;0;3]; [0;0;3] |]
    }