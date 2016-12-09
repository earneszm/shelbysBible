var SB = {
    onBookChange: function (val)
    {
        window.location.href = "/Load/" + val + "/1";
    },
    onChapterChange: function (val) {
        var book = $('#CurrentBook').val();
        window.location.href = "/Load/" + book + "/" + val;
    },
    onNavigateLeft: function () {
        var book = $('#CurrentBook').val();
        var chapter = $('#CurrentChapter').val();

        window.location.href = "/Home/NavigateLeft?Book=" + book + "&Chapter=" + chapter;
    },
    onNavigateRight: function () {
        var book = $('#CurrentBook').val();
        var chapter = $('#CurrentChapter').val();

        window.location.href = "/Home/NavigateRight?Book=" + book + "&Chapter=" + chapter;
    }


};

