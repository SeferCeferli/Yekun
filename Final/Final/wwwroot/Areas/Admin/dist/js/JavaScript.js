$(document).ready(function () {
    let i = 0;
    $('.plus').click(function (e) {
        e.preventDefault();
        $.ajax({
            url: "GetTags",
            type: "GET",
            dataType: "JSON",
            success: function (response) {
                console.log(response)
                i++;
                let tags = $('#tags1')
                let divItem = $('<div class="tags - item"></div>')
                let label = $('<label for="newsToTags[' + i + '].TagsId">Tags</label>')
                let divTags = $('<div class="mt-2"></div>')
                let select = $('<select name="newsToTags[' + i + '].TagsId" data-placeholder="Select your favorite actors" class="select2 w-full multiple"></select>')
                let defaultOption = $('<option selected="" disabled>Select Tags</option>')
                let deleteButton = $('<span class="deleteTag">x</span>');
                select.append(defaultOption)

                for (var j = 0; j < response.length; j++) {
                    let options = $('<option value="' + response[j].id + '" >' + response[j].name + '</option>')
                    select.append(options)
                }
                let hr = $('<hr style="margin:10px 0px" />')
                divItem.append(label)
                divItem.append(divTags)
                divTags.append(select)
                divItem.append(deleteButton)
                tags.append(divItem)
                tags.append(hr)

            },
            error: function () { },
            complete: function () {
                $('.select2').select2()
            },


        })

    })
    $(document).on('click', '.deleteTag', function () {
        console.log("hhavahvs")
        $(this).parent().remove();
        CalcI();
    });
})