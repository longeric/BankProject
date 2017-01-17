var CheckingController = function ($scope) {
    $scope.AccountNo = "71755556222";
    $scope.message = "1000.12";

    $scope.gridOption =
        {
            columnDefs: [
                { DisplayName: "Account No" },
                { DisplayName: "statement" }
            ]

        };

}