var parkButton = document.querySelector("#parkButton");
if(parkButton)
    parkButton.addEventListener('click', () => {
      if (navigator.geolocation) {
          navigator.geolocation.getCurrentPosition((p) => {

              console.log(p.coords.latitude, p.coords.longitude);
              $.ajax({
                  url: "ManageCars/ParkCar",
                  data: {
                      licensePlate: $("#selectParkCar").val(),
                      lat: p.coords.latitude,
                      lng: p.coords.longitude

                  },
                  success: function (status) {

                      toastNotifySuccess(status, 1000);

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

    console.log($(this).val());
    $.ajax({
        url: "ManageCars/GetCarByLicensePlate",
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