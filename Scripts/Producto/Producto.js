var tbProducto;
var ArrValidaFormulario = [];


document.addEventListener("DOMContentLoaded", function () {
    $('#example-select-all').on('click', function () {
        var rows = tbMateria.rows({ 'search': 'applied' }).nodes();
        $('input[type="checkbox"]', rows).prop('checked', this.checked);
    });

    $('#myModal').on('shown.bs.modal', function () {
        $('#myInput').trigger('focus')
    })


    ObtenerProductos();

});

function ObtenerProductos()
 {
    fetch("/api/ProductoApi/")
        .then(response => response.json())
        .then(MateriasJson => { TablaProductos(MateriasJson) });

}
function TablaProductos(Data) {
    if (tbProducto === undefined) {

    }
    else {
        tbProducto.destroy();
    }
    tbProducto = $('#tbProductos').DataTable({

        data: Data,
        columns: [
            { "data": null, defaultContent: '' },
            { "data": "Nombre" },
            { "data": "RestriccionEdad" },
            { "data": "Precio" },
            { "data": "Compañia" },
            
       

        ],
        order: [[1, "asc"]],
        columnDefs: [
            {
                orderable: false,
                className: 'select-checkbox',
                targets: 0,
                className: 'dt-body-center',
                render: function (data, type, full, meta) {
                    return '<input type="checkbox" name="id[]" value="' + $('<div/>').text(data.Id).html() + '">';
                }
            },
        ], retrieve: true,
        select: {
            style: 'os',
            selector: 'td:first-child'
        }
    });
    var div = document.getElementById('divTbProducto');
    div.style.visibility = 'visible';
    Ocultarspine();
}

function GuardarProducto()
{
    Mostrarspiner();
    var validacion = ValidaFormulario()
    let mensaje = "";
    if (validacion.length != 0) {
        for (i = 0; i < validacion.length; i++) {
            mensaje = mensaje + "-" + validacion[i].Mensaje + "</br>"
        }
        alertify.warning(mensaje)

    }
    else
    {
        let Nombre = document.getElementById('txtNombre').value
        let Descripcion = document.getElementById('txtDescripcion').value
        let RestriccionEdad = document.getElementById('txtRestriccionEdad').value
        let Compania = document.getElementById('txtCompania').value
        let Precio = document.getElementById('txtPrecio').value
       
        var ObjGuardar = { Nombre: Nombre, Descripcion: Descripcion, RestriccionEdad: RestriccionEdad, Compañia:Compania,Precio:Precio};
        fetch("/api/ProductoApi/", {
            method: 'post',
            headers: {

                'Accept': 'application/json; charset=utf-8',
                'Content-Type': 'application/json;charset=UTF-8'
            },
            body: JSON.stringify(ObjGuardar)
        }).then(function (response) {
            if (response.ok) {
                alertify.success("Se agrego correctamente el producto")
                LimpiarModelGuardar();
               
                $('#ModalAgregarProducto').modal('hide')
                ObtenerProductos();
                Ocultarspine();

            }


            else {
                alertify.error('Error al gurardar producto');
            }

        });
       
    }



   
    
}
document.getElementById("btnAgregar").addEventListener("click", function () {

    $('#ModalAgregarProducto').modal()
});
function ValidaFormulario() {
    if (ArrValidaFormulario.length != 0) {
        ArrValidaFormulario.length = 0
    }
   
    if (document.getElementById("txtNombre").value == "") {
        ArrValidaFormulario.push({ Mensaje: "Campo Nombre Requerido" })
    }
    if (document.getElementById("txtDescripcion").value == "") {
        ArrValidaFormulario.push({ Mensaje: "Campo Descripcion Requerido" })
    }
    if (document.getElementById("txtRestriccionEdad").value == "") {
        ArrValidaFormulario.push({ Mensaje: "Campo Restriccion Edad Requerido" })
    }
    if (document.getElementById("txtCompania").value == "") {
        ArrValidaFormulario.push({ Mensaje: "Campo Compañia Requerido" })
    }
    if (document.getElementById("txtPrecio").value == "") {
        ArrValidaFormulario.push({ Mensaje: "Campo Precio Requerido" })
    }
   
    return ArrValidaFormulario;

}
function LimpiarModelGuardar() {
    document.getElementById("txtNombre").value = ""
    document.getElementById("txtDescripcion").value = ""
    document.getElementById("txtRestriccionEdad").value = ""
    document.getElementById("txtCompania").value = ""
    document.getElementById("txtPrecio").value = ""

}