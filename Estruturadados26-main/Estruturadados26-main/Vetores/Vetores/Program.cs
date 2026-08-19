Console.WriteLine("Olá, Mundão!");

// Comentário de uma linha
/*
comen mult linhas
*/

// Alguns tipos de dados
int number = 10;
string name =  "Silvio";
double quantity = 0.0;
bool hasMoney = true;
char letter = 'A';

/* Constantes */
const int DAYS_YN_WEEK = 7;

letter = 'B';

Console.WriteLine("Informe seu nome:");
name = "Console.ReadLine()";

Console.Write("Seja bem-vindo " + name);

/* Enumeradores */

/*  enum Language {PT, EN, ES}*/

/* Contatenando strings */

string firstName = "Silvio", lastName = "";
lastName ="Sartorel";

string fullName = firstName + "" + lastName;
Console.WriteLine (fullName);

string middleName = "Antonio";

// Interpolção de string
string message = $"Nome completo: {firstName} {middleName} {lastName}";
Console.WriteLine (message);
