const form = document.querySelector('form');
const inputSenhas = document.querySelectorAll('[data-senha]');
const regex = /^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()])[a-zA-Z\d!@#$%^&*()-]{8,}$/;
const camposDoFormulario = document.querySelectorAll('[required]');

form.addEventListener('submit', (event) => {
    event.preventDefault();
    alert('Formulário enviado!');
    window.location.href = "atividade10.html";
});

camposDoFormulario.forEach((campo) => {
    campo.addEventListener("blur", () => verificaCampo(campo));
    campo.addEventListener("invalid", evento => evento.preventDefault())
})

const tiposDeErro = [
    'valueMissing',
    'typeMismatch',
    'patternMismatch',
    'tooShort',
    'customError'
]

const mensagens = {
    usuario: {
        valueMissing: 'O campo do usuário não pode estar vazio.',
        tooShort: "O campo do usuário não tem caractéres suficientes."
    },
    senha: {
        valueMissing: 'O campo da senha não pode estar vazio.',
        tooShort: "O campo de sebga não tem caractéres suficientes."
    },
    confirmarSenha: {
        valueMissing: 'O campo da senha não pode estar vazio.',
        tooShort: "O campo de sebga não tem caractéres suficientes."
    }
}

function verificaCampo(campo) {

    let mensagem = "";
    campo.setCustomValidity('');

    tiposDeErro.forEach(erro => {
        if (campo.validity[erro]) {
            mensagem = mensagens[campo.name][erro];
        }
    })

    const mensagemErro = campo.parentNode.querySelector('.mensagem-erro');
    let validadorDeInput = campo.checkValidity();

    if (!regex.test(inputSenhas[0].value) && campo.name == "senha") {
        mensagem = "Deve conter pelo menos 8 caractéres, sendo pelo menos uma letra maiúscula, um número e um caractér especial.";
        validadorDeInput = false;
    }


    if (!validadorDeInput) {
        mensagemErro.textContent = mensagem;
    } else {
        mensagemErro.textContent = "";
    }
}