// Usando variáveis

/*
    Regras Gerais para variáveis

→ Começar com uma letra ou sublinhado ou @ - Evitar @
→ Maiúscilas e minúsculas fazem diferença
→ Só usa letras, números e sublinhado
→ Podemos usar acentos
→ Não pode conter espaços
→ Não pode ter símbolos (só o sublinhado e a @)
→ Não pode ser uma palavra reservada
 */

byte idade = 25;
ushort publico = 5_550;
float media = 4.5f;
decimal estrela = 4.984737372M;
bool aprovado = false;
int x;
var y = 5.5f; // Não usar var, definir uma variável específica para economizar memória.

int salárioBruto;
float _décimo;


Console.WriteLine(y.GetType());
