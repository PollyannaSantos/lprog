namespace Modelos {

class Telefone : Contato {
  
public string Tipo {
  get; set;
}

public int Numero {
  get; set;
}

public string Informar() {
  return "Tipo (Telefone): " + this.Tipo + "\n" + "Numero: " + this.Numero;
    }
  
  }
}