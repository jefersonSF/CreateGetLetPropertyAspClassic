/*
Cria os metodos Get e Let de uma lista de atributos para uma classe em ASP Classic ou VB6.
*/
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<string> listProperty = new List<string>();
List<string> listPropertyResult = new List<string>();


Console.WriteLine("################################################################\n" +
"Gerador de propriedades Get e Let para ASP Classic ou VB6 - V1.0" +
"\n################################################################\n\n");


Console.WriteLine("Entre com a lista de propriedades separadas por virgula e aperte ENTER.");
string propertys = Console.ReadLine() ?? string.Empty;
Console.WriteLine("\nResultado");

//Quebra a string de propriedades, numa lista, onde cada linha da string será um item da lista de propriedades.
listProperty = propertys.Split(',').Where(x => x.Trim() != "").ToList();

//Eliminar valores vazios.
listProperty = listProperty.Where(x=>!string.IsNullOrEmpty(x)).Select(x=>x.Replace("private ", "").Replace("public ", "").Trim()).Distinct(StringComparer.OrdinalIgnoreCase).ToList();

//Percorre a lista de propriedades para montar as propriedade Get e Let de cada atributo e adicionar numa nova lista de propriedadeds.
foreach (string proper in listProperty){
    string strPropGet = $"public property get Get{proper}()\n\t Get{proper} = {proper}\nend property \n";
    string strPropLet = $"public property let Let{proper}(value)\n\t {proper} = value\nend property";

    listPropertyResult.Add(strPropGet + strPropLet + "\n\n");
}

//Imprime a declaração das propriedades privadas da entidade.
foreach (string proper in listProperty)
{
    Console.WriteLine($"Private {proper}");
}

Console.WriteLine(Environment.NewLine);

//Imprime as propriedades Get e Let e cada atribuido.
listPropertyResult.ForEach(x=>{
    Console.WriteLine(x);
});

Console.Beep();
Console.WriteLine($"{Environment.NewLine}Aperte ENTER para fechar.");
Console.ReadLine();