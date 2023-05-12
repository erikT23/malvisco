
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Ingrese el número de paquetes a empacar:");
    int paquetes = Convert.ToInt32(Console.ReadLine());

    int cajas = paquetes / 6;
    int sobrantes = paquetes % 6;

    Console.WriteLine($"Se necesitan {cajas} cajas para empacar los {paquetes} paquetes.");
    if (sobrantes > 0) {
      Console.WriteLine($"Sobraron {sobrantes} paquetes sin empacar.");
    }
  }
}