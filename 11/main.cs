using Modelos;

class Aula11 {

public static void Main (string[] args) {

Disciplina calculo = new Disciplina("Calculo");
Disciplina fisica = new Disciplina("Fisica");
fisica.Prerequisito = calculo;
  Curso engenharia = new Curso();
  engenharia.Nome = "Engenharia";
  engenharia.Disciplinas.Add(calculo);
  engenharia.Disciplinas.Add(fisica);
  Aluno aluno1 = new Aluno();
  Matricula matricula1 = aluno1.Cursar(engenharia);
  matricula1.Ano = 2022;
  matricula1.Semestre = 2;
  matricula1.Codigo = "2022EN0001";
  
  }
  
}