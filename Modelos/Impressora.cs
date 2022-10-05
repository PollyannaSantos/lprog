using System;

namespace Modelos {

//  Para evitar a repetição de nome, CPF, etc. foi criado o Imprimir(Object obj).
  
  class Impressora {

    public static void print(Texto texto) {
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine(texto.Informar());
    Console.WriteLine("-------------------------------------------------------");
    }
    
    public static void print(Pessoa pessoa) {
    Console.WriteLine(
    );
  } 
    
    public static void print(Professor professor) {
    Console.WriteLine(
    "Código: " + professor.Codigo
    );
  } 
    
    public static void print(Aluno aluno) {
      Console.WriteLine();
  }
    
    public static void print(Disciplina disciplina) {
    Console.WriteLine(
    "Nome: " +
      disciplina.Nome + "\n" + "Semestre: " 
      + disciplina.Semestre
    );
  }

    public static void print(Contato contato) {
    Console.WriteLine(
    contato.Informar()
    );
  } 
    
 }

}