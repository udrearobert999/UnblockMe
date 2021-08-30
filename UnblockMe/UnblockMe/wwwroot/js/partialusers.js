

var banColapseButton = document.querySelector("#banAction");
var colapsibleBanContent = document.querySelector(".colapsible");

banColapseButton.addEventListener('click', () => {

    if (colapsibleBanContent.style.maxHeight == '0px' || !colapsibleBanContent.style.maxHeight)
    {
        colapsibleBanContent.style.maxHeight = colapsibleBanContent.scrollHeight+10 + 'px';
        colapsibleBanContent.style.height = colapsibleBanContent.style.maxHeight;
    }

    else
        colapsibleBanContent.style.maxHeight = '0px';
   
});
var range = document.querySelector("#duration");
range.addEventListener('input', () => {
    console.log(range.value);
})
document.querySelector("#unbanAction").addEventListener('click', () => {


});
document.querySelector(".banButton").addEventListener('click', () => {
    let user_id = $("#Id").val();
    let reason = document.getElementById("reason");
    let duration = $("#duration").val();
    $.ajax({
        url: "BanUser",
        data: {
            id: user_id,
            reason: reason.value,
            duration: duration
        },
        success: function (status) {
            toastNotifySuccess(status, 1000);
        },
        error: function (error) {

            toastNotifyError(error.responseText, 1000);
        }

    });
});

$('button[id^="user"]').click(function () {

    $("#exampleModalLabel").text("User - " + $(this).children(".buttonUserName").text());
    var user_id = $(this).children(".userId").text();

    $.ajax({
        url: "GetUser",
        data: {
            id: user_id
        },
        success: function (data) {
            $("#Id").val(data.id);
            $("#fName").val(data.firstName);
            $("#lName").val(data.lastName);
            $("#email").val(data.email);
            $("#phone").val(data.phoneNumber);
        },
        error: function (error) {

            console.log(error.responseText);
        }

    });
});
$("#editUserForm").submit(function func(event) {

    event.preventDefault();

    var model = {
        Id: $("#Id").val(),
        FirstName: $("#fName").val(),
        LastName: $("#lName").val(),
        Email: $("#email").val(),
        PhoneNumber: $("#phone").val()

    };

    $.ajax({
        type: "POST",
        url: "updateUser",
        data: model,
        success: function (status) {

            location.reload();


        },
        error: function (error) {

            toastNotifyError(error.responseText, 1000);
        }
    })



});