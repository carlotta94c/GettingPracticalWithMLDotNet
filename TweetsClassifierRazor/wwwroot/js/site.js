// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function getClass(userInput) {
    return fetch(`Index?handler=AnalyzeTweet&text=${userInput}`)
        .then((response) => {
            return response.text();
        })
}

function updateMarker(markerPosition, isFake) {
    $("#markerPosition").attr("style", `left:${markerPosition}%`);
    $("#markerValue").text(isFake);
}

function updateClass() {

    var userInput = $("#Message").val();

    getClass(userInput)
        .then((isFake) => {
            switch (isFake) {
                case "Fake":
                    updateMarker(100.0, isFake);
                    break;
                case "Not Fake":
                    updateMarker(0.0, isFake);
                    break;
                default:
                    updateMarker(45.0, "Checking");
            }
        });
}

$("#Message").on('change input paste', updateClass)