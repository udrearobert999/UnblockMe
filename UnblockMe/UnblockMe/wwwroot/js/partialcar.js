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
            Toastify({
                text: status,
                duration: 2000,
                destination: "https://github.com/apvarun/toastify-js",
                newWindow: true,
                close: true,
                gravity: "bottom", // `top` or `bottom`
                position: "right", // `left`, `center` or `right`
                backgroundColor: "rgb(79,155,48)",
                stopOnFocus: true, // Prevents dismissing of toast on hover
                onClick: function () { } // Callback after click
            }).showToast();
        },
        error: function (error) {
            Toastify({
                text: error.responseText,
                duration: 2000,
                destination: "https://github.com/apvarun/toastify-js",
                newWindow: true,
                close: true,
                gravity: "bottom", // `top` or `bottom`
                position: "right", // `left`, `center` or `right`
                backgroundColor: "rgb(194,10,4)",
                stopOnFocus: true, // Prevents dismissing of toast on hover
                onClick: function () { } // Callback after click
            }).showToast();
        }

    });
});