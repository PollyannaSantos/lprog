namespace Modelos {
  class Disciplina {
    private string nome;
    private int semestre;

    public int Semestre {
    get => this.semestre;
    set {
      if (semestre < 1) {
      this.semestre = 1;
    } else if(semestre > 10) {
      this.semestre = 10; }
    else {
      this.Semestre = semestre;
      }
    }
   }

     public string Nome {
    get; set;
  }

  public Disciplina() : this(1) {
  }

  public Disciplina(int semestre) {
    }
  }
}