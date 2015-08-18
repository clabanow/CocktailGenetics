/// <reference path="indexModule.js" />

indexApp.directive('slideable', function () {
    return {
        restrict: 'C',
        compile: function (element, attr) {
            // wrap tag
            var contents = element.html();
            element.html('<div class="slideable_content" style="margin:0 !important; padding:0 !important" >' + contents + '</div>');

            return function postLink(scope, element, attrs) {
                // default properties
                attrs.duration = (!attrs.duration) ? '1s' : attrs.duration;
                attrs.easing = (!attrs.easing) ? 'ease-in-out' : attrs.easing;
                element.css({
                    'overflow': 'hidden',
                    'height': '0px',
                    'transitionProperty': 'height',
                    'transitionDuration': attrs.duration,
                    'transitionTimingFunction': attrs.easing
                });
            };
        }
    };
})
.directive('slideToggle', function () {
    return {
        restrict: 'A',
        link: function (scope, element, attrs) {
            var target, content;

            attrs.expanded = false;

            element.bind('click', function () {
                var resultWidth = document.getElementById("1").offsetWidth + document.getElementById("2").offsetWidth;
                target = document.getElementById(attrs.slideToggle.substring(1));
                content = target.querySelector('.result-recipe-wrapper');

                if (!attrs.expanded) {
                    content.style.border = '1px solid rgba(0,0,0,0)';
                    var y = content.offsetHeight;
                    content.style.border = 0;
                    target.style.height = y + 'px';
                    target.style.width = resultWidth + 'px';
                    attrs.expanded = true;
                } else {
                    content.style.height = '0px';
                    content.style.width = '0px';
                    attrs.expanded = false;
                }
                //attrs.expanded = !attrs.expanded;
            });
        }
    }
});