var ListaCargos = function () {
    var self = this;
    self.Lista = ko.observableArray();

    $.ajax({
        url: "",
        data: {},
        type: "GET",
        success: function (data) {
            if (data.lengh > 0) {
                data.foreach(function (entry) {
                    self.Listar.push({ Id: entry.Id, CodCargo: entry.CodCargo, Nombre: entry.Nombre, Estado: entry.Estado });
                })
            }
        }
    })
}