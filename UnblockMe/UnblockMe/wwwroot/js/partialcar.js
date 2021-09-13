$(".car").click(function EditCar(event) {


    var pref = window.location.href.slice(0, window.location.href.indexOf("Admin"));
    document.querySelector('#licensePlate').value = $(this).text()
    $.ajax({
        url: pref+"ManageCars/GetCarByLicensePlate",
        data: {
            licensePlate: $(this).text()
        },
        success: function (data) {
            $("#brand").val(data.brand);
            $("#color").val(data.color);


        }

    });
});
$("#submitChanges").click(function submitfunc(event) {

    var pref = window.location.href.slice(0, window.location.href.indexOf("Admin"));

    $.ajax({
        url: pref +"ManageCars/EditCar",
        data: {
            licensePlate: $("#licensePlate").val(),
            brand: $("#brand").val(),
            color: $("#color").val()

        },
        success: function (status) {
            toastNotifySuccess(status, 1000);
        },
        error: function (error) {
            toastNotifyError(error.responseText, 1000);
        }

    });
});