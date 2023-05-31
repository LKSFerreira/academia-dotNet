using Criptografia;
using CriptografiaSimetricaAndAssimetrica;

// Console.WriteLine($"Digite o texto a ser criptografado: ");
// string texto = "Lucas Ferreira";

// Simetrica simetrica = new Simetrica();
// string mensagemCriptografada = simetrica.EncryptData(texto, "Única chave privada");
// Console.WriteLine($"Mensagem criptograda: {mensagemCriptografada}");
// string mensagemCriptografada = "QyleQCBWkNHRZkwGorlwp9FJ2ITxCWhlIrq312PnfRytVdwPatO1W8SWj6frm68Et7pGyMkBGQlCoJEJCfqmnuzFXSqjnR5+/VbW946TIzw0FGhODlWEGCrDDT15Na9sxygNxZ2umzTOaEBuZdhJoKmsVD9l+BfNCqbWoPHD6zw=";

// string mensagemDescriptografada = simetrica.DecryptData(mensagemCriptografada, "Única chave privada");
// string mensagemDescriptografada = simetrica.DecryptData(mensagemCriptografada, "atos20232");
// Console.WriteLine($"Mensagem descriptografada:\n\n{mensagemDescriptografada}");

Assimetrica assimetrica = new Assimetrica();

string textoCriptografado = assimetrica.encrypt("Lucas Ferreira");
Console.WriteLine($"Texto criptografado: {textoCriptografado}");

string textoDescriptografado = assimetrica.decrypt(textoCriptografado);
Console.WriteLine($"Texto descriptografado: {textoDescriptografado}");
