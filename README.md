# Algoritmos 
Essa é minha primeira lista de exercicios de logica e algoritmos que foi elaborada com base no aprendizado em aula de algoritmos e  logica de programação, ministradas pelo professor Maikel Linares, na Etec Dra. Ruth Cardoso.

LISTA 01:
Exercícios de Estrutura Seqüencial


1. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) de uma
sala, sendo que os comprimentos das paredes (L e C) são fornecidos pelo usuário. Apresente a área
depois de calculada.
2. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular a área (AREA) e o
perímetro (P) de uma sala, sendo que os comprimentos (L e C) são fornecidos pelo usuário. Apresente
a área e o perímetro depois de calculados.
3. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor monetário do
desconto (D), sendo que o preço do produto (PR) é fornecido pelo usuário e o desconto é de 5%.
Apresentar o valor do desconto.
4. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular quanto será pago por um
produto (PAG), sendo que o preço do produto (PR) e o desconto (D) são fornecidos pelo usuário.
Apresentar o valor a ser pago pelo produto.
5. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular qual foi a porcentagem de
desconto dada em um determinado produto (DESC), sabendo-se o preço original do produto (PRECO)
e o preço que foi cobrado por ele depois do desconto (PRECOF).
6. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule a idade de uma pessoa,
sendo que o ano atual (AA) e o ano do nascimento da pessoa (AN) são fornecidos pelo usuário.
(considere que a pessoa já fez aniversário nesse ano). Apresentar a idade da pessoa depois de
calculada.
7. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o volume de uma esfera
(VOL). O raio (R) da esfera será fornecido pelo usuário. Obs: VOL = 3.14*R
2
(apresentar o volume da

esfera)
8. Faça o algoritmo (diagrama de blocos e português estruturado) para calcular o valor a ser pago
pelo período de estacionamento do automóvel (PAG). O usuário entra com os seguintes dados:
hora (HE) e minuto (ME) de entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este
estacionamento cobra R$ 4,00, mas calcula as frações de hora também. Por exemplo, se a
pessoa ficar 1 hora e quinze minutos, pagará R$ 5,00 (R$ 4,00 pela hora e R$ 1,00 pelos quinze
minutos).
9. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule o valor em Reais
(VAL_REAL), correspondente aos dólares que um turista possui no cofre do hotel. O programa deve
solicitar os seguintes dados: Quantidade de dólares guardados no cofre (VAL_DOLAR) e cotação do
dólar naquele dia (COT).

2
10. Faça o algoritmo (diagrama de blocos e português estruturado) que receba dois valores inteiros nas
variáveis A e B. O programa deve trocar os valores entre as variáveis (ou seja, ao término do programa
a variável A deve ter o valor inicial de B e vice-versa). Apresentar as duas variáveis o final.
11. Faça o algoritmo (diagrama de blocos e português estruturado) que calcule a quantidade de tijolos
iguais (QTD) necessários para construir uma determinada parede. São dados de entrada do programa:
dimensões do tijolo (comprimento – CT e largura – LT) e dimensões da parede a ser construída
(comprimento – CP e largura – LP).
12. Baseado no algoritmo abaixo, o que é apresentado como saída (em tela ou papel) desse programa?
programa EXERC_12
var
A, B, C, D: real
início
A2
B4
C (A+B)*B
DC*B/(A*A)
AD/(C+B)
BB+A
escreva “A variavel A vale:”, A
escreva “A variavel B vale:”, B
escreva “A variavel C vale:”, C
escreva “A variavel D vale:”, D
fim
13. No algoritmo abaixo, o que está errado?
programa EXERC_13
var
A, B, C, RESULTADO: inteiro
início
leia A
leia B
RASCUNHO(A-B)*A/3
RESULTADOB-100
escreva “O resultado da operação foi:”, RESULTADO
fim

LISTA DE EXERCÍCIOS 02 (ESTRUTURA DE DECISÃO):

1. Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior
que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário não
exiba mensagem nenhuma.
2. Construa um algoritmo que leia o valor de uma conta de luz (CL) e, caso o valor seja maior
que R$ 50,00 apresente a mensagem: “Você está gastando muito”. Caso contrário exiba a
mensagem: “Seu gasto foi normal”.
3. Construa um algoritmo que, tendo como dados de entrada a altura (H) e o sexo (S) de
uma pessoa calcule e apresente seu peso ideal utilizando as seguintes fórmulas:
Para homens: Peso ideal (P) = (72,7 * H) – 58
Para mulheres: Peso ideal (P) = (62,1 * H) – 44,7
4. Construa um algoritmo que determine quanto será gasto para encher o tanque de um carro
(VG), sabendo-se que o preço da gasolina é de R$ 1,80 e o preço do álcool é de R$ 1,00. O
usuário fornecerá os seguintes dados: Tipo de carro (TC) (G – gasolina ou A – álcool) e
Capacidade do tanque (CT), em litros.
5. Construa um algoritmo que leia um número inteiro (positivo ou negativo) e apresente o seu
módulo (número sem sinal).
6. Construa um algoritmo que leia o preço de um produto (P) e apresente a mensagem: “Em
promoção”, caso o preço seja maior ou igual a R$ 50,00 e menor ou igual a R$ 100,00.
Caso contrário, deve apresentar a mensagem: “Preço Normal”.
7. Construa um algoritmo que, recebendo os valores de vendas do mês de determinado
vendedor (VM) e o nome do mesmo (NOME), apresente o nome, quando o valor da venda
estiver entre R$ 10000,00 e R$ 50000,00 (inclusive).
8. Construa um algoritmo que apresente o nome e o salário dos funcionários, de acordo com
os seguintes critérios:
 Salários que sejam maiores ou iguais a R$ 1000,00 e menores ou iguais a R$ 1500,00
 Funcionários pertencentes aos departamentos de produção ou engenharia.
Obs: Os departamentos são reconhecidos pelas letras (P) Produção e (E) Engenharia
São fornecidos o nome do funcionário (NF), o seu salário (SAL) e o departamento onde
trabalha (DEP).
9. Construa um algoritmo que calcule o novo salário (SAL_NOVO) de um funcionário.
Considere que o funcionário deverá receber um reajuste de 15% caso seu salário (SAL) seja
menor que 500. Se o salário for maior ou igual a 500, mas menor ou igual a 1000, o
reajuste deve ser de 10%. Caso o salário seja maior que 1000, o reajuste deve ser de 5%.

2
10. Construa um algoritmo que leia dois números (A e B). Caso A seja igual a B, apresentar a
soma dos dois. Caso um seja maior que o outro, apresentar a diferença entre os dois
números (sempre lembrando que a diferença entre dois números é SEMPRE positiva).
11. Construa um algoritmo que leia o código de um livro (CL) e apresente a categoria do livro,
conforme a tabela abaixo:

Código do Livro (CL) Categoria
A Ficção
B Não-Ficção
Qualquer outro código Inválido

12. Construa um algoritmo que receba a leitura do termômetro (T). Caso a temperatura esteja
abaixo de 100oC, apresentar a mensagem de que a temperatura está muito baixa. Caso a
temperatura esteja entre 100oC e 200oC (inclusive), apresentar a mensagem de que a
temperatura está baixa. Caso a temperatura esteja acima de 200oC e inferior a 500oC,
apresentar a mensagem de que a temperatura está normal. Caso contrário, apresentar a
mensagem de que a temperatura está muito alta.
13. Construa um algoritmo que leia a quantidade de dinheiro existente no caixa de uma
empresa (CAIXA), a quantidade de produtos a ser comprada (QTD) e o preço de cada
unidade (PR). Caso o valor total da compra seja superior a 80% do valor em caixa, a
compra deve ser feita a prazo (3x), com juros de 10% sobre o valor total. Caso contrário, a
compra deverá ser realizada a vista, onde a empresa receberá 5% de desconto. Apresentar
a forma de pagamento escolhida e o valor a ser pago (total a vista ou total a prazo),
dependendo da escolha realizada pelo programa.
14. Construa um algoritmo que leia as informações de: horas trabalhadas (HT), valor da hora
trabalhada (VH). Calcule e apresente o salário líquido do empregado, baseado nas tabelas
abaixo.
OBS: Salário Líquido = Salário Bruto – INSS – Imposto de Renda
a) Salário Bruto = Horas trabalhadas * Valor da hora trabalhada
b) INSS = 11% do salário líquido
c) Imposto de Renda  após descontar o INSS usar esse valor e ler a alíquota do imposto
de renda e parcela a deduzir na tabela abaixo

3

Salário Bruto – INSS Alíquota Valor a Deduzir
Até $1.257,12 Isento (0%)
De $1.257,13 até $2.512,08 15% $188,57
Mais que $2.512,08 27,5% $502,58
OBS: Imposto de Renda = Alíquota * (Salário Bruto – INSS) – Valor a Deduzir
15. Repita o exercício 14, só que agora, a porcentagem de desconto de INSS não é mais fixa. O
desconto acontece de acordo com a tabela abaixo:

Salário Bruto Alíquota
Até $800,45 7,65%
De $800,46 até $900,00 8,65%
De $900,01 até $1.334,07 9,00%
De $1.334,08 até $2.668,15 11,00%

OBS: Para Salário Bruto acima de $2.668,15 o valor de desconto é fixo e vale $293,50
16. Construa um algoritmo que calcule e apresente quanto deve ser pago por um produto
considerando a leitura do preço de etiqueta (PE) e o código da condição de pagamento
(CP). Utilize para os cálculos a tabela de condições de pagamento a seguir:
Código da condição de pagamento Condição de pagamento

1 À vista em dinheiro ou cheque, com 10% de desconto
2 À vista com cartão de crédito, com 5% de desconto
3 Em 2 vezes, preço normal de etiqueta sem juros
4 Em 3 vezes, preço de etiqueta com acréscimo de 10%
17. Construa um algoritmo que tendo como dados de entrada o preço de um produto (PR) e
seu código de origem (CO), apresente o preço e a sua procedência, de acordo com a tabela
abaixo:

4

Código de Origem (CO) Procedência
1 Sul
2 Sudeste
3 Centro-Oeste
4 Norte
5 Nordeste

18. Construa um algoritmo que leia o ano de nascimento de uma pessoa (AN) e mostre a sua
idade e, também verifique e mostre se essa pessoa já tem idade para votar (16 anos ou
mais) e se já pode conseguir a sua carteira de habilitação (18 anos ou mais).
19. Construa um algoritmo que calcule e apresente a idade REAL de uma pessoa. Será
fornecido pelo usuário:
DN – dia do nascimento DH – dia da data de hoje
MN – mês do nascimento MH – mês da data de hoje
AN – ano do nascimento AH – ano da data de hoje
20. Construa um algoritmo que, dados os comprimentos dos três lados (A, B e C) de um
triângulo, verifique o tipo de triângulo formado. Apresentar qual é o tipo. Sabe-se que:
 Triângulo do tipo Eqüilátero – possui os três lados iguais
 Triangulo do tipo Isósceles – possui dois lados iguais
 Triângulo do tipo Escaleno – possui os três lados diferentes
21. Construa um algoritmo que, dada a idade de um nadador (ID), classifique-o em uma das
seguintes categorias e apresente a categoria:

Idade (ID) Categoria
5 até 7 anos Infantil A
8 até 10 anos Infantil B
11 até 13 anos Juvenil A
14 até 17 anos Juvenil B
Acima de 18 anos Adulto

22. Construa um algoritmo que leia o código de um determinado produto (CP) e mostre a sua
classificação, utilizando a seguinte tabela:

5

Código do Produto (CP) Classificação
1 Alimento não perecível
2, 3 ou 4 Alimento perecível
5 ou 6 Vestuário
7 Higiene Pessoal
8 ou 9 Limpeza e Utensílios Domésticos
Qualquer outro código Inválido

23. Construa um algoritmo que indique o que o motorista deve fazer de acordo com a cor do
semáforo (CS) e distância do cruzamento (DC) fornecida pelo usuário. As condições são:
 (V) Vermelho = Parar
 (A) Amarelo = se a distância do cruzamento for menor que 5 metros = Passar com

cuidado
= se a distância do cruzamento for maior ou igual a 5 metros = Parar

 (D) Verde = Passar
24. Construa um algoritmo para calcular o valor a ser pago pelo período de estacionamento do
automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de
entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra hora
cheia, ou seja, se passar um minuto ele cobra a hora inteira. O valor da hora é R$ 4,00.
25. Construa um algoritmo para calcular o valor a ser pago pelo período de estacionamento do
automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de
entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra hora
cheia, ou seja, se passar um minuto ele cobra a hora inteira. O valor cobrado pelo
estacionamento é:
o R$ 4,00 para 1 hora de estacionamento
o R$ 6,00 para 2 horas de estacionamento
o R$ 1,00 por hora adicional (acima de 2 horas)

LISTA DE EXERCÍCIOS 03 (ESTRUTURA DE REPETIÇÃO):

1. Construa um programa que apresente o peso total que será carregado por um caminhão.
Sabe-se que esse caminhão carrega 25 caixas, com pesos diferentes. Será entrada do
programa o peso (P) de cada uma das caixas.
2. Construa um programa que leia a quantidade (Q) e o preço (PR) de 45 produtos diferentes,
comprados por uma empresa, e apresente o total gasto por ela.
3. Construa um programa que leia o número de horas trabalhadas diárias (NH) de um funcionário
por um período de 30 dias (ele trabalhou todos os 30 dias) e apresente o total de horas
trabalhadas por ele nesse período.
4. Construa um programa que leia o número de horas trabalhadas diárias (NH) de um funcionário
por um período de 30 dias (ele trabalhou todos os 30 dias) e apresente o salário bruto
recebido por ele nesse período, sabendo que o valor do salário é R$ 10,00/hora trabalhada.
5. A conversão de graus Fahrenheit para Celsius é obtida pela fórmula C=5/9(F-32). Construa um
programa que calcule e apresente TODAS as temperaturas (em Celsius) correspondentes
aquelas em Fahrenheit de 1 até 50, ou seja, para cada temperatura em Fahrenheit, variando
de 1 até 50, calcular e apresentar uma temperatura em Celsius.
OBS: A fórmula apresentada no enunciado é uma representação matemática e não o modo
como deve ser escrita no seu programa.
6. Construa um programa que apresente o valor de H, sendo H calculado por:
H = 1 + 2 + 3 + 4 + ... + N
O valor de N será apresentado pelo usuário.
7. Construa um programa que calcule N! (fatorial de N), sendo que o valor de N (inteiro) é
fornecido pelo usuário. Sabe-se que:
N! = 1 x 2 x 3 x 4 x .... x N
OBS: 0! = 1 (fatorial do número zero é igual a 1 por definição).
Além disso, não deve ser permitido que seja calculado o fatorial de número negativo,
pois isso não existe.

8. Construa um programa que leia o conjunto de 20 números inteiros e mostre qual foi o maior
valor fornecido.
9. Construa um programa que leia o conjunto de 20 números inteiros e mostre qual foi o maior e
o menor valor fornecido.
10. Construa um programa que leia a quantidade (Q) e o preço (PR) de vários produtos diferentes,
comprados por uma empresa, e apresente o total gasto por ela. O final da lista de produtos
deverá ser indicado pelo usuário (escolha a maneira que preferir).

OBS: Não se esqueça de validar a entrada dos valores, pois não são aceitas quantidades
negativas, nem preços negativos.
11. Construa um programa que leia vários números inteiros e positivos, calculando ao final da
seqüência a soma e a média desses números. A seqüência termina quando o usuário entrar
com um valor negativo (esse valor não deve fazer parte de nenhum dos cálculos).
12. Construa um programa que leia vários números inteiros e mostre qual foi o maior valor
fornecido. O final da lista de produtos será indicado quando o usuário entrar com um valor
negativo (esse valor não deve fazer parte da comparação de valores).
13. Construa um programa que leia vários números inteiros e mostre qual foi o menor valor
fornecido. Para cada valor digitado, deve ser solicitado ao usuário que ele digite se ele deseja
continuar entrando com valores.
OBS: Não se esqueça de validar a resposta do usuário, pois ele só pode responder “S” ou “N”.
14. Construa um programa que leia vários números inteiros e mostre qual foi o maior e o menor
valor fornecido. Para cada valor digitado, deve ser solicitado ao usuário que ele digite se ele
deseja continuar entrando com valores.
OBS: Não se esqueça de validar a resposta do usuário, pois ele só pode responder “S” ou “N”.
15. Construa um programa que leia um número e indique se ele é par ou impar. O programa só
deve levar em consideração valores positivos.
16. Anacleto tem 1,50m e cresce 2 centímetros por ano, enquanto Felisberto tem 1,10 e cresce 3
centímetros por ano. Construa um programa que calcule e apresente quantos anos serão
necessários para que Felisberto seja maior que Anacleto.
17. Construa um programa que calcule a área total de uma residência (sala, cozinha, quartos, etc.,
sendo todos eles retangulares). O usuário deverá entrar com a largura (L) e o comprimento
(C) de cada cômodo da casa. Em seguida deverá ser apresentada uma pergunta, solicitando a
confirmação do usuário para continuar com a entrada de dados (a confirmação será dada
quando o usuário entrar com “S”). Caso ele entre com o valor “N”. Deverá ser apresentada a
área total da casa.
OBS: Não se esqueça de validar a entrada da resposta do usuário, que só pode aceitar os
caracteres “S” ou “N”.
18. Construa um programa que apresente a tabuada de um número N. O valor de N será
apresentado pelo usuário.
19. Em um cinema, certo dia, cada espectador respondeu a um questionário, que perguntava a
sua idade (ID) e a opinião em relação ao filme (OP), seguindo os seguintes critérios:

Opinião Significado
A Ótimo

B Bom
C Regular
D Ruim
E Péssimo

A entrada de dados sobre a opinião deve ser validada.
O final da pesquisa será indicado quando a idade do usuário for informada como negativa
(idade inexistente).
Construa um programa que, lendo esses dados, calcule e apresente:
 Quantidade de pessoas que respondeu a pesquisa
 Média de idade das pessoas que responderam a pesquisa
 Porcentagem de cada uma das respostas
20. Construa um programa que leia as informações de: horas trabalhadas (HT), valor da hora
trabalhada (VH). Calcule e apresente o salário líquido dos empregados da empresa, baseado
nas tabelas abaixo.
OBS: Salário Líquido = Salário Bruto – INSS – Imposto de Renda
a) INSS = 11% do salário bruto
b) Imposto de Renda  após descontar o INSS usar esse valor e ler a alíquota do imposto de
renda na tabela abaixo

Salário Bruto – INSS Alíquota Deduzir
Até $900 Isento
De $900 até $1800 15% $135
Mais que $1800 27,5% $360

Não é conhecido o número de funcionários da empresa. Ao final de cada cálculo, o programa
deve perguntar se a pessoa deseja calcular o salário de outro funcionário. Caso a resposta
seja negativa, o programa deve parar.
OBS: Não se esqueça de validar a entrada da resposta do usuário, que só pode aceitar os
caracteres “S” ou “N”.
21. Construa um programa que calcule e apresente o total da compra realizada pelo cliente em
uma loja. São fornecidos para o programa, o preço da etiqueta (PE) de cada um dos produtos
comprados e, com a compra encerrada, a condição de pagamento escolhida pelo cliente (CP).
Utilize para os cálculos a tabela de condições de pagamento a seguir:
Código da condição de pagamento Condição de pagamento

1 À vista em dinheiro ou cheque, com 10% de desconto
2 À vista com cartão de crédito, com 5% de desconto

3 Em 2 vezes, preço normal de etiqueta sem juros
4 Em 3 vezes, preço de etiqueta com acréscimo de 10%
Uma compra pode ser composta por mais do que um produto, portanto, deve ser indicado
para o programa quando a compra deve ser encerrada (escolha a forma que desejar).
OBS: Não esqueça de validar a entrada do código da condição de pagamento.
22. Construa um programa que indique qual a melhor forma de pagamento para a compra
realizada por uma empresa. Essa compra será composta por vários produtos e a entrada de
dados deve parar quando o usuário digitar como quantidade um valor negativo. O programa
deve ler a quantidade de dinheiro existente no caixa de uma empresa (CAIXA), a quantidade
de cada item comprado (QTD) e o preço de cada produto (PR).
Caso o valor total da compra seja superior a 80% do valor em caixa, a compra deve ser feita
a prazo (3x), com juros de 10% sobre o valor total. Caso contrário, a compra deverá ser
realizada a vista, onde a empresa receberá 5% de desconto. Apresentar a forma de
pagamento escolhida e o valor a ser pago (total a vista ou total a prazo), dependendo da
escolha realizada pelo programa.
OBS: Não se esqueça de validar a entrada dos valores, pois não são aceitos preços negativos.
23. Construa um algoritmo que calcule o novo salário (SAL_NOVO) para cada um dos funcionários
da empresa. Considere que o funcionário deverá receber um reajuste de 15% caso seu salário
(SAL) seja menor que 500. Se o salário for maior ou igual a 500, mas menor ou igual a 1000, o
reajuste deve ser de 10%. Caso o salário seja maior que 1000, o reajuste deve ser de 5%.
O programa deve parar quando for digitado um salário (SAL) com valor negativo, ou seja,
inválido.
Além disso, ao final, o programa deve apresentar quanto será gasto a mais pela empresa com
esses aumentos.
24. Construa um algoritmo que calcule e apresente a idade REAL de uma pessoa. Será fornecido
pelo usuário:
DN – dia do nascimento DH – dia da data de hoje
MN – mês do nascimento MH – mês da data de hoje
AN – ano do nascimento AH – ano da data de hoje
OBS: Lembre-se de validar e entrada dos valores dos meses (1 até 12 apenas) e dos dias (1
até 31 apenas).
25. Construa um algoritmo para calcular o valor a ser pago pelo período de estacionamento do
automóvel (PAG). O usuário entra com os seguintes dados: hora (HE) e minuto (ME) de
entrada, hora (HS) e minuto (MS) de saída. Sabe-se que este estacionamento cobra hora

cheia, ou seja, se passar um minuto ele cobra a hora inteira. O valor cobrado pelo
estacionamento é:
o R$ 4,00 para 1 hora de estacionamento
o R$ 6,00 para 2 horas de estacionamento
o R$ 1,00 por hora adicional (acima de 2 horas)
OBS: Lembre-se de validar e entrada dos valores das horas (0 a 23) e dos minutos (0 a 59).

LISTA 04: VETORES E MATRIZES:
Lista de Exercícios
Estrutura de Repetição
1 – Faça um algoritmo que receba a idade e o peso de 7 pessoas, calcule e mostre:
• A quantidade de pessoas com mais de 90 quilos;
• A média das idades das 7 pessoas.
2 – Faça um algoritmo que receba 10 números, calcule e mostre a quantidade de números entre 30 e
90.
3 – Faça um algoritmo que receba 10 idades, pesos e alturas, calcule e mostre:
• A média das idades das 10 pessoas;
• A quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50;
• A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de
1.90.
4 – Faça um algoritmo que receba a idade e o sexo de 12 pessoas, calcule e mostre:
• A idade média do grupo;
• A idade média das mulheres;
• A idade média dos homens.
5 – Faça um algoritmo que calcule a soma dos primeiros 50 números pares. Este algoritmo não recebe
valor do teclado. Os primeiros número pares são: 2, 4, 6, ...
6 – Escreva um algoritmo que leia um número e mostre seu inteiro.
7 – Escreva um algoritmo que leia dois números e mostre o produto desses números.
8 – Fazer um algoritmo para ler dois números e mostrar o maior deles.
9 – Faça um algoritmo que leia o nome e as idades de duas pessoas e mostre a soma das idades.
10 – Repita o exercício anterior, porém, mostrando a frase abaixo, substituindo as lacunas pelas
informações obtidas no sistema. A soma das idades de XXXXX e XXXXX é XXXXX onde cada XXXXX
corresponde aos nomes e a soma das idades.
11 – Escreva um algoritmo que leia dois números que deverão ser colocados, respectivamente, nas
variáveis VA e VB. O algoritmo deve, então, trocar os valores de VA por VB e vice-versa e mostrar o
conteúdo destas variáveis.
12 – Faça um algoritmo que leia valores para as variáveis A, B e C e mostre o resultado da seguinte
expressão: ( A B ) *C
13 – Faça um algoritmo que mostre o resultado da expressão abaixo: (( x 5) *y) z Obs: Ler valores
para as variáveis x, y e z.

Lista de Exercícios
Estrutura de Repetição

14 – Fazer um algoritmo para ler duas notas, os pesos de cada nota e mostrar a média ponderada.
(nota 1 *peso da nota 1) +(nota 2 *peso da nota 2) Cálculo da Média Ponderada =soma dos pesos
15 – Escrever um algoritmo para ler uma temperatura em Fahrenheit e apresentá-la convertida em
graus Centígrados. (Fahrenheit 32) x 5 Fórmula: Centígrados =9
16 – Maria quer saber quantos litros de gasolina precisa colocar em seu carro e quanto vai gastar para
fazer uma viagem até a casa de sua irmã. Dados extras: Distância da casa de Maria até sua irmã :520
km Seu carro consome um litro a cada 12 Km rodado. Ela abastece sempre no mesmo posto, onde o
preço da gasolina é R$ 1,50 o litro.
18 – Escreva um algoritmo para criar um programa de ajuda para vendedores. A partir de um valor
total recebido do teclado, mostrar: o total a pagar com desconto de 10%;o valor de cada parcela, no
parcelamento de 3 x sem juros; a comissão do vendedor, no caso da venda ser a vista (5% sobre o
valor com desconto ) a comissão do vendedor, no caso da venda ser parcelada (5% sobre o valor
total)
19 – Fazer um algoritmo que leia dois números inteiros. O programa deve somar os valores ASCII
desses dois números e mostrar como resultado o caractere correspondente ao resultado da soma.
20 – Fazer um algoritmo que mostre quantos dias existem entre um intervalo de datas, onde a data
inferior e a data superior estão no formato dd/mm.
21 – Fazer um algoritmo que leia três notas e mostre: a média das notas, a situação final do aluno
onde aprovado media = 7.
22 – Fazer um algoritmo que mostre se um número lido é par ou ímpar.
23 – Fazer um algoritmo para ler 3 números e mostrá-los em ordem decrescente.
24 – Fazer um algoritmo que leia a capacidade de um elevador e o peso de 5 pessoas. Informar se o
elevador está liberado para subir ou se excedeu a carga máxima.
25 – Fazer um algoritmo para ajudar a bilheteria do metrô. O operador deve informar o tipo do bilhete
(unitário, duplo ou 10 viagens) e o valor pago pelo passageiro. O sistema deve mostrar, então, a
quantidade de bilhetes possíveis e o troco que o passageiro deve receber. Considere a seguinte
tabela de preço: Bilhete unitário 1,30 Bilhete duplo 2,60 Bilhete de 10 viagens 12,00
26 – Fazer um algoritmo para ajudar no cálculo do salário de um funcionário. O sistema deve pedir:
nome do funcionário salário bruto número de dependentes e deve mostrar: nome do funcionário e
salário líquido Considere a seguinte regra para o cálculo: Salário Líquido =Salário Bruto Desconto
INSS +(15,00 *Número de Dependentes) +Auxílio Passagem (40,00) +Auxílio Refeição (100,00)
Salário Bruto Desconto INSS (Percentual sobre o Salário Bruto) Até 300 8% De 301 a 700 9% Acima
de 700 10%.
