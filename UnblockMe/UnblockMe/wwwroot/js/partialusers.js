

var banColapseButton = document.querySelector("#banAction");
var rolesColapseButton = document.querySelector("#ManageRoles");
var infoColapseButton = document.querySelector("#infoAction");
var lastUserPressed = null;
var allColapsibleContent = document.querySelectorAll(".colapsible");

console.log(document.getElementById("downloadCarInfo").parentNode.href);



function validateColapsible(colapsible) {
   
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
for (let element of allColapsibleContent)
    element.addEventListener('click', (e) => {
        e.stopPropagation();
    })

infoColapseButton.addEventListener('click', (e) => {

    e.stopPropagation();
    let colapsibleContent = document.querySelector(".colapsible.colapsibleDownloadInfo");
    validateColapsible(colapsibleContent);
    colapse(colapsibleContent);
  

});
banColapseButton.addEventListener('click', (e) => {

    e.stopPropagation();
    let colapsibleContent = document.querySelector(".colapsible.colapsibleBan");
    validateColapsible(colapsibleContent);
    colapse(colapsibleContent);


});
rolesColapseButton.addEventListener('click', (e) => {

    e.stopPropagation();
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
window.addEventListener('click', () => {
    validateColapsible(null);
});
document.querySelector("#unbanAction").addEventListener('click', () => {

    var user_id = $("#Id").val();

    $.ajax({
        url: "UnBanUser",
        data: {
            id: user_id
        },
        success: function (status) {
            toastNotifySuccess(status, 1000);

            document.querySelector("#unbanAction").hidden = true;
            document.querySelector("#banAction").hidden = false;
            lastUserPressed.classList.toggle('btn-primary');
            lastUserPressed.classList.toggle('btn-danger');

        },
        error: function (error) {
            toastNotifyError(error.responseText, 1000);
        }

    });

});

document.querySelector("#downloadBanInfo").addEventListener('click', () => {

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
            colapse(document.querySelector(".colapsible.colapsibleBan"));
            document.querySelector("#banAction").hidden = true;
            document.querySelector("#unbanAction").hidden = false;
            lastUserPressed.classList.toggle('btn-primary');
            lastUserPressed.classList.toggle('btn-danger');
        },
        error: function (error) {

            toastNotifyError(error.responseText, 1000);
        }

    });
});

$('button[id^="user"]').click(function () {

    $("#exampleModalLabel").text("User - " + $(this).children(".buttonUserName").text());
    var user_id = $(this).children(".userId").text();

    lastUserPressed = this;
 
    if (this.classList.contains('btn-danger')) {

        document.querySelector("#banAction").hidden = true;
        document.querySelector("#unbanAction").hidden = false;
    }
    else {
        document.querySelector("#banAction").hidden = false;
        document.querySelector("#unbanAction").hidden = true ;
    }


    $.ajax({
        url: "GetUser",
        data: {
            id: user_id
        },
        success: function (data) {
            let downloadCarUrl = document.getElementById("downloadCarInfo").parentNode.href;
            let urlPref = downloadCarUrl.substr(0, downloadCarUrl.lastIndexOf('/')+1);
            document.getElementById("downloadCarInfo").parentNode.href = urlPref + user_id;
          
            console.log(urlPref + user_id);
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