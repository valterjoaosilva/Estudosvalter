var botaoAdicionar = documnt.querySelector("#buscar-pacientes");

botaoAdicionar.addEventlistener("click", function(){
    console.log("buscando pacientes...")
    var xhr = new XMLHttpRequest();

    xhr.open("GET", "https://api-pacientes.herokuapp.com/pacientes");

    xhr.addEventListener("load", function(){
        if( xhr.status == 200){
            var resposta = xhr.responseText;
            var pacientes = JSON.parse(resposta)

            pacientes.forEach(function () {
                adicionaPacienteNaTabela(paciente);
            });

            
        }else{
            console.log(xhr.status);
            console.log(xhr.responseText);
        }
       
    });
    xhr.send();
})