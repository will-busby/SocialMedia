var SocialMediaApp;
(function (SocialMediaApp) {
    angular.module("SocialMediaApp", ['ui.router', 'ui.bootstrap']).config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
        $stateProvider
            .state('Home', {
            url: '/home',
            templateUrl: 'ngApp/views/home.html',
            controller: SocialMediaApp.Controllers.HomeController,
            controllerAs: 'controller'
        });
        $urlRouterProvider.otherwise('/home');
        $locationProvider.html5Mode(true);
    });
})(SocialMediaApp || (SocialMediaApp = {}));
//# sourceMappingURL=app.js.map