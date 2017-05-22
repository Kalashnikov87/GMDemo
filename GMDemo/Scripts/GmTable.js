var faClientProductIndexService = function() {

    function getDataFromSource() {
        $.ajax({
            type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "/Gm/GetGmData",
            data: null,
            cache: false,
            success: function(data) {
                populateGrid(data);
            },
            error: function(xhr, textStatus, error) {
                console.log(xhr.statusText);
                console.log(textStatus);
                console.log(error);
            }
        });
    }

    //builds the initial tiles
    function populateGrid(data) {
        var products = data;

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
                pageSizes: true,
                input: true,
                numeric: false
            },
            columns: [
                "MachineName",
                { field: "MachineDescription", title: "Machine Description" },
                { field: "Amount", title: "Amount" },
                { field: "CostPerUnit", title: "Cost Per Unit", format: "{0:c}" },
                { field: "Total", title: "Total", format: "{0:c}" },
                { command: ["edit", "destroy"], title: "&nbsp;", width: "250px;" }
            ]
        });
    }


    //fire calls off here initially
    $(function() {
        getDataFromSource();
    });

    return {
        getDataFromSource: getDataFromSource,
        populateGrid: populateGrid
    };
}($);