module Permute5Tests

open Xunit
open Permutations.Permute5

[<Theory(Skip = "TODO")>]
[<MemberData("genRevTestData")>]
let ``genRevTest`` () =
    // Arrange // Act 
    
    // Assert
    Assert.Equal(true, false)

[<Theory(Skip = "TODO")>]
[<MemberData("next3TestData")>]
let ``next3Test`` () =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("firstLessTestData")>]
let ``firstLessTest`` (ps: 't list, a: 't, expected: 't list) =
    // Arrange // Act 
    let actual = firstLess ps a
    
    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory(Skip = "TODO")>]
[<MemberData("mapConsTestData")>]
let ``next2Test`` () =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory>]
[<MemberData("firstUpTestData")>]
let ``firstUpTest`` (ps: 't list, expected: 't list) =
    // Arrange // Act 
    let actual = firstUp ps
    
    // Assert
    Assert.Equal<'t list>(expected, actual)

[<Theory(Skip = "TODO")>]
[<MemberData("nextPermTestData")>]
let ``nextPermTest`` () =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

[<Theory(Skip = "TODO")>]
[<MemberData("permuteTestData")>]
let ``permuteTest`` () =
    // Arrange // Act // Assert
    Assert.Equal(true, false)

let firstLessTestData : obj array seq =                                                            
    seq {                                                                                         
        yield [| ["A";"B";"C"]; "B"; ["A";"B";"C"] |]
        // yield [| ["C";"A";"B"]; "B"; ["C";"A";"B"] |]
        // yield [| ["A";"B";"C"]; "A"; ["B";"C"] |]
    }                                                                                             

let firstUpTestData : obj array seq =                                                            
    seq {                                                                                         
        yield [| ["A";"B";"C"]; ["B";"C"] |]
        yield [| ["B";"A";"C"]; ["C"] |]
        yield [| ["C";"B";"A"]; List.empty<string> |]
    }                                                                                             