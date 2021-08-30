$("#rating").submit(function rate(event) {
    event.preventDefault();
    var radioValue = 10 - parseInt($("input[name='Rating']:checked").val()) + 1;
    var rateMessage = $("#ratemessage").val();

    $.ajax({
        url: "RateAction/@Model.Item3.Id",
        data: {
            rating: radioValue,
            ratingMessage: rateMessage,

        },
        success: function (status) {
            $("#BlockedYou").modal('hide');
            location.reload();
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#BlockedYou").modal('hide');
            toastNotifyError(error.responseText, 1000);
        }

    });
});
$("#form1").submit(function blockedyou(event) {
    event.preventDefault();
    $.ajax({
        url: "BlockedYouAction",
        data: {
            Contact: $("#Contact").val(),
            MyPlate: $("#myplates").val(),
            YourPlate: $("#yourplates").val()
        },
        success: function (status) {
            $("#BlockedYou").modal('hide');
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#BlockedYou").modal('hide');
            toastNotifyError(error.responseText, 1000);
        }

    });


});
$("#form2").submit(function unblockme(event) {
    event.preventDefault();
    $.ajax({
        url: "BlockedMeAction",
        data: {
            Contact: $("#Contact").val(),
            MyPlate: $("#myplates").val(),
            YourPlate: $("#yourplates").val()
        },
        success: function (status) {

            console.log(status);
            $("#UnblockMe").modal('hide');
            toastNotifySuccess(status, 1000);

        },
        error: function (error) {

            $("#UnblockMe").modal('hide');
            toastNotifyError(error.responseText, 1000);
        }
    });


});