function UserModel() {
    this.CreateUser = function (newUser,successCallback,failCallback) {
        $.post("", newUser).done(function (data) {
            successCallback(data);
        }).fail(function () {
            failCallback();
        });
        

    };
}