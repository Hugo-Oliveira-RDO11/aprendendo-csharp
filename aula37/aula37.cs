//aqui aprendir qual e a orden da execução dos construtores, demorei muito tempo pra rodar, pois eu não sabia que era obrigadorio o nome da classe começa com maiusculo...
//triste ;-; 

using System;

public class Test{    
    public Test(){
        System.Console.WriteLine("base");
    }
}

public class Filho1:Test{
    public Filho1(){
        System.Console.WriteLine("filho1");
    }
}

public class Filho2:Filho1{
    public Filho2(){
        System.Console.WriteLine("filho2");
    }
}

class Aula37{
    static void Main(){
        Filho2 filho2=new Filho2();        

    }
}