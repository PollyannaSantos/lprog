namespace Modelos {

  class TextoAluno : Texto {
    public Aluno Aluno {
      get; set;
    }

  public TextoAluno(Aluno aluno) {
    this.Aluno = aluno;
  }

  public override string Informar() {
    return
      "Matricula: " + this.Aluno.Matricula + "\n" + "Período: " + this.Aluno.Periodo;
  }
  }
  
  class PaginaAluno : Pagina<Aluno> {
    public Texto Formatar(Aluno aluno){
    return new TextoAluno(aluno);
    }
  }
}