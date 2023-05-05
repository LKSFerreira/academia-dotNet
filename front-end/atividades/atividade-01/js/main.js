const listaDeCores = ["--cor-de-fundo-grandiente-vermelho", "--cor-de-fundo-grandiente-verde", "--cor-de-fundo-grandiente-azul", "--cor-de-fundo-grandiente-amarelo"];
const $botoes = document.querySelectorAll("[data-botoes]")
const $header = document.querySelector(".header");

$botoes.forEach((botao, index) => {
    const cor = listaDeCores[index];

    botao.addEventListener("click", () => {
        $header.style.background = `var(${cor})`;

        if (index === listaDeCores.length) {
            window.location.href = "pages/atividade02.html";
            console.log('teste');

        }
    })


});

