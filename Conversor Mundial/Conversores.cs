using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Conversores
    {
        public string[][]
            //monedas
            etiquetas = { new string[] { "Dolar Estadounidense","Colon Salvadoreño","Boliviano" , "Cordoba", "Colon Costarrisense", 
            "Dolar Beliceño", "Dolar Canadiense", "Euros", "Guarani", "Lempiras","Peso Mexicano", "Peso Uruguayo","Peso Colombiano",
            "Peso Filipino","Peso Cubano", "Quetzal", "Real Brasileño", "Real Irani", "Sol", "Yen" },

             //medidas de longitud
              new string [] {"Metro","Centimetro", "Pulgada", "Pie", "Yarda", "vara española","Kilometro", "Milla", "Nanometro","Milimetro","Micrometro",
              "Milla Nautica", "Hectometro", "Decametro", "pie", "lengua ","cadena", "milla romana",
              "Famn", "Decimetro" },

              //medidas de peso
              new string[] {"Kilogramos","Gramos","Miligramo","Microgramo","Libra","Onzas", "Tonelada", "Tonelada Larga",
              "Tonelada Corta", "Stone", "Teragramos", "Gigagramos", "Megagramos", "Nanogramos", "Picogramos", "Centigramos", "Decigramos",
              "Hectagramos", "Decagramos", "Tonelada Metrica"},

              //medidas de Volumen 
            new string[] { "Pulgada Cubica", "Pie Cubico", "Cucharadita Imperial", "Cucharada Imperial", "Onza liquida Imperial",
            "Taza Imperial", "Pinta Imperial", "Cuarto Imperial", "Galon Imperial","Mililitro" ,  "Litro", "Metro Cubico", "Cucharadita estadounidense",
            "Cucharada estadounidense", "Onza liquida estadounidense", "Taza americana oficial", "Pinta estadounidense", "Cuarto estadounidense",
            "Galon estadounidense", "Barril"},

             //medidas de Almacenamiento
            new string[] {"Mebibytes", "Megabits", "Megabytes", "Petabits", "Petabytes", "Qwords", "Tebibytes", "Terabits", "Terabytes",
                "Words", "Nibbles","Gigabits", "Gigabytes","Characters", "Gibibytes",  "Kibibytes", "Kilobits", "Kilobytes","Bits", "Bytes",},

                     };
       
        double[][] valores = {
          
                 //VALORES DE MONEDAS
              new double[]{1,8.77,6.95,33.91, 568.78,2.03,1.33,0.93,6559.60,24.81,18.69,38.22,3430.66,50.99,1.01,7.70,4.39,42429.75,3.41,110.97},

                 //VALORES DE LONGITUDES
              new double[]{1,100,39.3701,3.280841667,1.093613889 ,0.39912915657,0.0010000005401,0.00062137152784,1000000540.1, 1000.0005401,
               1000000.5401, 0.00053995709509,0.010000005401,0.10000005401,3.280841667,0.00020712384261,0.049709722226,0.00067576553387,
              0.5613775487, 10.000005401},

                //VALORES DE PESO
               new double[]{ 1,1000,1000000,1e+9, 2.20462262185, 35.2739619496, 0.001000000000000555, 0.00098420652761160680455, 0.0011023113109249994216,
                0.15747304441785706097,8.9285714286e-10, 8.9285714286e-7, 0.00089285714286, 892857142860, 892857142860000,89285.714286,8928.5714286,
               8.9285714286,89.285714286, 0.00089285714286},

              //VALORES DE VOLUMEN
               new double[]{1,0.000578704, 2.7683715885163,0.922790529557397488, 0.57674431927839631129, 0.057674437002480656578, 0.02883721596391981834,
               0.01441860798195990917,0.0036046519954899772925, 16.387072390177031878, 0.0163870723901770321,1.638707239017703093e-5, 3.324678101932478036,
               1.1082256756363813022, 0.55411283781819065108,0.068279468292404291163,0.034632052363636915693, 0.017316026181818457846, 0.0043290065454546144616,
               0.0001030715811274 },

               //VALORES DE ALMACENAMIENTO
               new double[]{1,8 ,1.048576, 7.451E-9, 1.049E-9, 131125 , 9.5406E-7,7.63248E-6,1.049E-6, 524500, 2098000,0.0078, 0.001,1000000,0.0009,943.7184,
               7549.7472,966.3676416,7730941.1328,966367.6416},
        };

         
    public double convertir (int De, int A, double cantidad, int opcion)
{

            return Math.Round(valores[opcion][A] / valores[opcion][De] * cantidad, 2);
        }

    }
       

    }






