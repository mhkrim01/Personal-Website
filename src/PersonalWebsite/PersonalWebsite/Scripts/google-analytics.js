var homeHelper = (function ($) {
    "use strict";
    var module = {
        onready: function () {
            //validate that all properties are populated before setting things up
            var keys = Object.keys(this);
            var keysLength = keys.length;
            for (var i = 0; i < keysLength; i++) {
                if (this[keys[i]] === null) {
                    throw new Error(keys[i] + " needs to be initialized.");
                }
            }
            //allows for google analytics to recieve data from site about views and users of site
            window.dataLayer = window.dataLayer || [];
            function gtag() { dataLayer.push(arguments); }
            gtag('js', new Date());

            gtag('config', 'UA-120225268-1');
        }
    }
    return module;
})(jQuery);
