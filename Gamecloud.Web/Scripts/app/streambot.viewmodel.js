﻿function StreambotViewModel(app, dataModel) {
    var self = this;

   
    self.ob = {
        Hometown: ko.observable()


    };

    self.PopulateData = function(data) {



    };

    Sammy(function () {
        this.get('#streambot' +
            '', function () {
            // Make a call to the protected Web API by passing in a Bearer Authorization Header
            $.ajax({
                method: 'get',
                url: app.dataModel.loadStreambotViewModel,
                contentType: "application/json; charset=utf-8",
                headers: {
                    'Authorization': 'Bearer ' + app.dataModel.getAccessToken()
                },
                success: function (data) {
                    //self.ob.Hometown('Your Hometown is : ' + data.hometown);
                }
            });
        });
        this.get('/', function () { this.app.runRoute('get', '#streambot'); });
    });


    //self.init();
    return self;


}

app.addViewModel({
    name: "Home",
    bindingMemberName: "home",
    factory: HomeViewModel
});
