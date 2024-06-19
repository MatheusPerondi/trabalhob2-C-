using System;
//using é usado para importar namespaces. É semelhante ao import em Java, onde você importa pacotes.

namespace Trabalhob2
//namespace é usado para organizar classes em grupos lógicos. É equivalente ao conceito de pacote em Java.
{
    public abstract class Product
    {
        //classes abstratas funcionam de maneira semelhante a java 

        protected String name;
        protected double cost;
      
        

        //Semelhante a um construtor em java, com algumas diferenças na sintaxe e no comportamento, tem diferença na chamada de construtores da classe base, utilizando 'base()'
        //enquanto em java utilizamos o 'super()', em c# possuimos construtores estaticos que são usados para inicializar dados estáticos da classe ou realizar operações que devem ocorrer apenas uma vez, 
        //quando a classe é carregada. E possuimos também construtores de copia, permitem criar uma instancia de uma classe com base nos valores de outra instancia da mesma classe
        //em java da para implementar metodos de copia que realizam a mesma funcionalidade, mas não ha suporte nativo para construtores de copia.
        public Product(String name, double cost)
        {
            this.name = name;
            this.cost = cost;
        }

        

        protected abstract double calculatePrice();
        protected abstract double calculateTransport();


        //em c#, a pratica comum é usar properties, que se comportam como metodos getters e setters, mas são acessadas como se fossem campos publicos, em a necessidade de chamar explicitamente métodos.
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Cost
        {
            get { return cost;}
            set { cost = value;}
        }

    }
}
