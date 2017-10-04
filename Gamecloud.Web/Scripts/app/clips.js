

$(document).ready(function () {

    $("#clipsbutton").on("click", function (e) {

        /* Clean up existing divs containing clips */

        $("#clips-display").children().remove();

        /* GET request for top clips using client id and game */

        $.get("https://api.twitch.tv/kraken/clips/top", { client_id: $("#client-id").val(), game: $("#game").val(), api_version: "4" })

            .done(clipsLoaded);

        /* GET request for search api to get game logo */

        $.get("https://api.twitch.tv/kraken/search/games", { client_id: $("#client-id").val(), query: $("#game").val(), api_version: "5" })

            .done(embedgameimage);

        e.preventDefault();

    });

});



/*

This function takes the JSON data from the Clips API GET response and displays it in <div> tags by creating child tags for clips-display div

*/

function clipsLoaded(data) {

    var $clips = $("#clips-display");



    $clips.children().remove();



    data.clips.forEach(function (clip) {

        var $iframe = $('<iframe width="640" height="360" frameborder="0" scrolling="no" allowfullscreen="true">');

        $iframe.src = clip.embed_url;

        $clips.append($iframe);

    });

}



function embedgameimage(data) {

    var game = data[0];



    $("#game-image").attr('src', game.box.large);

}