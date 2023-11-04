// Learn more about F# at http://fsharp.org

open System

let dividirMaiorPeloMenor n1 n2 =
    if n1 > n2 then n1 / n2 else n2 / n1


let tipoTriangulo lado1 lado2 lado3 =
    let naoEhTriangulo n1 n2 n3 =
        n1 > n2 + n3 || n2 > n1 + n3 || n3 > n1 + n2

    let ehEquilatero n1 n2 n3 =
        n1 = n2 && n1 = n3

    let ehEscaleno n1 n2 n3 =
        n1 <> n2 && n2 <> n3 && n1 <> n3

    if naoEhTriangulo lado1 lado2 lado3 then
        "Não é um triângulo"
    else if ehEquilatero lado1 lado2 lado3 then
        "É um triângulo equilátero"
    else if ehEscaleno lado1 lado2 lado3 then
        "É um triângulo escaleno"
    else 
        "É um triângulo isósceles"

[<EntryPoint>]
let main argv =
    Console.WriteLine("Q1 - Divisão do maior pelo menor")
    Console.WriteLine("\tNúmeros: 15 e 5")
    Console.WriteLine("\t{0:D}", dividirMaiorPeloMenor 15 5)
    
    Console.WriteLine("")
        
    Console.WriteLine("Q2 - Tipo do triângulo")
    Console.WriteLine("\tLados: 15, 5, 5 = {0}", tipoTriangulo 15 5 5)
    Console.WriteLine("\tLados: 15, 10, 5 = {0}", tipoTriangulo 15 10 5)
    Console.WriteLine("\tLados: 15, 15, 15 = {0}", tipoTriangulo 15 15 15)
    Console.WriteLine("\tLados: 15, 15, 10 = {0}", tipoTriangulo 15 15 10)
    
    Console.WriteLine("")

    0 // return an integer exit code
