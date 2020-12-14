showInPopup = (url, title) => {
    $.ajax({
        type: "GET",
        url: url,
        success: function (res) {
            $("#modal-update .modal-body").html(res);
            $("#modal-update .modal-title").html(title);
            $("#modal-update").modal('show');
        }
    })
}