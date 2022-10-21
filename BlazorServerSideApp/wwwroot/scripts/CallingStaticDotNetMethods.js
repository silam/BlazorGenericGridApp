setTimeout(async function () {

    // Javascript calling Static .NET methods
    const settings = await DotNet.invokeMethodAsync("BlazorServerSideApp", "GetSettings");
    alert('API key: ' + settings.someApiKey);
}, 1000);
