using System;

namespace Modelos {

//  Para evitar a repetição de nome, CPF, etc. foi criado o Imprimir(Object obj).
  
  class Impressora {

    public static void print(Object obj) {
    Console.WriteLine("-------------------------------------------------------");
      
    if (obj is Pessoa) {
      print((Pessoa) obj);
    }
    if (obj is Professor) {
      print((Professor) obj);
    }
    if (obj is Aluno) {
   print((Aluno) obj);
    }
    if (obj is Disciplina) {
   print((Disciplina) obj);
    }
    if (obj is Contato) {
   print((Contato) obj);
    }
      
    Console.WriteLine("-------------------------------------------------------");
    }
    
    private static void print(Pessoa pessoa) {
    Console.WriteLine(
     "Nome: " + pessoa.Nome + "\n" + "CPF:" + pessoa.Cpf
    );
  } 
    
    private static void print(Professor professor) {
    Console.WriteLine(
    "Código: " + professor.Codigo
    );
  } 
    
    private static void print(Aluno aluno) {
    Console.WriteLine(
     "Matricula: " + aluno.Matricula + "\n" +  "Periodo: " + aluno.Periodo
    );
  }
    
    private static void print(Disciplina disciplina) {
    Console.WriteLine(
    "Nome: " +
      disciplina.Nome + "\n" + "Semestre: " 
      + disciplina.Semestre
    );
  }

    private static void print(Contato contato) {
    Console.WriteLine(
    contato.Informar()
    );
  } 
    
 }

}