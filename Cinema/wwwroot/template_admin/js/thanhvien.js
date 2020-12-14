﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
showModalThanhVien = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            //hiện form create edit
            $('#form-modal .modal-body').html(res);
            //hiện tiêu đề
            $('#form-modal .modal-title').html(title);
            //hiện modal
            $('#form-modal').modal('show');
        }
    })
};
function ShowImagePreview(imageUploader, previewImage) {
    if (imageUploader.files && imageUploader.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $(previewImage).attr('src', e.target.result);
        }
        reader.readAsDataURL(imageUploader.files[0]);
    }
}
