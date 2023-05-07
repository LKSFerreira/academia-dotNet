
const $botoes = document.querySelectorAll("[data-botoes]")
const logoTexto = document.querySelector("[data-logo-texto");

console.log(logoTexto);
$botoes.forEach((botao, index) => {
    switch (index) {
        case 0:
            botao.addEventListener("click", () => logoTexto.style.color = "black");
            break;
        case 1:
            botao.addEventListener("click", () => logoTexto.style.color = "white");
            break;
        case 2:
            botao.addEventListener("click", () => logoTexto.style.backgroundColor = "black");
            break;
        case 3:
            botao.addEventListener("click", () => logoTexto.style.backgroundColor = "white");
            break;
        case 4:
            botao.addEventListener("click", () => window.location.href = "atividade05.html");
            break;
        case 5:
            botao.addEventListener("click", () => window.location.href = "atividade07.html");
            break;
    }
});


