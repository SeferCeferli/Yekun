$(document).ready(function () {
    let i = 0;
    $('.plus').click(function (e) {
        e.preventDefault();

        /*
                <div class="mt-3" id="tags1" >
                    <span class="plus">+</span>
                    <div class="tags-item">
                        <label asp-for="newsToTags[0].TagsId">Tags</label>
                        <div class="mt-2">
                            <select asp-for="newsToTags[0].TagsId" asp-items="@(new SelectList(ViewBag.Tags,"Id","Name"))" data-placeholder="Select your favorite actors" class="select2 w-full multiple">
                                <option selected="" disabled>Select Tags</option>
                            </select>
                        </div>
                    </div>
                    <hr style="margin:10px 0px" />

                    <option value="8" data-select2-id="12">Sports</option>
                </div>
         */
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
                let select = $('<select name="newsToTags['+i+'].TagsId" data-placeholder="Select your favorite actors" class="select2 w-full multiple"></select>')
                let defaultOption = $('<option selected="" disabled>Select Tags</option>')
                select.append(defaultOption)

                for (var j = 0; j < response.length; j++) {
                    let options = $('<option value="' + response[j].id + '" >' + response[j].name + '</option>')
                    select.append(options)
                }
                let hr = $('<hr style="margin:10px 0px" />')
                divItem.append(label)
                divItem.append(divTags)
                divTags.append(select)

                tags.append(divItem)
                tags.append(hr)

            },
            error: function () { },
            complete: function () {
                $('.select2').select2()
            },
        })
    })
})