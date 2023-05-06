const $botoes = document.querySelectorAll("[data-botoes]");
const $logo = document.querySelector(".logo");
const $checkboxes = document.querySelectorAll("[data-checkbox]");
$botoes[1].disabled = true;

$checkboxes.forEach((checkbox) => {
    checkbox.addEventListener('change', estadoBotaoProximaAtividade);
});

$botoes.forEach((botao, index) => {
    switch (index) {
        case 0:
            botao.addEventListener("click", () => window.location.href = "atividade03.html");
            break;
        case 1:
            botao.addEventListener("click", () => window.location.href = "atividade06.html");
            break;
    }
});

function estadoBotaoProximaAtividade() {
    if ($checkboxes[0].checked && $checkboxes[1].checked) {
        $botoes[1].disabled = false;
    } else {
        $botoes[1].disabled = true;
    }
}

