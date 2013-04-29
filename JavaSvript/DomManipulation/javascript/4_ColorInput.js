function changeForecolor() {
    var textarea = document.getElementById('TextAreaContent');
    var forecolor = document.getElementById('foreColor').value;
    textarea.style.color = forecolor;
}
function changeBacground() {
    
    var textarea = document.getElementById('TextAreaContent');
    textarea.style.backgroundColor = document.getElementById('backColor').value;
}