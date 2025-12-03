double lado1 = 5;
double lado2 = 15;
double altura = 10;
double perimetro = Application.Figura261E10.Perimetro(lado1,lado2);
double area = Application.Figura261E10.Area(lado1, lado2);
double volumen = Application.Figura261E10.Volumen(area, altura);

Console.WriteLine($"El perímetro de la base de un Rectángulo de {lado1} y del {lado2}cm por lado es {perimetro}cm");
Console.WriteLine($"El área de la base de un Rectángulo de {lado1}cm por {lado2} es {area}cm");
Console.WriteLine($"El volumen de un Rectángulo con un área de la base de {area}cm2 y {altura}cm de altura es {volumen}cm3");
