// Criar uma classe Pessoa que contém as propriedades Nome e Idade. Criar duas classes derivadas, Aluno e Professor, que herdam de Pessoa. A classe Aluno deve ter uma propriedade adicional Matricula, enquanto a classe Professor deve ter uma propriedade adicional Disciplina. Criar um método Apresentar na classe Pessoa que imprime o nome e a idade da pessoa. Em seguida, criar um método Apresentar na classe Aluno que imprime o nome, a idade e a matrícula do aluno, e um método Apresentar na classe Professor que imprime o nome, a idade e a disciplina do professor.

using Escolar_POO.Model;

Professor professor = new Professor("João", 30, "Matemática");
Aluno aluno = new Aluno("Maria", 20, 123456);

Console.WriteLine($"Professor:\n{professor}\n");
Console.WriteLine($"Aluno:\n{aluno}");