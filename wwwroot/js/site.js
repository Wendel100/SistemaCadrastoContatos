$(document).ready(function () {
    $('#table_id').DataTable({
        language: {
            url: "https://cdn.datatables.net/plug-ins/1.11.5/i18n/Portuguese-Brasil.json"
        }
    });
});

$('.alert').click( function () {
    $('.alert').hide('hide');
} );
