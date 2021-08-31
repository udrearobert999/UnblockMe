

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
                toastNotifySuccess(status, 1000);
            },
            error: function (error) {

                toastNotifyError(error.responseText, 1000);
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
                toastNotifySuccess(status, 1000);
            },
            error: function (error) {

                toastNotifyError(error.responseText, 1000);
            }
        });

    });
  
}
  