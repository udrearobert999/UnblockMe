var parkButton = document.querySelector("#parkButton");

function parkSelectedCar() {
    $.ajax({
        url: "ManageCars/ParkCar",
        data: {
            licensePlate: $("#selectParkCar").val(),
            //lat: p.coords.latitude,
            //lng: p.coords.longitude
            lat: 44.3301785,
            lng: 23.7948807
        },
        success: function (status) {
            toastNotifySuccess(status)
        },
        error: function (error) {

            toastNotifyError(error.responseText);
        }
    });
}

if (parkButton)
    parkButton.addEventListener('click', () => {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition((p) => {
                $.ajax({
                    url: "ManageCars/GetBlockingChanceOfSpot",
                    data: {
                        //licensePlate: $("#selectParkCar").val(),
                        //lat: p.coords.latitude,
                        //lng: p.coords.longitude
                        lat: 44.3301785,
                        lng: 23.7948807
                    },
                    success: function (data) {
                        var chance = (data * 100).toFixed(2);
                        if (chance > 30)
                            swal({
                                title: "Are you sure you want to park here?",
                                text: `You have ${chance} % chance to be blocked`,
                                icon: "warning",
                                buttons: true,
                                dangerMode: true,
                            }).then((val) => {
                                if (val)
                                    parkSelectedCar();
                            });
                        else 
                            parkSelectedCar()

                    },
                    error: function (error) {


                    }
                });
            });
        }


    });

$("#editCarForm").submit(function submitfunc(event) {
    event.preventDefault();
    $.ajax({
        url: "ManageCars/EditCar",
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


    $.ajax({
        url: "ManageCars/GetCarByLicensePlate",
        data: {
            licensePlate: $(this).val()
        },
        success: function (data) {

            $("#brand").val(data.brand);
            $("#licenseplate").val(data.licensePlate);
            $("#color").val(data.color);


        }

    });
});
$("#editButton").click(function func(event) {
    $.ajax({
        url: "ManageCars/GetCarByLicensePlate",
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
        url: "ManageCars/RemoveCar",
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
        url: "ManageCars/AddCar",
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