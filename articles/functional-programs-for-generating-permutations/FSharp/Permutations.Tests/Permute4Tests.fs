module Permute4Tests

open Xunit
open Permutations.Permute4

[<Theory>]
[<ClassData(typeof<TestData.PermuteReverseLexographic>)>]
let ``permute`` (xs, expected: 't list list) =
    // Arrange // Act
    let actual = permute xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)
