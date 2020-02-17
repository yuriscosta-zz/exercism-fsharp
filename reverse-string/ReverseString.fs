module ReverseString

open System

let reverse (input: string): string =
    input |> Seq.fold (fun acc ch -> string (ch) + acc) ""