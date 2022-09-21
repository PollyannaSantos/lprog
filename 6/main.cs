using Modelos;

class Aula6 {

  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno(0);
    aluno1.Cpf = "422.657.877-99";
    Impressora.print(aluno1);
    Aluno aluno2 = new Aluno(1);
    aluno2.Cpf = "660.036.460-20";
    Impressora.print(aluno2);
    
    Pessoa pessoa1 = new Professor();
    //pessoa1.Cpf = "588.401.710-37";
    //Impressora.print(pessoa1);
    Pessoa pessoa2 = (Pessoa) aluno2;
    Impressora.print(pessoa2);
    
    Aluno aluno3 = (Aluno) pessoa2;
    Impressora.print(aluno3);
    Professor professor1 = new Professor();
    professor1.Cpf = "851.152.090-20";
    Impressora.print(professor1);

    Familiar familiar1 = new Familiar();
    familiar1.Nome = "Rafaela Shimidth";
    familiar1.Cpf = "446.637.010-94";
    familiar1.Parentesco = "Mãe";
    Impressora.print(familiar1);
    
  }

}