var homeblog = {} || homeblog;

homeblog.showCategory = function () {
    $.ajax({
        url: 'https://localhost:44310/api/home/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#title').append(`<span>${v.title}</span>`);
            })

        }
    });
}
homeblog.showContent = function () {
    $.ajax({
        url: 'https://localhost:44310/api/home/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#content').append(`<span>${v.content}</span>`);
            })

        }
    });
}


homeblog.showTieude = function () {
    $.ajax({
        url: 'https://localhost:44310/api/about/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#tieude').append(`<span>${v.title}</span>`);
            })

        }
    });
}

homeblog.showShortnoidung = function () {
    $.ajax({
        url: 'https://localhost:44310/api/about/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#shortnoidung').append(`<span>${v.shortContent}</span>`);
            })

        }
    });
}

homeblog.showFullnoidung = function () {
    $.ajax({
        url: 'https://localhost:44310/api/about/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#fullnoidung').append(`<span>${v.content}</span>`);
            })

        }
    });
}
/*category.tbCategory = function () {
    $.ajax({
        url: 'https://localhost:44310/api/category/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#tbCat>tbody').append(`<tr>
                                            <td>${v.categoryId}</td>
                                            <td>${v.categoryName}</td>
                                            <td></td>
                                        </tr>`);
            })

        }
    });
}*/


homeblog.init = function () {
    homeblog.showCategory();
    homeblog.showContent();
    homeblog.showTieude();
    homeblog.showShortnoidung();
    homeblog.showFullnoidung();
}

$(document).ready(function () {
    homeblog.init();
}); 