





namespace FlowDesignFSharp
open System.IO  
  module SpellChecker = 
    
    type Wörterbuch = {
      Wörter : string list
    }

    let prüfe text = 
      File.ReadLines("dictionary.txt")

    let TextInWoerterZerlegen text = ""
    let WörterbuchAuslesen () = ""


namespace FlowDesignFSharpTests
open FlowDesignFSharp
  module Tests = 

  let ``Prüfen findet falsche Wörter`` () =
    SpellChecker.prüfe "lorem ipsum dolor sit amet."
    
