double numero;
Console.WriteLine("digite um numero");
numero = Convert.ToDouble(Console.ReadLine());
double outronumero;
Console.WriteLine("digite outro numero");
outronumero = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("escolha uma das operções:");
Console.WriteLine(" + para soma; - para subtração; * para multiplicação ou / para divisão");
string operação;
operação = Console.ReadLine()!;
if(operação == "+"){
    double resultadomais;
    resultadomais = numero + outronumero;
    Console.WriteLine($"o resultado de {numero} + {outronumero} = {resultadomais}");
}
if(operação == "-"){
    double resultadomenos;
    resultadomenos = numero - outronumero;
     Console.WriteLine($"o resultado de {numero} - {outronumero} = {resultadomenos}");
}
if(operação == "*"){
    double resultadovezes;
    resultadovezes = numero * outronumero;
    Console.WriteLine($"o resultado de {numero} * {outronumero} = {resultadovezes}");
}
if(operação == "/"){
    double resultadodividir;
    resultadodividir = numero / outronumero;
    Console.WriteLine($"o resultado de {numero} / {outronumero} = {resultadodividir}");
}
Console.WriteLine("");
Console.WriteLine("Obrigado por utilizar essa calculadora :)");
