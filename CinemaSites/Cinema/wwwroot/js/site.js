// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('#create-rapphim-').submit(function (e) {
    e.preventDefault();
    const post_url = $(this).attr("action");
    const request_method = $(this).attr("method");
    const form_data = $(this).serialize();
    $.ajax({
        url: post_url,
        type: request_method,
        data: form_data
    }).done(function (response) {
        if (response) {
            modalIntify({
                title: 'Thông báo',
                messenge: 'Thêm rạp phim thành công!'
            });
            $('#modal-tb').modal('show');
            $('#modal-tb').click(function (e) {
                if (e.target.closest('#modal-tb') || e.target.closest('xRemove')) {
                    location.reload();
                }
            });

        } else {
            modalIntify({
                title: 'Thông báo',
                messenge: 'Thêm rạp phim thất bại!'
            });
            $('#modal-tb').modal('show');
        }
    });
});

