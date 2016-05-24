const LIST_OF_THESAURUS = ['industries', 'levels', 'locations', 'languages',
    'departments', 'tags', 'skills'];
export default function CandidateController(
   $scope,
   $translate,
   CandidateService,
   ValidationService,
   FileUploaderService,
   ThesaurusService
   ) {
   'ngInject';

   const vm = $scope;
   vm.saveCandidate = saveCandidate;
   vm.keys = Object.keys;

   ThesaurusService.getThesaurusTopicsGroup(LIST_OF_THESAURUS).then((data) => vm.thesaurus = data);

   vm.uploader = FileUploaderService.getFileUploader({maxSize: 1024000});

   function _onError() {
      vm.errorMessage = $translate.instant('CANDIDATE.ERROR');
   }

   function saveCandidate(form) {
      if (ValidationService.validate(form)) {
         CandidateService.saveCandidate(vm.candidate).catch(_onError);
      }
   }
}
