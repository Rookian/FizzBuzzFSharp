namespace FizzBuzzFSharp

module FizzBuzz = 

  let fizzBuzz number = 
    match  (number % 3) + (number % 5)  with
      | 0 -> "FizzBuzz" 
      | _ -> 
        match  number % 5 with
          | 0 -> "Buzz"
          | _ -> 
            match number % 3 with
              | 0 -> "Fizz"
              | _ -> string number
            
  
  let a = fizzBuzz 3


namespace FizzBuzzFSharpTests

open Xunit
open FizzBuzzFSharp.FizzBuzz

module Tests = 
  
  [<Fact>]
  let ``Sollte Fizz bei durch 3 teilbaren Zahlen ausgeben`` () =
    let result = fizzBuzz 3
    Assert.Equal("Fizz", result)

  [<Fact>]
  let ``Sollte Buzz bei durch 5 teilbaren Zahlen ausgeben`` () =
    let result = fizzBuzz 5
    Assert.Equal("Buzz", result)

  [<Fact>]
  let ``Sollte FizzBuzz bei durch 5 und durch 3 teilbaren Zahlen ausgeben`` () =
    let result = fizzBuzz 15
    Assert.Equal("FizzBuzz", result)

  [<Fact>]
  let ``Sollte die Zahl bei nicht durch 5 und durch 3 teilbaren Zahlen ausgeben`` () =
    let result = fizzBuzz 2
    Assert.Equal("2", result)

  [<Theory>]
  [<InlineData(100, "Buzz")>]
  [<InlineData(3, "Fizz")>]
  [<InlineData(5, "Buzz")>]
  [<InlineData(1, "1")>]
  [<InlineData(44, "44")>]
  [<InlineData(15, "FizzBuzz")>]
  [<InlineData(33, "Fizz")>]
  [<InlineData(90, "FizzBuzz")>]
  let ``Sollte alles korrekt ausgeben F#™`` (number, expected) = 
    let result = fizzBuzz number
    Assert.Equal(expected, result)