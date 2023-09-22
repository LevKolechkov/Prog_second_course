using System;

namespace Lab
{
  class V
  {
    static void Main(string[] args)
    {
      int L; // длина бруска
      int a,b; // рёбра бруска

      int l; // длина цилиндра
      int r; // радиус цилиндра

      int volumeOfBlock; // объём бруска
      int volumeOfCylinder; // объём цилиндра
      
      /*
      * Объём бруска volumeOfBlock = L * a * b
      * Объём цилиндра равен volumeOfCylinder = l * π*r^2
      * 
      * Чтобы получить процент материала (perc), ушедшего в отходы необходмо volumeOfBlock / volumeOfCylinder * 100
      */

      // Пусть 
      L = 50;
      a, b = 20;

      l = 30;
      r = 10;

      // Тогда
      volumeOfBlock = L * a * b;
      volumeOfCylinder = l * Math.Pi * r * r;

      perc = volumeOfBlock / volumeOfCylinder * 100;

      console.writeline(volumeOfBlock, volumeOfCylinder, perc)
    }
  }
}