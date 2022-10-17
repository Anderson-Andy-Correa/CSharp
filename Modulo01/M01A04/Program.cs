
// Valores numéricos inteiros

Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue); // Usa apenas 1 byte (8 bits) aceitando apenas números positivos
Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue); // Usa apenas 1 byte (8 bits) aceitando números positivos e negativos
Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue); // Usa 2 bytes (16 bits) aceitando apenas números positivos
Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue); // Usa 2 bytes (16 bits) aceitando números positivos e negativos
Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue); // Usa 4 bytes (32 bits) aceitando apenas números positivos
Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue); // Usa 4 bytes (32 bits) aceitando números positivos e negativos
Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue); // Usa 8 bytes (64 bits) aceitando apenas números positivos
Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue); // Usa 8 bytes (64 bits) aceitando números positivos e negativos

// Valores numéricos reais

Console.WriteLine("O tipo float vai de " + float.MinValue + " até " + float.MaxValue); // Usa 4 bytes (32 bits)
Console.WriteLine("O tipo double vai de " + double.MinValue + " até " + double.MaxValue); // Usa 8 bytes (64 bits)
Console.WriteLine("O tipo double vai de " + decimal.MinValue + " até " + decimal.MaxValue); // Usa 16 bytes (128 bits)

// Valores textuais

Console.WriteLine("O tipo char mostra apenas um caractere: 'E'");
Console.WriteLine("O tipo string mostra uma cadeia de caracteres: \"Exemplo\"");

// Valores lógicos

Console.WriteLine("O tipo bool mostra apenas um valor lógico: true ou  false"); // Usa apenas 1 bit


Console.ReadKey();