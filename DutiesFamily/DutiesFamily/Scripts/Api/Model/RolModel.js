function RolModel() {
    this.Roles = function (successCallback,failCallback) {
        $.get("/api/Rol/GetRol")
            .done(function (data) {
                successCallback(data);
            })
            .fail(function (data) {
                failCallback(data);
            });
    };

};