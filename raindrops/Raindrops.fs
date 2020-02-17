module Raindrops

let raindrops =
    [ (3, "Pling")
      (5, "Plang")
      (7, "Plong") ]

let convert (number: int): string =
    let output =
        raindrops
        |> List.map (fun (k, v) ->
            if number % k = 0 then v else "")
        |> String.concat ""

    match output with
    | "" -> string number
    | _ -> output



