module Permute2Tests

open Xunit
open FSharp.ConsoleApp

[<Fact>]
let ``removeFirst`` =
    // Arrange // Act
    let actual = Permute2.removeFirst 
                    List<int>.Empty 
                    0

    // Assert
    Assert.True(false)

[<Fact>]
let ``mapcons`` =
    // Arrange // Act
    let actual = Permute2.mapcons 
                    0 
                    List<List<int>>.Empty 
                    List<List<int>>.Empty

    // Assert
    Assert.True(false)

[<Fact>]
let ``mapperm`` =
    // Arrange // Act
    let actual = Permute2.mapperm 
                    List<int>.Empty 
                    List<int>.Empty

    // Assert
    Assert.True(false)

[<Fact>]
let ``permute2`` =
    // Arrange // Act
    let actual = Permute2.permute2 
                    List<int>.Empty

    // Assert
    Assert.True(false)
