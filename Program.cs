// Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato : 
// Aluno tem anos e nota usando a concatenação e a interpolação de strings.

// int idade = 17;
// string nome = "Paulo";
// float nota = 7.5f;
// Console.WriteLine($"{nome} tem {idade} anos e sua nota é {nota}.");

//--------------------------------------------------------------------------------------------

// Para o exercício anterior exiba o nome a idade e a nota 
// em linhas separadas usando as sequências deescapes.

// int idade = 17;
// string nome = "Paulo";
// float nota = 7.5f;

// Console.Write(nome);
// Console.Write(" tem ");
// Console.Write(idade);
// Console.Write(" anos e sua nota é ");
// Console.Write(nota);
// Console.WriteLine();

//-------------------------------------------------------------------------------------------

// Para qual tipo de dados você pode converter um float implicitamente ?
// ( ) int
// (x) double
// ( ) long
// ( ) decimal 

//-------------------------------------------------------------------------------------------

// Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ?
// (x) int para long
// ( ) double para long
// ( ) double para float
// ( ) decimal para float
// ( ) long para int
// ( ) double para decimal

//------------------------------------------------------------------------------------------

// Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando
// a concatenação e também a interpolação de strings

// Console.WriteLine("Informe a primeira letra:");
// var letra1 = Console.ReadLine();
// Console.WriteLine("informe sua segunda letra:");
// var letra2 = Console.ReadLine();
// Console.WriteLine("Informe sua terceira letra:");
// var letra3 = Console.ReadLine();

// string orc = ""+ letra3 + letra2 + letra1;
// string ori = $"{letra3}{letra2}{letra1}";

// Console.WriteLine("Ordem reserva em concatenação:"+orc);
// Console.WriteLine("Ordem reserva em interpolação:"+ori);

//-------------------------------------------------------------------------------------------

// Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
// (f) long resultado = 1.32;
// (v) var nome = “Maria”;
// (v) string resultado = 100.ToString();
// (v) A sequência de escape \n inclui uma nova linha
// (v) float f = 5.45;
// (v) decimal valor = (decimal) 10.99f;
// (v) var status = null;
// (v) object o = 12.45m;
// (v) string titulo = true.ToString();
// (f) A sequencia \t inclui uma tabulação vertical

//------------------------------------------------------------------------------------------

// Escreva um programa para receber dois valores via teclado do tipo double e a seguir
// realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo
// exibindo o resultado:

// Console.WriteLine("Informe o primeiro valor:");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Informe o segundo valor:");
// double num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Soma dos valores é {num1+num2}");
// Console.WriteLine($"Subtração dos valores é {num1-num2}");
// Console.WriteLine($"Multiplicação dos valores é {num1*num2}");
// Console.WriteLine($"Exponenciação do primeiro valor elevado ao segundo valor é {Math.Pow(num1,num2)}");
// double divisao = (double) num1/num2;
// Console.WriteLine($"Divisão dos valores é {num1/num2}");
// Console.WriteLine($"Módulo dos valores é {num1%num2}");

//-----------------------------------------------------------------------------------------

// Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e
// Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’
// então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login
// inválido’: (use o operador condicional ternário)

// Console.Write("Informe seu nome:");
// string nome = Console.ReadLine();
// Console.Write("Informe sua senha:");
// int senha;
// bool senhaValida = int.TryParse(Console.ReadLine(), out senha);

// string mensagem = (nome == "admin" || nome == "maria") && senha == 123
//     ? "Login feito com sucesso"
//     : "Login inválido";

// Console.WriteLine(mensagem);

//-----------------------------------------------------------------------------------------

// Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no
// console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :

// Console.Write("Informe o valor de x:");
// int x = Convert.ToInt32 (Console.ReadLine());
// Console.Write("Informe o valor de y:");
// int y = Convert.ToInt32 (Console.ReadLine());

// string xresultado = x % 2 == 0 ? "Par" : "Não par";

// string yresultado = y % 2 == 0 ? "Par" : "Não par";

// Console.WriteLine($"X é {xresultado} e o Y é {yresultado}");