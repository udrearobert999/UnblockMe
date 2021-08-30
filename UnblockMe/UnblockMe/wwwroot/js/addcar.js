$("#editCarForm").submit(function submitfunc(event) {
    event.preventDefault();
    $.ajax({
        url: "AddCar/EditCar",
        data: {
            licensePlate: $("#selectEditCar").val(),
            brand: $("#brand").val(),
            color: $("#color").val()

        },
        success: function (status) {



        },
        error: function (error) {


        }

    });
});
$("#selectEditCar").change(function EditCar(event) {

    console.log($(this).val());
    $.ajax({
        url: "AddCar/GetCarByLicensePlate",
        data: {
            licensePlate: $(this).val()
        },
        success: function (data) {
            console.log(data);
            $("#brand").val(data.brand);
            $("#licenseplate").val(data.licensePlate);
            $("#color").val(data.color);


        }

    });
});
$("#editButton").click(function func(event) {
    $.ajax({
        url: "AddCar/GetCarByLicensePlate",
        data: {
            licensePlate: $("#select1").val()
        },
        success: function (data) {

            $("#brand").val(data.brand);
            $("#licenseplate").val(data.licensePlate);
            $("#color").val(data.color);


        }
    })

});
$("#deletButton").click(function func(event) {
    $.ajax({
        url: "AddCar/RemoveCar",
        data: {
            licensePlate: $("#select1").val()
        },
        success: function (status) {

            window.location.reload();
            toastNotifySuccess(status, 1000);

        }
    })
});
$("#addCarForm").submit(function func(event) {
    event.preventDefault();
    var model = {
        LicensePlate: $("#addlicensePlate").val(),
        Brand: $("#addBrand").val(),
        Color: $("#addColor").val()
    };



    $.ajax({
        type: "POST",
        url: "AddCar/AddCar",
        data: model,
        success: function (status) {

            $("#AddCar").modal('hide');
            toastNotifySuccess(status, 1000);
        },
        error: function (error) {

            toastNotifyError(error.responseText, 1000);
        }
    })

});