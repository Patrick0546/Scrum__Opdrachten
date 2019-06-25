function afmelden() {
    var antwoord = confirm('Wilt u zich afmelden?');
    if (antwoord == true) {
        alert('U word afgemeld!!!');
    }
}
function dollar_naar_euro(dollars) {
    return(dollars * euroKoers());
}
function wissel(bedrag, valuta) {
    if(valuta == 'euro') {
        return(bedrag * dollarKoers());
    }
    else if(valuta == 'dollar') {
        return(bedrag * euroKoers());
    }
}