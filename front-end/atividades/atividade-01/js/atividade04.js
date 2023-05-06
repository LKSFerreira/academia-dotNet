const $botao = document.querySelector(".btn-2");
const $logo = document.querySelector(".logo");
const $botoes = document.querySelectorAll("[data-botoes]");

$botao.addEventListener("click", () => {
    $logo.classList.toggle("ativo");

    if ($logo.classList.contains("ativo")) {
        $botao.innerHTML = "Esconder texto";
    } else {
        $botao.innerHTML = "Mostrar texto";
    }
});


$botoes.forEach((botao, index) => {
    switch (index) {
        case 0:
            botao.addEventListener("click", () => window.location.href = "atividade03.html");
            break;
        case 1:
            botao.addEventListener("click", () => window.location.href = "atividade05.html");
            break;
    }
});
