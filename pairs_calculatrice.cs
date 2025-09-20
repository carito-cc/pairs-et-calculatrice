/*Demander à l'utilisateur d'encoder 1 nombre(int), si le modulo de 2 est 0, 
afficher "le nombre est pair", sinon "le nombre est impair" et gerer les erreurs.*/
/*using System;

Console.WriteLine("Entrez un numero entier: ");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero % 2 == 0)
{
    Console.WriteLine("Le nombre est pair.");
}
else
{
    Console.WriteLine("Le nombre est impair.");
};

/* Developez une calculatrice simple qui demande a l'utilisateur de saisir deux nombres entiers et une operation (+, -, *, /),
puis effectue l'operation et affiche le resultat.
*/
/*class Calculatrice
{
    static void Main()
    {
        Console.WriteLine("Entrez le premier nombre entier :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entrez le deuxieme nombre entier :");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entrez l'operation (+, -, *, /) :");
        char operation = Console.ReadLine()[0];

        int resultat = 0;
        bool operationValide = true;

        switch (operation)
        {
            case '+':
                resultat = num1 + num2;
                break;
            case '-':
                resultat = num1 - num2;
                break;
            case '*':
                resultat = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    resultat = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zero.");
                    operationValide = false;
                }
                break;
            default:
                Console.WriteLine("Erreur : Operation invalide.");
                operationValide = false;
                break;
        }

        if (operationValide)
        {
            Console.WriteLine($"Le resultat de {num1} {operation} {num2} est : {resultat}");
        }
    }
};

*/
/*Vérifier que'un compte bancaire BBAN est valide et afficher le résultat dans la console. 
(Il est valide si le modulo des 10 premiers chiffres par 97 donne les 2 derniers ou ils
valent 97 s'il vaut 0.) exemple valide: 539007547034 */

Console.WriteLine("Entrez un numero de compte bancaire (BBAN) :");
string bban = Console.ReadLine();



