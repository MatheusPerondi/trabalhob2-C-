using System;

namespace Trabalhob2;

public class Agricultural : Product
{
    // usado para declarar campos que só podem ser inicializados uma vez, depois de inicializado, o valor não pode ser alterado. Isso é semelhante ao uso de final em Java 
    protected static readonly double PROFIT_LOW = 1.08;
    protected static readonly double PROFIT_MID = 1.05;
    protected static readonly double PROFIT_HIGH = 1.035;

    protected double kg;

    //em java para chamarmos o construtor da classe base utilizamos o 'super()', em c# utilizamos 'base()' e em seguida passamos os parametros, os parametros passados devem
    //corresponder aos parametros esperados pelo construtor da classe base.
    //isso é util quando voce deseja inicializar tanto os campos da classe derivada quanto os campos da classe base ao criar uma instancia da classe derivada
    public Agricultural(String name, double cost, double kg) : base(name, cost)
    {
        this.kg = kg;
    }

    //em c# utilizamos override para sobrescrever metodos da classe base, semelhante ao java
    protected override double calculatePrice()
    {
        if (kg <= 100)
        {
            return (cost * PROFIT_LOW) + calculateTransport();
        }
        else if (kg <= 200)
        {
            return (cost * PROFIT_MID) + calculateTransport();
        }
        else
        {
            return (cost * PROFIT_HIGH) + calculateTransport();
        }

        
    }

    protected override double calculateTransport()
    {
        if (kg <= 100)
        {
            return (0.10 * kg);
        }
        else if (kg <= 200)
        {
            return (0.08 * kg);
        }
        else
        {
            return (0.05 * kg);
        }
    }


    public String Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public double Kg
    {
        get { return kg; }
        set { kg = value; }
    }

    //O método ToString é utilizado para fornecer uma representação em string de um objeto
    //utilizamos $"" para interpolar valores diretamente na string, o que torna o código mais legível.
    ////em vez de concatenar manualmente diferentes partes de uma string, a interpolação permite combinar valores variáveis diretamente na string de uma maneira mais legível e intuitiva.
    //As expressões dentro das chaves são avaliadas e os resultados são inseridos na string resultante.
    public override string ToString()
    {
        return $"Agricultural product: Name={name}, Cost={cost:C}, Kg={kg}, Price={calculatePrice():C}";
    }


}
