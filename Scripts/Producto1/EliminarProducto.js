document.addEventListener("DOMContentLoaded", function () {

 

});
function Eliminar(Id,NombreProducto)
{
    alertify.confirm('Eliminar Proucto', '¿Desea Eliminar el Producto '+ NombreProducto+'?', function () {PeticionEliminar(Id)  }
        , function () { alertify.alert().close();  });
}
function PeticionEliminar(Id)
{
    
    fetch('/Producto1/Eliminar', {
        method: 'post',
        headers: {

            'Accept': 'application/json; charset=utf-8',
            'Content-Type': 'application/json;charset=UTF-8'
        },
        body: '{"id":' + Id+'}'
    }).then(function (response) {
        if (response.ok) { return response.text() }
        else { alertify.error('Error al procesar'); }

    }).then(function (Data) {
        if (Data != undefined) {
            let Resultado = JSON.parse(Data)
            if (Resultado.Result == 1) {
                alertify.success(Resultado.MensajePersonalizado)
                setTimeout(document.location.href = "../Producto1/Index", 8000000);
            }
            else
            {
                alertify.error(Resultado.MensajePersonalizado)
                console.log(Resultado.MensajeSistema)
            }
           
          
           
        }
        else {
            document.location.href = "../Producto1/Index";
        }
    })
    
}