

//          Converção de variáveis

// Conversão implícita int -> float

/* 
    int a = 8;
    float b = int(a)
*/

// Conversão emplícita float -> int

/*

   float = 8.9999;
   int b = (int)a;

*/
// Conversão por Classes Auxiliares

    float a = 8.502f;
    int b = Convert.ToInt16(a);

Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
Console.WriteLine("O valor de a é " + b + " do tipo " + b.GetType());

//string datetime = DateTime.Now.ToString("hh:mm:ss tt");
//Console.WriteLine(Convert.ToDateTime(datetime).GetType());