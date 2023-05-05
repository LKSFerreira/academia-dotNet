const listaDeCores = ["--cor-de-fundo-grandiente-vermelho", "--cor-de-fundo-grandiente-verde", "--cor-de-fundo-grandiente-azul", "--cor-de-fundo-grandiente-amarelo"];
const $botoes = document.querySelectorAll("[data-botoes]")
const $header = document.querySelector(".header");

$botoes.forEach((botao, index) => {
    const cor = listaDeCores[index];

    if (index < 5) {
        botao.addEventListener("mouseover", () => {
            $header.style.background = `var(${cor})`;
        });
    }

    switch (index) {
        case 4:
            botao.addEventListener("click", () => window.location.href = "../index.html");
            break;
        case 5:
            botao.addEventListener("click", () => window.location.href = "atividade03.html");
            break;
    }

});


