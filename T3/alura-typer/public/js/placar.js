function inserePlacar() {
    var corpotabela = $(".placar").find("tbody");
    var usuario = "Douglas";
    var numPalavras = $("#contador-palavras").text();

    var linha = novaLinha(usuario.numPalavras);
    linha.find(".botao-remover").click(removeLinha);

    corpoTabela.append(linha);
}

function novaLinha(usuario, palavras) {
    var linha = $("<tr>");
    var colunaUsuario = $("<td>").text(usuario);
    var colunaPalavras = $("<td>").text(numPalavras);
    var colunaRemover = $("<tr>");

    var link = $("<a>").addClass("botao-remover").attr("href", "#");
    var icone = $("<i>").addClass("small").addClass("material-icons").text("delete-forever");

    link.append(icone);

    colanaRemover.append(link);

    linha.append(colunaUsuario);
    linha.append(colunaPalavras);
    linha.append(colunaRemover);

    return linha;

}



function removelinha() {

    event.preventDefault();
    $(this).parent().parent().remove();


} 