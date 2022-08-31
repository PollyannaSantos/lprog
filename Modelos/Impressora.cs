using System;

namespace Modelos {

  class Impressora {
    public static void print(Aluno aluno) {
    Console.WriteLine(
     "-------------------------------------------------------\n" +
      "Matricula: " + aluno.Matricula + "\n"
     + "Nome: " + aluno.Nome + "\n" +
     "Periodo: " + aluno.Periodo + "\n" + "Semestre: " +      "\n" +
      "-------------------------------------------------------"
    );
  }
  public static void print(Disciplina disciplina) {
    Console.WriteLine(
      "-------------------------------------------------------\n" + "Nome: " +
      disciplina.Nome + "\n" + "Semestre: " 
      + disciplina.Semestre + "\n" +
      "-------------------------------------------------------"
    );
  }
 }

}