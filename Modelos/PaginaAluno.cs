namespace Modelos {

  class TextoAluno : TextoPessoa {
    public Aluno Aluno {
      get; set;
    }

 public TextoAluno(Aluno aluno) : base((Pessoa) aluno) {
    this.Aluno = aluno;
  }

  public override string Informar() {
    return
      base.Informar() + "\n" +
      "Matricula: " + this.Aluno.Matricula + "\n" + "Período: " + this.Aluno.Periodo;
  }
  }
  
  class PaginaAluno : Pagina<Aluno> {
    public Texto Formatar(Aluno aluno){
    return new TextoAluno(aluno);
    }
  }
}