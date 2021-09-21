

var roleButtonsChecked = document.querySelectorAll(".btn.role.btn-success");
var roleButtons = document.querySelectorAll(".btn.role.btn-primary");

for (let role of roleButtons) {

    role.addEventListener('mouseover', () => {
        role.classList.add('btn-success');
    });
    role.addEventListener('mouseout', () => {
        role.classList.remove('btn-success');
    });
    role.addEventListener('click', () => {

        var user_id = document.querySelector('#Id').value;
  
        $.ajax({
            url: "AddUserToRole",
            data: {
                id: user_id,
                role: role.textContent
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

}
for (let role of roleButtonsChecked)
{
   
        role.addEventListener('mouseover', () => {
            role.classList.add('btn-danger');
        });
    role.addEventListener('mouseout', () => {
        role.classList.remove('btn-danger');
    });
    role.addEventListener('click', () => {


        var user_id = document.querySelector('#Id').value;

        $.ajax({
            url: "RemoveUserFromRole",
            data: {
                id: user_id,
                role: role.textContent
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
  
}
  