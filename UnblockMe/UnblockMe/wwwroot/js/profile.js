
document.querySelector("#unblockButton").addEventListener('click', () => {
    console.log("merge");
    $.ajax({
        url: "UnblockCar",
        data: {
          
            yourcarlp: $("#yourplates3").val()
        },
        success: function (status) {
        
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#BlockedYou").modal('hide');
            toastNotifyError(error.responseText, 3000);
        }

    });
})


$("#form1").submit(function blockedyou(event) {
    event.preventDefault();
    $.ajax({
        url: "BlockedYouAction",
        data: {
            Contact: $("#Contact").val(),
            MyPlate: $("#myplates2").val(),
            YourPlate: $("#yourplates2").val()
        },
        success: function (status) {
            $("#BlockedYou").modal('hide');
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#BlockedYou").modal('hide');
            toastNotifyError(error.responseText, 3000);
        }

    });


});
$("#form2").submit(function unblockme(event) {
    event.preventDefault();
    console.log($("#yourplates").val());
    $.ajax({
        url: "BlockedMeAction",
        data: {
            Contact: $("#Contact").val(),
            MyPlate: $("#myplates1").val(),
            YourPlate: $("#yourplates1").val()
        },
        success: function (status) {

            console.log(status);
            $("#UnblockMe").modal('hide');
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#UnblockMe").modal('hide');
            toastNotifyError(error.responseText, 3000);
        }
    });


});