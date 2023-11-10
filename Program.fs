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

let processarVetor =
    [0..20]
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * 2)
    |> List.filter (fun x -> x % 6 = 0)

let resultadoNotas nota1 nota2 nota3 =
    let calcularMedia n1 n2 n3 =
        (n1 + n2 + n3) / 3.0

    let avaliarMedia media =
        media > 6.0

    let exibirResultado aprovado =
        if aprovado then "Aprovado" else "Reprovado"

    calcularMedia nota1 nota2 nota3
    |> avaliarMedia
    |> exibirResultado


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

    Console.WriteLine("Q3 - Processamento de Vetor")
    Console.WriteLine("\tResultado: {0}", String.Join(", ", processarVetor))

    Console.WriteLine("")

    Console.WriteLine("Q4 - Resultado Notas")
    Console.WriteLine("\tMédia e resultado: {0}", resultadoNotas 10.0 8.5 3.75)
    Console.WriteLine("\tMédia e resultado: {0}", resultadoNotas 4.5 2.75 1.8)

    0 // return an integer exit code
