using System;


class challange3 {

  static void Main() {

    string[] entry = Console.ReadLine().Split(" ");

    int N = int.Parse(entry[0]);

    int D = int.Parse(entry[1]);

    string date = "";

    int num = 0;

    bool find = false;

     

    for (int i=0; i<D; i++){

     num = 0;

     string[] data = Console.ReadLine().Split(" ");

     date = data[0];

     for (int p=1; p<N+1; p++){

      num += int.Parse( data[p] );

     } //for p

     find = ( num == N);

     if (find) { break; }

    } //for i

     

    if (find) { Console.Write(date); }

    else { Console.Write("Pizza antes de FdA"); }

  }

}


/*

Desafio

Está chegando o final de ano e as tradicionais celebrações de amigo secreto, você e seus N-1 amigos decidiram combinar algum dia para ir a uma pizzaria.

Neste momento está sendo escolhida a data do evento. Para que todas as pessoas possam participar, foi decidido que o encontro na pizzaria ocorrerá em um data tal que todas as N pessoas podem comparecer à pizzaria nesta data. Portanto, nem toda data pode ser escolhida, pois algumas pessoas podem ter outros compromissos já marcados em alguns dias.

Dada a lista de datas consideradas para o evento e a informações de quais pessoas podem comparecer em quais datas, determine se o evento poderá ocorrer e, em caso positivo, sua data. Caso mais de uma data seja possível, o evento deve ocorrer o mais cedo possível.
Entrada

A entrada contém vários casos de teste. A primeira linha de cada caso contém os inteiros N e D (1 ≤ N, D ≤ 50), o número de pessoas e o número de datas consideradas, respectivamente. As pessoas são numeradas de 1 a N. As próximas D linhas descrevem uma data considerada. Cada linha começa com a data na forma dia∕mes∕ano. A linha é seguida de N inteiros p1,p2,...,pN. O inteiro pi é 1 se a pessoa i pode comparecer na data considerada, ou 0 caso contrário. É garantido que as datas são sempre válidas, e não há zeros à esquerda. Além disso, as datas são dadas em ordem, do dia mais cedo para o dia mais tarde.
Saída

Para cada caso de teste, imprima uma linha contendo a data que o evento deve ocorrer, na forma dia∕mes∕ano, de maneira idêntica à da entrada. Caso não seja possível realizar o evento, imprima “Pizza antes de FdA” (sem aspas).

*/

/*using System;
class Desafio {
    static void Main() {
            string[] numeroDePessoasEDatasString = Console.ReadLine().Split(' ');
            int numeroDePessoas = int.Parse(numeroDePessoasEDatasString[0]);
            int numeroDeDatas = int.Parse(numeroDePessoasEDatasString[1]);

            string[] dataInput = new string[numeroDeDatas];
            int[] presencasInput = new int[numeroDePessoas];
            int[] contadorDePresenca = new int[numeroDePessoas];

            for (int i=0; i<numeroDeDatas; i++){
            string[] datasEPresencasString  = Console.ReadLine().Split(' ');

            //DATA
            dataInput[i] = datasEPresencasString[0];

            //PRESENÇA
            for (int j=0; j<numeroDePessoas; j++){
            presencasInput[j] = int.Parse(datasEPresencasString[j+1]);
            if (presencasInput[j] == 1){
                contadorDePresenca[i]+=1;
                } 
            }
        }
        int antesDoFda = 0;
        for(int x=0; x<numeroDePessoas; x++){
        if (contadorDePresenca[x] == numeroDePessoas){
        Console.WriteLine(dataInput[x]);
        break;
        }
        else if (contadorDePresenca[x] < numeroDePessoas){
        antesDoFda += 1;
            }
        }
        if (antesDoFda == numeroDePessoas){
        Console.WriteLine("Pizza antes de FdA");
        }
    }
  }*/