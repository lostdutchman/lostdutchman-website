function start() { 
    var imageDir = '/static/sumospin/images/';                          
    var delayInSeconds = 2;                            

    var images = ["1.webp", "2.webp", "3.webp"];

    var num = 0;
    var changeImage = function() {
        var len = images.length;
        document.slide.src = imageDir + images[num++];
        if (num == len) {
            num = 0;
        }
    };
    setInterval(changeImage, delayInSeconds * 1000);
};
window.onload=function(){
start();
}