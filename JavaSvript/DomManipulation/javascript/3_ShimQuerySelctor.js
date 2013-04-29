if (typeof document.querySelector != 'function') {
    document.querySelectorAll = function (selectorString) {
        return $(selectorString);
    }

    document.querySelector = function (selectorString) {
        return $(selectorString)[0];
    }
}

function onLoad() {
    var listItems = document.querySelectorAll("#wrapper #nav ul li");

    for (var i = 0; i < 3; i++)
        document.write("<strong>Item #" + (i + 1) + ": </strong>" + listItems[i].innerHTML + "<br/>");
}