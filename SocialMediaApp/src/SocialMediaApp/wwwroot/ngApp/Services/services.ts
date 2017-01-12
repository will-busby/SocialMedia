namespace SocialMediaApp.Services {
    export class ModalService {
        constructor(public $uibModal: ng.ui.bootstrap.IModalService) { }

        public openModal(html, movieId) {
            this.$uibModal.open({
                templateUrl: `/ngApp/views/modalViews/${html}`,
                controller: SocialMediaApp.Controllers.ModalController,
                controllerAs: 'modal',
                size: 'md',
                resolve: {
                    movieId: () => movieId
                }
            });
        }
    }
    angular.module("SocialMediaApp").service("ModalService", ModalService);
}