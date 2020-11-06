var Roads = Roads || {};

Roads.getElementProperties = (element) => {

    var el = $(element);
    if (!el.length) {
        return null;
    }
    el = el.first();

    var res = {
        WindowProperties: {
            WindowHeight: window.innerHeight,
            WindowWidth: window.innerWidth,
        },
        AbsoluteTop: el.offset().top,
        AbsoluteLeft: el.offset().left,
        Width: el.width(),
        Height: el.height()
    };
    return res;
};

Roads.setElementHeight = (element, height) => {
    $(element).outerHeight(height, true);
};

Roads.subscribeToWindowSizeChange = (netObj) => {
    var resizeTimer;
    $(window).resize(function() {
        clearTimeout(resizeTimer);
        resizeTimer = setTimeout(() => {
                netObj.invokeMethodAsync("WindowSizeChanged",
                    {
                        WindowHeight: window.innerHeight,
                        WindowWidth: window.innerWidth,
                    });
            },
            100);
    });
}

Roads.setWindowTitle = (title) => { document.title = title; };
