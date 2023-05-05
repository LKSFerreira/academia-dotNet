const listaDeCores = ["--cor-de-fundo-grandiente-vermelho", "--cor-de-fundo-grandiente-verde", "--cor-de-fundo-grandiente-azul", "--cor-de-fundo-grandiente-amarelo"];
const $radios = document.querySelectorAll("[data-radio]")
const $botoes = document.querySelectorAll("[data-botoes]");
const $header = document.querySelector(".header");

$radios.forEach((botao, index) => {
    const cor = listaDeCores[index];

    if (index < 5) {
        botao.addEventListener("change", () => {
            $header.style.background = `var(${cor})`;
        });
    }
});

$botoes.forEach((botao, index) => {
    console.log('botao' + index);
    
    switch (index) {
        case 0:
            botao.addEventListener("click", () => window.location.href = "atividade02.html");
            break;
        case 1:
            botao.addEventListener("click", () => window.location.href = "atividade03.html");
            break;
    }
});
