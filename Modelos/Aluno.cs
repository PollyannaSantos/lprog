//Uma class pode ter métodos

namespace Modelos {
  class Aluno {
    public string nome;
    public string matricula;
    public int periodo;

    public Aluno() : this(0) {
    }

    public bool Matricular(Disciplina disciplina) {
      return this.periodo == disciplina.semestre;
    }
    
    public Aluno(int periodo) {
      if (periodo > 0) {
        this.periodo = periodo;
      }
      else {
        this.periodo = 1;
      }
    }
    public Aluno(string matricula, string nome) : 
    this() {
    this.matricula  = matricula;
    this.nome = nome;
  }
    
    public Aluno(string matricula, string nome, int periodo)
                : this(periodo) {
        this.matricula = matricula;
        this.nome = nome;
        }
  }
}