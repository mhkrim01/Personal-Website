//var homeHelper = (function ($) {
//    "use strict";
//    var module = {
//        onready: function () {
//            //validate that all properties are populated before setting things up
//            var keys = Object.keys(this);
//            var keysLength = keys.length;
//            for (var i = 0; i < keysLength; i++) {
//                if (this[keys[i]] === null) {
//                    throw new Error(keys[i] + " needs to be initialized.");
//                }
//            }
//            //allows for google analytics to recieve data from site about views and users of site
//                /**
//                * Function that tracks a click on an outbound link in Analytics.
//                * This function takes a valid URL string as an argument, and uses that URL string
//                * as the event label. Setting the transport method to 'beacon' lets the hit be sent
//                * using 'navigator.sendBeacon' in browser that support it.
//                */
//            var trackOutboundLink = function (url) {
//                ga('send', 'event', 'outbound', 'click', url, {
//                    'transport': 'beacon',
//                    'hitCallback': function () {
//                        document.location = url;
//                        alert("YO!");
//                    }
//                });
//            };
//        }
//    };
//    return module;
//})(jQuery);

var analyticsHelper = (function ($) {
    "use strict";
    var module = {
        url: null,
        onready: function () {
            var keys = Object.keys(this);
            var keysLength = keys.Length;
            for (var i = 0; i < keysLength; i++) {
                if (this.[keys[i]] === null) {
                    throw new Error(keys[i] + "needs to be initialized.");
                }
            }
            //allows for google analytics to recieve data from site about views and users of site
            /**
            * Function that tracks a click on an outbound link in Analytics.
            * This function takes a valid URL string as an argument, and uses that URL string
            * as the event label. Setting the transport method to 'beacon' lets the hit be sent
            * using 'navigator.sendBeacon' in browser that support it.
            */
            var url = this.url;
            trackOutboundLink: function $(url) {
                ga('send', 'event', 'outbound', 'click', url, {
                    'transport': 'beacon',
                    'hitCallback': function () {
                        document.location = url;
                        alert("You are navigating to a new page");
                    }
                });
            }
        }
    };
    return module;
})(jQuery);