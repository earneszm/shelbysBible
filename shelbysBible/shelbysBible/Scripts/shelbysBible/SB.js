var SB = {
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

        this.AJAX("/Home/NavigateLeft?Book=" + book + "&Chapter=" + chapter);
    },
    onNavigateRight: function () {
        var book = $('#CurrentBook').val();
        var chapter = $('#CurrentChapter').val();

        this.AJAX("/Home/NavigateRight?Book=" + book + "&Chapter=" + chapter);
    },
    AJAX: function (url) {
        $.ajax({
            url: url,
            success: function (result) {

                $('#loadContentDiv').html(result.html);

                window.history.pushState(
                    null,
                    'page: ' + result.book + '/' + result.chapter, // new page title
                    '/Load/' + result.book + "/" + result.chapter
                );
            }
        });
    }
};

window.onpopstate = function (event) {
    window.location.href = document.location;
};

