using System;

class Aula2 {

  public struct Aluno {
    public string matricula;
    public int periodo;
  }

  public struct Disciplina {
    public string nome;
    public int semestre;
  }

  public static bool Matricular(Aluno aluno,Disciplina disciplina) {
    return aluno.periodo == disciplina.semestre;
  }

  public static void Imprimir(Aluno aluno, Disciplina disciplina) {
    if(Matricular(aluno, disciplina)) {
      Console.WriteLine(aluno.matricula);
    }
  }
  
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
      matricula = "012022",
      periodo = 1
    };
    
    Aluno aluno2 = new Aluno {
      matricula = "022022",
      periodo = 3
    };

    Disciplina disciplina = new Disciplina {
      nome = "Linguagem de Programação",
      semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);
    
  }

}
