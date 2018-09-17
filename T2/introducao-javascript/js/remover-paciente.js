var pacientes = documetn.querySelectorAll(".paciente");

var tabela = document.querySelector("#tabela-pacientes");

tabela.addEventListener("dblclick", function(event){
    var alvoEvento = event.target;
    event.target.parentNode.classList.add("fadeOut");
  
    event.target.parentNode.remove();
        setTimeout(function(){
        event.target.parantNOde.remove();
   
    }, 2000);
      

});

