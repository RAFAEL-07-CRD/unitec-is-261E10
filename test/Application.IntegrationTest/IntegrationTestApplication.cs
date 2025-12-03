﻿using System;
using Xunit;
using Application;
namespace Application.IntegrationTest
{
public class IntegrationTestApplication
{
[Theory]
[InlineData(4, 2, 10, 80)]
[InlineData(10, 5, 2, 100)]
[InlineData(1, 1, 5, 5)]
[InlineData(5, 5, 4, 100)]
[InlineData(6, 3, 2, 36)]
[InlineData(20, 10, 1, 200)]
[InlineData(15, 5, 2, 150)]
[InlineData(2, 8, 5, 80)]
[InlineData(100, 1, 1, 100)]
[InlineData(0.5, 0.5, 10, 2.5)]
[InlineData(2.5, 2.5, 4, 25)]
[InlineData(12, 4, 2, 96)]
[InlineData(7, 7, 10, 490)]
[InlineData(50, 50, 2, 5000)]
[InlineData(3, 9, 3, 81)]
[InlineData(11, 2, 5, 110)]
[InlineData(1.2, 1.2, 10, 14.4)]
[InlineData(10, 0.1, 50, 50)]
[InlineData(8, 6, 0.5, 24)]
[InlineData(9, 3, 10, 270)]

public void TestVolumen(double lado1, double lado2, double altura, double volumen)
{
//| Arrange – Set up
double area = Figura261E10.Area(lado1, lado2);
//| Act – Perform
double resultado = Figura261E10.Volumen(area, altura);
//| Assert – Verify
Assert.Equal(volumen, resultado, precision:5);
}
}
}