
document.querySelector("#unblockButton").addEventListener('click', () => {
    console.log("merge");
    $.ajax({
        url: "UnblockCar",
        data: {
          
            yourcarlp: $("#yourplates3").val()
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
            $("#BlockedYou").modal('hide');

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