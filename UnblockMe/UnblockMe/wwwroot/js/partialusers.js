

var banColapseButton = document.querySelector("#banAction");
var rolesColapseButton = document.querySelector("#ManageRoles");

function validateColapsible(colapsible) {
    let allColapsibleContent = document.querySelectorAll(".colapsible");
    for (const element of allColapsibleContent)
        if (element != colapsible)
            element.style.maxHeight = '0px';

}

function colapse(colapsibleContent)
{
    if (colapsibleContent.style.maxHeight == '0px' || !colapsibleContent.style.maxHeight) {
        colapsibleContent.style.maxHeight = colapsibleContent.scrollHeight + 10 + 'px';
        colapsibleContent.style.height = colapsibleContent.style.maxHeight;
        return true;
    }

    else {

        colapsibleContent.style.maxHeight = '0px';
        return false;

    }
}

banColapseButton.addEventListener('click', () => {

    let colapsibleContent = document.querySelector(".colapsible.colapsibleBan");
    validateColapsible(colapsibleContent);
    colapse(colapsibleContent);
  

});
rolesColapseButton.addEventListener('click', () => {

    let colapsibleContent = document.querySelector(".colapsible.colapsibleManageRoles");
    validateColapsible(colapsibleContent);

    let isOpen = colapse(colapsibleContent);
    if (isOpen) {
        var user_id = $("#Id").val();
        $.ajax({
            url: "GetUserRoles",
            dataType: 'html',
            data: {
                id:user_id
            },
            success: function (data) {
                $('.ManageRolesContainer').html(data);
            }
        });
    }

});

/*range.addEventListener('input', () => {
    console.log(range.value);
})*/
document.querySelector("#unbanAction").addEventListener('click', () => {

    var user_id = $("#Id").val();

    $.ajax({
        url: "UnBanUser",
        data: {
            id: user_id
        },
        success: function (status) {
            toastNotifySuccess(status,1000);
        },
        error: function (error) {
            toastNotifyError(error.responseText, 1000);
        }

    });

});
var downloadButton = document.querySelector("#downloadBanInfo");
downloadButton.addEventListener('click', () => {
    let user_id = $("#Id").val();
    $.ajax({
        url: 'DownloadBanInfoCSV',
  
        data: {
            id: user_id,
        },
        success: function () {
            window.location = 'DownloadBanInfoCSV?id=' + String($("#Id").val());
        }
    });


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