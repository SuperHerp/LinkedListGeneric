using System;

interface print
{
    void print();
}

interface compare<T>{
    int compare(T ob2);
}

public class Schueler : IComparable, print, compare<Schueler>{
    private int SchuelerNr;
    private string Name;
    private string Telefon;

    public Schueler(int nr, string name, string tel){
        this.SchuelerNr = nr;
        this.Telefon = tel;
        this.Name = name;
    }

    public int compare(Schueler ob2)
    {
        if(this.SchuelerNr > ob2.SchuelerNr){
            return 1;
        }else if (this.SchuelerNr < ob2.SchuelerNr){
            return -1;
        }else{
            return 0;
        }
    }

    public int CompareTo(object obj)
    {
        return SchuelerNr.CompareTo(obj);
    }

    public string getName(){
        return this.Name;
    }

    public int getNr(){
        return this.SchuelerNr;
    }

    public string getTel(){
        return this.Telefon;
    }

    public void print(){
        string toPrint = "Nummer: " + this.getNr() + ", Name: " + this.getName() + ", Tel.: " + this.getTel();
        Console.WriteLine(toPrint);
    }

}