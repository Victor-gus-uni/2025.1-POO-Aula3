namespace aula_03;

class Televisao
{   
    // o metodo construtor possui o mesmo nome da classe. Ele não possui retorno (nem mesmo o void)
    // Este metodo é executado sempre que uma instancia da classe é criada
    // Por padrão, o C# cria um metodo construtor publico vazio, mas podemos criar metodos construtores com outras visiblidades e recebendo parametros, se necessario.
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }
    // Get: permite que seja executado a leitura do valor atual da propriedade
    // Set: permite que seja atribuido um valor para a propriedade

    // As propriedades e metodos possuem modificadores de acesso
    //public: visivel a todos do projeto
    //internal: visivel somente no namespace
    //protected: visiveis somente na classe e nas classes que herdam
    //privated: visiveis somente na classe que foram criados 
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

}

