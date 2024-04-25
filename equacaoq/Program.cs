using System;

class QuadraticEquation{
    
    static float a,b,c;
    static string whoSign(float f){
        if(f >= 0){return "+";} else{return "-";}
    }
    
    private static void Main(string[] args){
        Console.Write("write respective values(separate by space):\nA | B | C\n"); var date = Console.ReadLine().Split(' ');
        a = float.Parse(date[0]); b = float.Parse(date[1]); c = float.Parse(date[2]);

        float delta = ((float)Math.Pow(b, 2) - 4 * a * c);

        Console.WriteLine($"the full equation is {whoSign(a)}{(float)Math.Abs(a)}x² {whoSign(b)}{(float)Math.Abs(b)}x {whoSign(c)}{(float)Math.Abs(c)}");

        if(delta > 0){
            float s1, s2;
            s1 = (-b - (float)Math.Sqrt(delta)) / (2 * a) ; s2 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"solutions 1 and 2 are respectively: {s1} and {s2}");
        } else if(delta == 0){
            float s1; s1 = (- b ) / 2 * a ;
            Console.WriteLine($"the only solution is: {s1}");
        } else {Console.WriteLine("ops... only complex solution...");}
    }
}
