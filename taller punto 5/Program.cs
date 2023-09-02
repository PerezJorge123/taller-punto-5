// Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

public class TallerPunto5
{
    static void Main(string[] args)
    {
       double cateto1, cateto2, hipotenusa;

        Console.Write("Ingresar cateto 1:");
        cateto1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresar cateto 2:");
        cateto2 = double.Parse(Console.ReadLine());

        hipotenusa = Math.Sqrt (Math.Pow (cateto1,2) + Math.Pow (cateto2,2));

        Console.Write("la hipotenusa del triangulo es:" + hipotenusa);
    }


}
