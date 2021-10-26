using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<String> cuidades = new List<string>();
        cuidades.Add("Tokyo");
        cuidades.Add("London");
        cuidades.Add("Rome");
        cuidades.Add("Donlon");
        cuidades.Add("Kyoto");
        cuidades.Add("Paris");
        WriteLine( Juzgar(cuidades));
    }
    public static string Ordenar(string patata){
        return String.Concat(patata.ToLower().OrderBy(c => c));
    }
    public static string Juzgar(List<string> lCuidades)
    {
        List<String> resultado = new List<string>();
        string patata;
        for (var i = 0; i < lCuidades.Count; i++){
            patata = lCuidades[i];
            for(var j = i+1; j < lCuidades.Count; j++){
                if(Ordenar(lCuidades[i]).Equals(Ordenar(lCuidades[j]))){
                    patata = patata + ", " + lCuidades[j];
                    lCuidades.Remove(lCuidades[j]);
                    j--;
                }
            }
            resultado.Add(patata);
        }
        return Mostrar(resultado);
        
    }
    public static string Mostrar(List<string> patata){
        string salida = "";
        for (var i = 0; i < patata.Count; i++){
            salida = salida + "["+ patata[i] +"]";
        }
        return salida;
    }
}