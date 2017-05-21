var faClientProductIndexService = function () {

    function getDataFromSource() {
        $.ajax({
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "/Controller/Search",
            data: null,
            cache: false,
            success: function () {
               
            },
            error: function () {
                Console.log("Error occured in data retreval");
            }
        });
    }

    //builds the initial tiles
    function populateGrid() {

        var products = [
            { "MachineName": "New", "MachineDescription": "10", "Amount": "12", "CostPerUnit": "10", "Total": "10"},
            { "MachineName": "New", "MachineDescription": "10", "Amount": "12", "CostPerUnit": "10", "Total": "10" },
            { "MachineName": "New", "MachineDescription": "10", "Amount": "12", "CostPerUnit": "10", "Total": "10" }
        ];


        $("#grid").kendoGrid({
            dataSource: {
                data: products,
                schema: {
                    model: {
                        fields: {
                            MachineName: { type: "string" },
                            MachineDescription: { type: "string" },
                            Amount: { type: "number" },
                            CostPerUnit: { type: "number" },
                            Total: { type: "number" }
                        }
                    }
                },
                pageSize: 20
            },
            height: 500,
            toolbar: ["create"],
            editable: "inline",
            scrollable: true,
            sortable: true,
            filterable: true,
            pageable: {
                input: true,
                numeric: false
            },
            columns: [
                "MachineName",
                { field: "MachineDescription", title: "Machine Description" },
                { field: "Amount", title: "Amount", format: "{0:c}" },
                { field: "CostPerUnit", title: "Cost Per Unit", format: "{0:c}" },
                { field: "Total", title: "Total", format: "{0:c}" }
            ]
        });
    }
    

    //fire calls off here initially
    $(function () {
        populateGrid();
    });

    return {
        getDataFromSource: getDataFromSource,
        populateGrid: populateGrid
    };
}($);