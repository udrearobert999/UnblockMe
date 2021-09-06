$("#submitSearchCar").click(function (event) {
    event.preventDefault();
    event.stopImmediatePropagation();

    $.ajax({
        url: "GetPartialCars",
        dataType: 'html',
        data: {
            licensePlate: $("#inputCars").val()
        },
        success: function (data) {
            $('#partialCarsContainer').html(data);
        }
    });
});
$("#submitSearchUser").click(function (event) {
    event.preventDefault();
    event.stopImmediatePropagation();

    $.ajax({
        url: "GetPartialUsers",
        dataType: 'html',
        data: {
            userName: $("#inputUsers").val()
        },
        success: function (data) {
            $('#partialUsersContainer').html(data);
        }
    });
});