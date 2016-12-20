var SB = {};

SB.Util = (function ($) {

    var Navigation = {

        onBookChange: function (book) {
            this.AJAX("/LoadPartial/" + book + "/" + 1);
        },
        onChapterChange: function (chapter) {
            var book = $('#CurrentBook').val();

            this.AJAX("/LoadPartial/" + book + "/" + chapter);
        },
        onNavigateLeft: function () {
            var book = $('#CurrentBook').val();
            var chapter = $('#CurrentChapter').val();

            this.AJAX("/NavigateLeft?Book=" + book + "&Chapter=" + chapter);
        },
        onNavigateRight: function () {
            var book = $('#CurrentBook').val();
            var chapter = $('#CurrentChapter').val();

            this.AJAX("/NavigateRight?Book=" + book + "&Chapter=" + chapter);
        },
        AJAX: function (url) {
            $.ajaxStart

            $.ajax({
                url: url,
                success: function (result) {
                    $('#loadContentDiv').html(result.html);

                    $('#ajaxLoadingDiv').show();

                    window.history.pushState(
                        null,
                        'page: ' + result.book + '/' + result.chapter, // new page title
                        '/Load/' + result.book + "/" + result.chapter
                    );

                    $.ajax({
                        url: "/LoadText/" + result.book + "/" + result.chapter,
                        dataType: 'html',
                        success: function (textResult) {
                            $('#ajaxLoadingDiv').hide();
                            $('#textLoadDiv').html(textResult);
                        }
                    });
                }
            });
        }
    }
    return Navigation;
})(jQuery);



// global setup
window.onpopstate = function (event) {
    window.location.href = document.location;
};