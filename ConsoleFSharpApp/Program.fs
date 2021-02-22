open System

let rec input s  = 
    printf "%s: " s
    try
        Console.ReadLine() |> int
    with
        | _ -> printfn "Некорректный ввод!"
               input s

let rec getRange head tail =
    try
        if tail <= head then
            raise (System.ArgumentException())            
        else
            [head..tail]
    with
        | _ -> printfn "Конец диапазона не может быть меньше или равен началу!" 
               input "Введите конец диапазона" 
               |> getRange head         


[<EntryPoint>]
let main argv =
    let startInt = 
        input "Введите начало диапазона"

    let endInt = 
        input "Введите конец диапазона"

    let range = 
        MyRange.create startInt endInt
        
    range.Range |> printfn "%A"



    let evensCount =
        range.Evens |> Seq.length        

    printfn "\r\nКол-во четных элементов: %i" evensCount
    for even in range.Evens do
        printfn "%i" even

    
    printfn "\r\nГотово"
    Console.ReadKey() |> ignore
    0

