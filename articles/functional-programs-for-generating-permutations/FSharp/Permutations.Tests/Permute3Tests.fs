module Permute3Tests

open Xunit
open Permutations.Permute3

[<Theory>]
[<ClassData(typeof<TestData.PermuteReverseLexographic>)>]
let ``permuteTest`` (x, expected: 't list list) =
    // Arrange // Act
    let actual = permute x

    // Assert
    Assert.Equal<'t list list>(expected, actual)

[<Theory(Skip = "Not implemented")>]
[<ClassData(typeof<TestData.KPermuteLexographic>)>]
let ``kpermuteTest`` (k, xs, expected: 't list list) =
    // Arrange // Act
    let actual = kpermute k xs

    // Assert
    Assert.Equal<'t list list>(expected, actual)
