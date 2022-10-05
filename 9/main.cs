using Modelos;
  
  class Aula9 {
    public static void Main (string[] args) {

  Aluno aluno1 = new Aluno(1);
  aluno1.Cpf = "422.657.877-99";
  PaginaAluno paginaAluno = new PaginaAluno();
  Impressora.print(paginaAluno.Formatar(aluno1));
    
  }
}