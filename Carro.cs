class Carro {
  string marca;
  public string getMarca(){
    return marca;
  }

  double consumo_litro;
  public double getConsumo(){
    return consumo_litro;
  }

  public Carro (string m, double c){
    marca = m;
    consumo_litro = c;
  }

}