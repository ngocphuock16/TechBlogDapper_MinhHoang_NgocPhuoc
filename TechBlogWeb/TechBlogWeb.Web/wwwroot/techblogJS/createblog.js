var category = {} || category;

category.showCategory = function () {
    $.ajax({
        url: 'https://localhost:44310/api/category/gets',
        method: 'GET',
        contentType: 'JSON',
        success: function (data) {
            $.each(data, function (i, v) {
                $('#category').append(`<span>${v.categoryId}= </span>`).append(`<span>${v.categoryName}|</span>`);
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


category.init = function () {
    category.showCategory();
    
}

$(document).ready(function () {
    category.init();
    $('#tbCategory').DataTable(
    );
}); 