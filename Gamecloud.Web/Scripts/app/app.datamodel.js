function AppDataModel() {
    var self = this;

    // Routes
    self.userInfoUrl = "/api/Me";
    self.siteUrl = "/";
    // Load the User Dashboard
    self.loadDashboardUrl = "/api/LoadDashboardViewModel";
    self.loadStreambotViewModel = "/api/LoadStreambotViewModel";

    // Route operations



    // Other private operations



    // Operations



    // Data
    self.returnUrl = self.siteUrl;

    // Data access operations
    self.setAccessToken = function (accessToken) {
        sessionStorage.setItem("accessToken", accessToken);
    };

    self.getAccessToken = function () {
        return sessionStorage.getItem("accessToken");
    };
}
