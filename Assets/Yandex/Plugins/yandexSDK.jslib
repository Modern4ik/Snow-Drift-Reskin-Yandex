mergeInto(LibraryManager.library, {
    GetLang : function() {
        var lang = ysdk.environment.il8n.lang;
        var bufferSize = lengthBytesUTF8(lang) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(lang, buffer, bufferSize);
        return buffer;
    },

    ShowAdv : function() {
        ysdk.adv.showFullscreenAdv({
            callbacks: {
                onClose: function(wasShown) {
                  // Действие после закрытия рекламы.
                  console.log("AD closed");
                },
                onError: function(error) {
                  // Действие в случае ошибки.
                }
            }
        })
    },
});