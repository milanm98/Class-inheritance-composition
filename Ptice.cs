using System;

class Slavuj : Ptica{
  private string vrsta;
  private string staniste;

  public Slavuj(Kljun noviKljun, Krila novaKrila, string novaVrsta, string novoStaniste){
    vrsta = novaVrsta;
    staniste = novoStaniste;
    krila = novaKrila;
    kljun = noviKljun;
  }

  public void setSlavuj(Kljun noviKljun, Krila novaKrila, string novaVrsta, string novoStaniste){
    vrsta = novaVrsta;
    staniste = novoStaniste;
    krila = novaKrila;
    kljun = noviKljun;
  }

  public string getStaniste(){ return staniste; }
  public string getVrsta(){ return vrsta; }

  public override void Ispis(){
    Console.WriteLine("----------------------");
    Console.WriteLine("Ptica : Slavuj");
    Console.WriteLine("Vrsta : "+ vrsta);
    Console.WriteLine("Staniste : "+ staniste);
    Console.WriteLine("Velicina kljuna : "+ getKljun());
    Console.WriteLine("Velicina krila : "+ getKrila());
    Console.WriteLine("----------------------");
  }  
  
}


class Orao : Ptica{
  
  private string vrsta;

  public Orao(){}
  public Orao(Kljun noviKljun, Krila novaKrila, string novaVrsta){
    vrsta = novaVrsta;
    kljun = noviKljun;
    krila = novaKrila;
  }

  public void setOrao(Kljun noviKljun, Krila novaKrila, string novaVrsta){
    vrsta = novaVrsta;
    kljun = noviKljun;
    krila = novaKrila;
  }

  public string getVrsta(){ return vrsta; }
  
  public override void Ispis(){
    Console.WriteLine("----------------------");
    Console.WriteLine("Ptica : Orao");
    Console.WriteLine("Vrsta : "+ vrsta);
    Console.WriteLine("Velicina kljuna : "+ getKljun());
    Console.WriteLine("Velicina krila : "+ getKrila());
    Console.WriteLine("----------------------");
  }  

}


class Ptica{

  public Kljun kljun;
  public Krila krila;

  public Ptica(){}
  public Ptica(Kljun noviKljun, Krila novaKrila){
     kljun = noviKljun;
     krila = novaKrila;
  } 

  public void setPtica(Kljun noviKljun, Krila novaKrila){
    kljun = noviKljun;
    krila = novaKrila;
  }

  public int getKrila(){
    return krila.velicinaKrila;
  }

  public int getKljun(){
    return kljun.velicinaKljuna;
  }
  
  public virtual void Ispis(){
    kljun.Ispis();
    krila.Ispis();
  }

}

class Krila{
  
  public int velicinaKrila;
  
  public Krila(){}
  public Krila(int velicina){
    velicinaKrila = velicina;
  }

  public void setKrila(int velicina){
    velicinaKrila = velicina;
  }

  public int getKrila(){
    return velicinaKrila;
  }
  
  public void Ispis(){
    Console.WriteLine("Velicina krila ove ptice je : " + velicinaKrila);
  }
}

class Kljun{

  public int velicinaKljuna;

  public Kljun(){}
  public Kljun(int velicina){
    velicinaKljuna = velicina;
  }

  public void setKljun(int velicina){
    velicinaKljuna = velicina;
  }
  
  public void Ispis(){
    Console.WriteLine("Velicina kljuna ove ptice je : " + velicinaKljuna);
  }
}

class Program {
    static void Main(string[] args) {
      
       /// testiranje klase Krila
       Krila novaKrila = new Krila(5);
       /// novaKrila.Ispis();

       /// testiranje klase Kljun
       Kljun noviKljun = new Kljun(23);
       /// noviKljun.Ispis();

       /// testiranje klase Ptica
       Ptica novaPtica = new Ptica(noviKljun, novaKrila);
       /// novaPtica.Ispis();
       /// Console.WriteLine(novaPtica.getKrila());

       /// tesitranje klase Orao
       Orao orao = new Orao(noviKljun, novaKrila, "grabljivica");
       orao.Ispis();

       /// testiranje klase Slavuj
       Slavuj slavuj = new Slavuj(noviKljun, novaKrila, "Muharice", "Afrika");
       slavuj.Ispis();
    }
}