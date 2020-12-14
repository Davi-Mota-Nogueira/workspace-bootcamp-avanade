/*
Parte 1 da Aula 1: var, String, int, alert() e console.log(), operações.
var nome = "Davi da Mota Nogueira";
var n1 = 5;
var n2 = 3;
var frase = "Japão é o melhor time do mundo";
//alert("Bem vindo " + nome + ", você tem " + n1 + " anos.");
//alert(n1 + n2);
console.log(nome);
console.log(n1 + n2);
console.log(n1 * n2);
console.log(frase.replace("Japão", "Brasil"));
//alert(frase.replace("Japão", "Brasil"))
console.log(frase.toUpperCase);
console.log(frase.toLowerCase);
*/

/*
Parte 2 da Aula 1: Array e Dicionário e alguns métodos deles.

--------------------Parte de Array--------------------------

var lista = ["maçã", "pêra", "laranja"];
lista.push("uva");
console.log(lista);
lista.pop("uva");
console.log(lista);
console.log(lista[0]);
console.log(lista.length);
console.log(lista.reverse());
console.log(lista.toString());
console.log(lista.join(" | "));
alert(lista[1]);

--------------------Parte de Dicionário--------------------------

var fruta ={
    nome:"maçã",
    cor:"vermelha"
};
console.log(fruta);
console.log(fruta.nome);
alert(fruta.cor);

var frutas =[
    {
        nome:"maçã", 
        cor:"vermelha"
    },
    {
        nome:"uva",
        cor:"roxa"
    }
];
console.log(frutas);
alert(frutas[1]); //Dá um erro no alert bject: Object]
alert(frutas[0].nome);
*/

/* 

Parte 3 da Aula 1: Condições, Laços de Repetição e Date

var idade = prompt("Qual sua idade? ");
if(idade >= 18){
    alert("Maior de idade")
} else{
    alert("Menor de idade")
};

var count = 0;
while(count < 5){
    console.log(count);
    count++;
};

for(var count = 0; count <= 5; count++){
    console.log(count + "!");
}

var d = new Date();
console.log(d);
console.log(d.getMonth()+1); // É obrigado ter o +1 pq o mês começa por Zero na classe.
console.log(d.getHours());
console.log(d.getMinutes());
console.log(d.getDate()); // Aqui mostra a data do mês, onde começa do 1 mesmo.
console.log(d.getDay()); // Aqui mostra que dia da semana é, a partir do Domingo sendo 0.
*/

/* 
Parte 1 da Aula 2: function, variável global e local

function soma(n1, n2){
    return n1+n2;
}

function validaIdade(idade){
    var validar = true;
    if (idade >= 18){
        validar = true;
    } else{
        validar = false;
    }
    return validar;
}

var idade = prompt("Qual sua idade?");
alert(validaIdade(idade));

//alert(soma(32,11));
function setReplace(frase, nome, novo_nome){
    return frase.replace(nome, novo_nome);
}

alert(setReplace("Fora Temer!", "Temer", "Bozonaro"));
*/

/* 
Parte 2 da Aula 2: Mudanças no HTML a partir do JS.
*/

function botao(){
    document.getElementById("agradecimento").innerHTML = "Obrigado por clicar";
}

function redirecionar(){
    window.open("http://pudim.com.br/"); // Essa função abre outra aba no link referenciado
    //window.location.href = "http://pudim.com.br/" // Essa função abre o link na mesma página
}
/*
function trocar(){
    document.getElementById("mousemove").innerHTML = "Obrigado por passar o mouse";
    //alert("Trocar texto")
}

function voltar(){
    document.getElementById("mousemove").innerHTML = "aqui";
}
*/
function trocar(elemento){
    elemento.innerHTML ="Obrigado por passar!";
}

function voltar(elemento){
    elemento.innerHTML ="aqui";
}

function load(){
    console.log("Página carregada");
}

function funcaoChange(elemento){
    console.log(elemento.value);
}