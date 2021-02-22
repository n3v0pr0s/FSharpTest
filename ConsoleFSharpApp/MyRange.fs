module MyRange

    let private isEven x = 
        x % 2 = 0
     
    let private getEvens arr =
        arr |> Seq.filter(fun x -> isEven x)

    type myRange = {
        Start: int
        End: int
    } with 

        member this.Range = 
            [this.Start..this.End]

        member this.Evens = 
            this.Range |> getEvens

    let create head tail = {
        Start = head
        End = tail
    }