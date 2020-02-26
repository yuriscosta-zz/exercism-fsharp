module Raindrops

let raindrops =
    [ (3, "Pling")
      (5, "Plang")
      (7, "Plong") ]

let convert (number: int): string =
        raindrops
        |> List.map (fun (divisor, word) ->
            if number % divisor = 0 then word else "")
        |> String.concat ""
        |> function
            | "" -> string number
            | sounds -> sounds
