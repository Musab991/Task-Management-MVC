
const FastAnimation = 100;
const LoaderSelector = "#MainLoader";

function showLoader() {
    $(LoaderSelector).fadeIn(FastAnimation);
}

function hideLoader() {
    $(LoaderSelector).fadeOut(FastAnimation);
}

function buildFetchOptions(method, data, options) {
    let finalOptions = Object.assign({
        method: method,
        credentials: "include",
        headers: {
            "X-Requested-With": "XMLHttpRequest"
        }
    }, options || {});

    if (data instanceof FormData) {
        finalOptions.body = data;
    }
    else if (data != null) {
        finalOptions.headers["Content-Type"] = "application/json";
        finalOptions.body = JSON.stringify(data);
    }

    return finalOptions;
}

async function fetchPost(url, data = null, options = {}) {
    showLoader();

    try {
        const fetchOptions = buildFetchOptions("POST", data, options);

        const response = await fetch(url, fetchOptions);

        if (!response.ok)
            throw new Error("Server Error: " + response.status);

        return await response.json();
    }
    catch (err) {
        console.error("fetchPost error:", err);
        return null;
    }
    finally {
        hideLoader();
    }
}
async function fetchGet(url, options = {}) {
    showLoader();

    try {
        const fetchOptions = buildFetchOptions("GET", null, options);

        const response = await fetch(url, fetchOptions);

        if (!response.ok)
            throw new Error("Server Error: " + response.status);

        return await response.json();
    }
    catch (err) {
        console.error("fetchGet error:", err);
        return null;
    }
    finally {
        hideLoader();
    }
}
