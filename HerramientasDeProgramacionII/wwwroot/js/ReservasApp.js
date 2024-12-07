var idReserva = 0;
var idReservaTx = document.getElementById("idReservaTx");
var idReservaInput = document.getElementById("idReserva");
var fechaReserva = document.getElementById("fechaReserva");

var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
    return new bootstrap.Tooltip(tooltipTriggerEl);
});
function ReservaId(id) {
    idReserva = id;
    idReservaTx.innerText = idReserva;
    idReservaInput.value = id;
    var fechaHoy = new Date();
    fechaReserva.value = fechaHoy.toISOString().substring(0, 10);
}

