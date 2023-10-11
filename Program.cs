// Challenge 1
bool amProgrammer = true; // "true" debe ser true
int Age = 27; // 27.9 debe ser 27 (ya que la edad no puede ser un número decimal)
List<string> Names = new List<string>();
Names.Add("Monica") ; // Para agregar un elemento a la lista, se utiliza el método Add
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0"); // un valor numérico, se debe convertirlo a string
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName"; // Esto es un carácter, de una cadena,se utiliza comillas dobles: string MyName = "MyName";


// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = Numbers.Count - 1; i >= 0; i--) // La condición del bucle for debe ser i > 0 en lugar de i >= 0 
{
    Console.WriteLine(Numbers[i]);
}


// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(MoreNumbers[i]);
}


// Challenge 4
//En el bucle foreach, num es solo una copia del valor en la lista puede que afecte el valor real en EvenMoreNumbers.
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
for (int i = 0; i < EvenMoreNumbers.Count; i++)
{
    if (EvenMoreNumbers[i] % 3 == 0)
    {
        EvenMoreNumbers[i] = 0;
    }
}
/* List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        num = 0;
    }
} */


// Challenge 5
// What can we learn from this error message?

// las cadenas de texto (string) son inmutables, lo que significa que no se pueden modificar directamente
string MyString = "superduberawesome";
MyString = MyString.Substring(0,7) + MyString.Substring(8);


// Challenge 6
// Hint: some bugs don't come with error messages

/* Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
} */

// Challenge 6  LA FUNCION RAND.TEXT(12) TOMA UN NUMERO ALEATORIO ENRE 0 A 11 - POR LO QUE ES IMPOSIVLE QUE SEA IGUAL A 12 , ASI QUE CAMBIO LAS CONDICION DE 12 A 13
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
