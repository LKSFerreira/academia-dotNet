
const $botoes = document.querySelectorAll("[data-botoes]")
const logoTexto = document.querySelector("[data-logo-texto");

console.log(logoTexto);
$botoes.forEach((botao, index) => {
    console.log(botao, index);
    
    switch (index) {
        case 0:
            botao.addEventListener("click", () => logoTexto.style.textTransform = "uppercase");
            break;
        case 1:
            botao.addEventListener("click", () => logoTexto.style.textTransform = "lowercase");
            break;
        case 2:
            botao.addEventListener("click", () => window.location.href = "atividade07.html");
            break;
        case 3:
            botao.addEventListener("click", () => window.location.href = "atividade09.html");
            break;
    }
});


