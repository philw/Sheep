Module Module1

    Sub Main()

        Dim N, M As Integer

        Console.WriteLine("Ignore the sheep! Let's do some sums")

        UseThread()

        Do
            Console.Write("Enter first number: ")
            N = Console.ReadLine

            Console.Write("Enter second number: ")
            M = Console.ReadLine

            Console.WriteLine("{0} x {1} = {2}", N, M, N * M)
        Loop

    End Sub


    Public Sub CountSheep()
        Dim i As Integer = 1 ' Sheep do not count from 0.
        Dim x, y As Integer

        Do While (True) ' Endless loop.
            x = Console.CursorLeft
            y = Console.CursorTop
            Console.CursorLeft = 50
            Console.CursorTop = 0
            Console.WriteLine("Sheep " & i & " Baah Blaah Whatever")
            Console.CursorLeft = x
            Console.CursorTop = y
            i = i + 1
            System.Threading.Thread.Sleep(1000) 'Wait 5 seconds.
        Loop
    End Sub

    Sub UseThread()
        Dim t As New System.Threading.Thread(AddressOf CountSheep)
        t.Start()
    End Sub


End Module
