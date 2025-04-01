double basee;
double altura; 
double area; 

Console.Clear();

Console.Write ("Base..: ");
basee = Convert.ToDouble(Console.ReadLine());

Console.Write ("Altura: ");
altura = Convert.ToDouble(Console.ReadLine());

area = basee * altura / 2;

Console.WriteLine (@$"
Área..: {area}");