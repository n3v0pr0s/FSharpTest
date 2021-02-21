open System

let rec input s  = 
    printf "%s: " s
    try
        Console.ReadLine() |> int
    with
        | _ -> printfn "Некорректный ввод!"; input s

let rec getRange start _end =
    try
        if _end <= start then
            raise (System.ArgumentException())            
        else
            [start.._end]
    with
        | _ -> printfn "Конец диапазона не может быть меньше или равен началу!"; input "Введите конец диапазона"
            |> getRange start         


[<EntryPoint>]
let main argv =
    let startInt = 
        input "Введите начало диапазона"

    let endInt = 
        input "Введите конец диапазона"

    let evens =
       getRange startInt endInt
       |> EvenNumbers.getFrom

    let evensCount =
        evens |> Seq.length        

    printfn "\r\nКол-во четных элементов: %i" evensCount
    for even in evens do
        printfn "%i" even
    
    printfn "\r\nГотово"
    Console.ReadKey() |> ignore
    0

