using System;
using Modelos;

class Aula3 {
  public static void print(Aluno aluno) {
    Console.WriteLine(
     "------------------------\n" +
      "Matricula: " + aluno.matricula + "\n"
     + "Nome: " + aluno.nome + "\n" +
     "Periodo: " + aluno.periodo + "\n" + "Semestre: " +      "\n" +
      "------------------------"
    );
  }
  public static void print(Disciplina disciplina) {
    Console.WriteLine(
      "------------------------\n" + "Nome: " +
      disciplina.nome + "\n" + "Semestre: " 
      + disciplina.semestre + "\n" +
      "------------------------"
    );
}
public static void Main (string[] args) {
  Aluno aluno1 = new Aluno {
    matricula = "2020ENEL123",
    nome = "Maria",
    periodo = 0
  };
  
  Disciplina disciplina1 = new Disciplina(11);
 

  Disciplina disciplina2 = new Disciplina(0);
 
  
  print(aluno1);
  Aluno aluno2 = new Aluno();
  print(aluno2);
  Aluno aluno3 = new Aluno(2);
  print(aluno3);
  Aluno aluno4 = new Aluno("2020ENEL456", "José");
  print(aluno4);
  Aluno aluno5 = new Aluno("2020ENEL789", "João", 3);
  print(aluno5);

  print(disciplina1); 
  print(disciplina2); 
    
  }
}