namespace SocialMediaApp {
    angular.module("SocialMediaApp", ['ui.router', 'ui.bootstrap']).config((
        $stateProvider: ng.ui.IStateProvider,
        $urlRouterProvider: ng.ui.IUrlRouterProvider,
        $locationProvider: ng.ILocationProvider
    ) => {
        $stateProvider
            .state('Home', {
                url: '/home',
                templateUrl: 'ngApp/views/home.html',
                controller: SocialMediaApp.Controllers.HomeController,
                controllerAs: 'controller'
            })

        $urlRouterProvider.otherwise('/home');
        $locationProvider.html5Mode(true);
    })
}