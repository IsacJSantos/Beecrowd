using System; 

class URI {

    static void Main(string[] args) { 

        var input1 = Console.ReadLine().Split(' ');
        var input2 = Console.ReadLine().Split(' ');
    
        Piece p1 = new Piece(){
            cod = int.Parse(input1[0]),
            qty = int.Parse(input1[1]),
            value = float.Parse(input1[2])
        };
        Piece p2 = new Piece(){
            cod = int.Parse(input2[0]),
            qty = int.Parse(input2[1]),
            value = float.Parse(input2[2])
        };
        Calc(p1, p2);
    }

    static void Calc(Piece a, Piece b){
        float totalPrice = (a.qty * a.value) + (b.qty * b.value);
        Console.WriteLine($"VALOR A PAGAR: R$ {totalPrice.ToString("F2")}");
    }

}
public struct Piece{
    public int cod;
    public int qty;
    public float value;
}