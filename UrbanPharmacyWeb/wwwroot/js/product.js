var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data: 'name', "width": "12%" },
            { data: 'sku', "width": "12%" },
            { data: 'listPrice', "width": "12%" },
            { data: 'brand', "width": "12%" },
            { data: 'category.name', "width": "22%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-140 btn-group" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-outline-primary mx-2">
                            <i class="bi bi-pencil-square"></i> Edit
                        </a>               
                        <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-outline-danger mx-2">
                            <i class="bi bi-trash-fill"></i> Delete
                        </a>
                    </div>`
                },
                "width": "30%"
            }
        ]
    });
    $('#tblData tbody').on('draw.dt', function () {
        $('#tblData tbody td').addClass('p-2');
    });
}


function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    })
}