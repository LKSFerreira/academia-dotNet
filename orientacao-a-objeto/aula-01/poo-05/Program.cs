// 2 - Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula
// do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
// do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
// Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.

Aluno aluno1 = new Aluno("João", 123456);
Aluno aluno2 = new Aluno(new DateTime(2000, 10, 10));
Aluno aluno3 = new Aluno("Maria", new DateTime(2000, 10, 10), 2020);

Console.WriteLine(aluno1.ToString());
Console.WriteLine(aluno2.ToString());
Console.WriteLine(aluno3.ToString());
