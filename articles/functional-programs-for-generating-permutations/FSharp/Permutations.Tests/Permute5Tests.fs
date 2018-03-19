module Permute5Tests

open Xunit
open Permutations.Permute5

// [<Theory(Skip = "TODO")>]
// [<MemberData("genRevTestData")>]
// let ``genRevTest`` =
//     // Arrange // Act 
    
//     // Assert
//     Assert.Equal(true, false)

// [<Theory(Skip = "TODO")>]
// [<MemberData("next3TestData")>]
// let ``next3Test`` =
//     // Arrange // Act // Assert
//     Assert.Equal(true, false)

// [<Theory(Skip = "TODO")>]
// [<MemberData("firstLessTestData")>]
// let ``firstLess`` =
//     // Arrange // Act // Assert
//     Assert.Equal(true, false)

// [<Theory(Skip = "TODO")>]
// [<MemberData("mapConsTestData")>]
// let ``next2Test`` =
//     // Arrange // Act // Assert
//     Assert.Equal(true, false)

[<Theory>]
[<MemberData("firstUpTestData")>]
let ``firstUpTest`` (ps: 't list, expected: 't list) =
    // Arrange // Act 
    let result = firstUp ps
    
    // Assert
    Assert.Equal<'t list>(result, expected)

// [<Theory(Skip = "TODO")>]
// [<MemberData("nextPermTestData")>]
// let ``nextPermTest`` =
//     // Arrange // Act // Assert
//     Assert.Equal(true, false)

// [<Theory(Skip = "TODO")>]
// [<MemberData("permuteTestData")>]
// let ``permuteTest`` =
//     // Arrange // Act // Assert
//     Assert.Equal(true, false)

let firstUpTestData : obj array seq =                                                            
    seq {                                                                                         
        yield [| 
            ["A";"B";"C"];
            ["B";"C"]
        |]
    }                                                                                             