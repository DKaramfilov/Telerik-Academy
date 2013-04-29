var maxWidth = 1100;
var maxHeight = 550;

function onGenrateDivs() {
    
    var allDivs = document.createDocumentFragment();

    for (var i = 0; i < 20; i++) {
        var newRandomDiv = CreateRandomDiv();
        allDivs.appendChild(newRandomDiv);
    }

    var content = document.getElementById('content');
    //clears content before add new divs, usefull when the button is clicked many times
    while (content.firstChild) {
        content.removeChild(content.firstChild);
    }
    content.appendChild(allDivs);
}

function CreateRandomDiv() {
    var divElement = document.createElement("div");
    divElement.style.width = ((Math.random() * 100) | 20) + "px";
    divElement.style.height = ((Math.random() * 100) | 20) + "px";
    divElement.style.borderRadius = ((Math.random() * 25) | 5) + "px";
    divElement.style.borderWidth = ((Math.random() * 20) | 1) + "px";
    divElement.style.backgroundColor = MakeRandomColor();
    divElement.style.borderColor = MakeRandomColor();
    divElement.style.color = MakeRandomColor();
    divElement.style.position = "absolute";

    var topPos = parseInt(Math.random() * (maxHeight - 40));
    divElement.style.top = topPos + "px";

    var topLeft = parseInt(Math.random() * (maxWidth - 40));
    divElement.style.left = topLeft + "px";

    divElement.appendChild(CreateStrongElement());

    return divElement;
}

function MakeRandomColor() {
    var red = ((Math.random() * 256) | 0);
    var green = ((Math.random() * 256) | 0);
    var blue = ((Math.random() * 256) | 0);
    return "rgb(" + red + "," + green + "," + blue + ")";
}
function CreateStrongElement() {
    var strongElement = document.createElement("strong");

    strongElement.innerText = "div";
    return strongElement;
}