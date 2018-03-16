module Permute3Tests

open Xunit
open Permutations.Permute3

[<Theory>]
[<ClassData(typeof<TestData.PermuteReverseLexographic>)>]
let ``permute`` (x, expected: 't list list) =
    // Arrange // Act
    let actual = permute x

    // Assert
    Assert.Equal<'t list list>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<ClassData(typeof<TestData.KPermuteLexographic>)>]
let ``kpermute`` (k, xs, expected: 't list list) =
    // Arrange // Act
    let actual = kpermute k xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)