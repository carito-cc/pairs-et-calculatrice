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

/*Console.WriteLine("Entrez un numero de compte bancaire (BBAN) :");
string bban = Console.ReadLine();
if (bban.Length != 12 || !long.TryParse(bban, out _))
{
    Console.WriteLine("Erreur : Le BBAN doit contenir exactement 12 chiffres.");
}
else
{
    long numeroPrincipal = long.Parse(bban.Substring(0, 10));
    int cle = int.Parse(bban.Substring(10, 2));

    int reste = (int)(numeroPrincipal % 97);
    int cleCalculee = reste == 0 ? 97 : reste;

    if (cleCalculee == cle)
    {
        Console.WriteLine("Le BBAN est valide.");
    }
    else
    {
        Console.WriteLine("Le BBAN n'est pas valide.");
    }
};*/

/*Calculer ma somme de toutes les nombre pairs de 
1 à 100 à l'aide d'une boucle "for".*/
       
int somme = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        somme += i;
    }
}
Console.WriteLine($"La somme des nombres pairs de 1 à 100 est : {somme}");
        

/*Calculer la factoriel d'un nombre entré au clavier à l'aide d'une boucle "while".
int factoriel = 1;
int n = 8; // nombre pour lequel on veut calculer la factorielle
int compteur = 1;
while (compteur <= n)
{
    factoriel *= compteur;
    compteur++;
}
*/

/*Demander à l'utililisateur de saisir un nombre entier et afficher la table de 
multiplication de ce nombre de 1 à 10*/
/*Console.WriteLine("Entrez un nombre entier pour afficher sa table de multiplication :");
int nombre = Convert.ToInt32(Console.ReadLine());   
for (int i = 1; i <= 10; i++)
{
    int resultat = nombre * i;
    Console.WriteLine($"{nombre} x {i} = {resultat}");
};*/





