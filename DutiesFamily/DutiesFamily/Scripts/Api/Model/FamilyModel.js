/// <reference path="../../jquery-1.11.3.js" />


//modelo para realizar actividades con familias
function FamilyModel() {
    this.LoginFamily = function (family,successCallback,failCallback) {
        $.post("/api/family/login", family).done(function (data) {
           successCallback(data);
        }).fail(function () {
            failCallback();
        });

    };

    this.RegisterFamily = function (family, successCallback, failCallback) {
        $.post("/api/family/RegisterFamily", family).done(function (data) {
            successCallback(data);
        }).fail(function () {
            failCallback();
        });
    };
};