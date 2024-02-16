//<-- Begin: Alert Notif-->
const button = document.getElementById('kt_docs_sweetalert_info');

button.addEventListener('click', e => {
    e.preventDefault();

    Swal.fire({
        text: "Beliin Aku kopi dong biar semangat hehe",
        icon: "info",
        buttonsStyling: false,
        confirmButtonText: "Ok, got it!",
        customClass: {
            confirmButton: "btn btn-info"
        }
    });
});

//<-- End: Alert Notif-->

