/**
 * Pink e Cérebro
 *
 * Desafio:
 * - Pink e Cérebro dividem um apartamento e estão juntos 
 * 24h por dia desde o começo da pandemia. Para passar o tempo, 
 * Pink cria problemas matemáticos para Cérebro resolver, o 
 * último deles foi uma lista de números com a seguinte pergunta: 
 * quantos números da lista são múltiplos de 2, 3, 4 e 5?
 * 
 * - Apesar de parecer simples, porém, quando a lista contém muitos 
 * números, Cérebro se confunde e acaba errando alguns cálculos.
 * 
 * - Ajude Cérebro a resolver o desadio de Pink.
 * 
 * Entrada:
 * - A primeira linha da entrada consiste em um inteiro N (1 ≤ N ≤1000), 
 * representando a quantidade de números na lista de Pink.
 * 
 * - A segunda linha contém N inteiros Li (1 ≤ Li ≤ 100), representando 
 * os números da lista de Pink.
 * 
 * Saída:
 * - Imprima a quantidade de números múltiplos de 2, 3, 4 e 5 presentes 
 * na lista. Observe a formatação da saída nos exemplos, pois ela deve 
 * ser seguida rigorosamente.
 */

let N = gets();
let List = gets().split(' ');
let rise = 0;

for (let multiply = 0; multiply <= 3; multiply ++){

    List.forEach(li => {
        if(li % (multiply + 2) == 0){
            rise ++ ;
        }
    })

    console.log(`${rise} Multiplo(s) de ${multiply + 2}`)
    rise = 0;
}  
  