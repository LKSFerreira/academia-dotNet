const radioButtons = document.querySelectorAll('input[type="radio"]');
const form = document.querySelectorAll("[required]");

radioButtons.forEach((radioButton) => {
    radioButton.addEventListener('change', (event) => {
        const tipoPessoa = event.target.id;
        switch (tipoPessoa) {
            case 'pessoa_fisica':
                cadastrarPessoaFisica();

                break;
            case 'pessoa_juridica':
                cadastrarPessoaJuridica();
                break;
        }

    });
});


const nome = document.querySelectorAll('[data-nome]');
const cpf = document.querySelector('#cpf');
const nascimento = document.querySelector('#nascimento');

function cadastrarPessoaFisica() {
    console.log(nome);

    nome[0].textContent = 'Nome Completo:';
    nome[1].setAttribute('placeholder', 'Digite aqui seu nome completo');
    cpf.textContent = 'CPF:';
    cpf.setAttribute('placeholder', 'Digite aqui seu CPF');
    nascimento.textContent = 'Data de Nascimento:';
    nascimento.setAttribute('placeholder', 'Data de Nascimento com dia, mês e ano');
}

function cadastrarPessoaJuridica() {
    nome[0].textContent = 'Nome Fantasia:';
    nome[1].setAttribute('placeholder', 'Digite aqui o nome fantasia da empresa');
    cpf.textContent = 'CNPJ:';
    cpf.setAttribute('placeholder', 'Digite aqui o CNPJ da empresa');
    nascimento.textContent = 'Data de Abertura da empresa com dia, mês e ano:';
}

const erroCEP = document.querySelector('#erro-cep');
const cep = document.querySelector('#cep');



async function buscaCEP(cep) {
    try {
        const response = await fetch(`https://viacep.com.br/ws/${cep}/json/`);
        const data = await response.json();

        if (!response.ok) {
            throw new Error(500)
        } else if (data.erro) {
            throw new Error(404);
        } else {
            const logradouro = document.querySelector('#logradouro');
            const bairro = document.querySelector('#bairro');
            const cidade = document.querySelector('#cidade');
            const estado = document.querySelector('#estado');

            logradouro.value = data.logradouro;
            bairro.value = data.bairro;
            cidade.value = data.localidade;
            estado.value = data.uf;

            erroCEP.innerHTML = '';
        }
    } catch (erro) {
        erro = erro.toString().replace('Error: ', '');

        console.log(erro);

        switch (erro) {
            case "404":
                erroCEP.innerHTML = `CEP não encontrado`;
                console.log('CEP não encontrado');
                break;
            case "500":
                erroCEP.innerHTML = 'Erro no servidor';
                console.log('Erro no servidor');
                break;
            default:
                erroCEP.innerHTML = 'CEP invalido';
                console.log('CEP inválido');
                break;
        }
    }
}

cep.addEventListener('focusout', () => {


    switch (cep.value.length) {
        case 0:
            erroCEP.innerHTML = 'CEP não pode ser vazio';
            break;
        case 8:
            erroCEP.innerHTML = '';
            buscaCEP(cep.value);
            document.querySelector('#complemento').focus();
            break;
        default:
            erroCEP.innerHTML = 'CEP inválido';
            break;

    }
});