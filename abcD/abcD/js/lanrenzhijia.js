/* ��������������֮�� www.lanrenzhijia.com */
$(document).ready(function(){
    $.ajax({
        type: "post",
        url: "../webservice/myMusic.ashx",
        dataType: "json",
        success: function (data) {            
            var playlist = data;

            var cssSelector = {
                jPlayer: "#jquery_jplayer",
                cssSelectorAncestor: ".music-player"
            };

            var options = {
                swfPath: "http://cdnjs.cloudflare.com/ajax/libs/jplayer/2.6.4/jquery.jplayer/Jplayer.swf",
                supplied: "ogv, m4v, oga, mp3"
            };

            var myPlaylist = new jPlayerPlaylist(cssSelector, playlist, options);
        },
        error: function(XMLHttpRequest, textStatus, errorThrown) {          
            alert(errorThrown);
        }});  
});