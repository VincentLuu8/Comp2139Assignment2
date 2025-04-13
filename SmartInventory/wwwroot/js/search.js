$(document).ready(function () {
    $('#searchString').on('keyup', function () {
        var searchString = $(this).val();

        $.ajax({
            url: '@Url.Action("Index", "Product")',
            data: { searchString: searchString },
            success: function (data) {
                $('#product-list').html(data);
            }
        });
    });
});
