
const $botoes = document.querySelectorAll("[data-botoes]")
const logoTexto = document.querySelector("[data-logo-texto] ");

console.log(logoTexto);
$botoes.forEach((botao, index) => {

    let tamanho = 16;

    switch (index) {
        case 0:
            botao.addEventListener("click", () => {
                tamanho++;
                logoTexto.style.fontSize = `${tamanho}px`
            });
            break;
        case 1:
            botao.addEventListener("click", () => {
                tamanho--;
                logoTexto.style.fontSize = `${tamanho}px`
            });
            break;
        case 2:
            botao.addEventListener("click", () => window.location.href = "atividade06.html");
            break;
        case 3:
            botao.addEventListener("click", () => window.location.href = "atividade08.html");
            break;
    }
});


