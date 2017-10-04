function DashboardViewModel(app, dataModel) {
    var self = this;

    //self.myHometown = ko.observable("");

    self.ob = {
        UserName: ko.observable()


    };

    Sammy(function () {
        this.get('#dashboard', function () {
            // Make a call to the protected Web API by passing in a Bearer Authorization Header
            $.ajax({
                method: 'get',
                url: app.dataModel.loadDashboardUrl,
                contentType: "application/json; charset=utf-8",
                headers: {
                    'Authorization': 'Bearer ' + app.dataModel.getAccessToken()
                },
                success: function (data) {
                    self.ob.UserName('Welcome to your Dashboard  ' + data.UserName);
                }
            });
        });
        this.get('/', function () { this.app.runRoute('get', '#dashboard'); });
    });

    return self;
}

app.addViewModel({
    name: "Dashboard",
    bindingMemberName: "dashboard",
    factory: DashboardViewModel
});
