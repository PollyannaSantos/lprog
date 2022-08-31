using System;
using Modelos;

class Aula3 {
public static void Main (string[] args) {
  Aluno aluno1 = new Aluno {
    Matricula = "2020ENEL123",
    Nome = "Maria"
  };
  
  Disciplina disciplina1 = new Disciplina(11);
 

  Disciplina disciplina2 = new Disciplina(0);
 
  
  Impressora.print(aluno1);
  Aluno aluno2 = new Aluno();
   aluno2.Periodo = 2;
  Impressora.print(aluno2);
  Aluno aluno3 = new Aluno(2);
  Impressora.print(aluno3);
  Aluno aluno4 = new Aluno("2020ENEL456", "José");
  Impressora.print(aluno4);
  Aluno aluno5 = new Aluno("2020ENEL789", "João", 3);
  Impressora.print(aluno5); 
  Impressora.print(disciplina1); 
  Impressora.print(disciplina2); 
    
  }
}