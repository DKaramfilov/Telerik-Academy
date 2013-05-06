var photos = [];
var which = 0;

photos[0] = "img/1.jpg"
photos[1] = "img/2.jpg"
photos[2] = "img/3.jpg"
photos[3] = "img/4.jpg"
photos[4] = "img/5.jpg"


function backward() {
    if (which > 0) {
        window.status = ''
        which--
        document.images.photoslider.src = photos[which]
    }
}

function forward() {
    if (which < photos.length - 1) {
        which++
        document.images.photoslider.src = photos[which]
    }
    else
        window.status = 'End of gallery'
}