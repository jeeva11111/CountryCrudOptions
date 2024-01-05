



$(document).ready(function () {
    $('#Country').change(function () {
        $.getJSON('/User/StateList/' + $('#Country').val(), function (data) {
            var items = '<option>Select a State</option>';
            $.each(data, function (i, state) {
                items += "<option value='" + state.Value + "'>" + state.Text + "</option>";
            });
            $('#State').html(items);
        });
    });

    $('#State').change(function () {
        $.getJSON('/User/Citylist/' + $('#State').val(), function (data) {
            var items = '<option>Select a City</option>';
            $.each(data, function (i, city) {
                items += "<option value='" + city.Value + "'>" + city.Text + "</option>";
            });
            $('#city').html(items);
        });
    });
})
