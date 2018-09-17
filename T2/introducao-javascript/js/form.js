var botaoAdicionar = document.querySelector("#adicionar-paciente");
botaoAdicionar.addEventListener("click", function (event) {
    event.preventDefault();


    var form = document.querySelector("#form-adiciona");
    var paciente = obtemPacienteDoFormulario(form);

   var pacientTr = montarTr(paciente);
   
 var erros = validaPaciente(paciente);
console.log(erros);
   if(erros.length > 0){
       exibeMensagensDeErro(erros);
       
    return; 
   }

    var tabela = document.querySelector("#tabela-pacientes");

    tabela.appendChild(pacienteTr);

    form.reset();
});

function exibeMensagensDeErro(erros){
    var ul = document.querySelector("#mensagens-erro");
    errros.foreach(function(erro){
        var li = document.createElement("li");
    ul.appendChild(li);
    });
    
}


   
titulo.addEventListener("click", function () {
    console.log("fui clicado");
});

function obtemPacienteDoFormulario(form){
    
    var paciente = {
        nome: form.nome.value,
        peso: form.peso.value,
        altura: form.peso.value,
        gordura: form.peso.value,
        imc: calculaImc(form.peso.value, form.altura.value)
    
    }
   
    return paciente;
}
function montaTr(paciente){

    var pacienteTr = document.createElement("tr");
    pacienteTr.classList.add("paciente");
         

    pacienteTr.appendChild(montaTd(paciente.nome, "info-nome"));
    pacienteTr.appendChild(montaTd(paciente.peso, "info-peso"));
    pacienteTr.appendChild(montaTd(paciente.altura, "info-altura"));
    pacienteTr.appendChild(montaTd(paciente.gordura, "info-gordura"));
    pacienteTr.appendChild(montaTd(paciente.imc, "info-imc"));

    return pacienteTr;

}
function montaTd(dado,classe){
    var td = documnt.createElement("td");
    td.textContent = dado;
    td.classList.add(classe);
    return td;
}

function validaPaciente(paciente){
 
    var erros = [];
 
    if(validaPeso(paciente.peso)) erros.push("peso é inváido");
    
    if(validaAltura(paciente.altura)) erros.push("altura é inválida");
    
    return erros;
}