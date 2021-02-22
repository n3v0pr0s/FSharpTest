[<EntryPoint>]
let main argv =
    let range = RangeValidator.createRange 
    
    printfn "\r\nКол-во элементов в массиве: %i" range.Count
    range.Range |> printfn "%A"     

    printfn "\r\nКол-во четных элементов: %i" range.EvensCount
    range.Evens |> printfn "%A"
    
    printfn "\r\nГотово"
    System.Console.ReadKey() |> ignore
    0

