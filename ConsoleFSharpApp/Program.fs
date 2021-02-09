open System

let isEven x = 
    x % 2 = 0
     
let getEvenNumbers arr =    
    Seq.where(fun x -> isEven x) arr        
    

[<EntryPoint>]
let main argv =  
    printf "Введите начало диапазона: "
    let startInt = Console.ReadLine() |> int  

    printf "Введите конец диапазона: "
    let endInt = Console.ReadLine() |> int    

    let evenSeq = getEvenNumbers [startInt..endInt] 

    for i in evenSeq do
        printfn "%i" i
    
    printfn "\r\nГотово"
    Console.ReadKey()
    0

