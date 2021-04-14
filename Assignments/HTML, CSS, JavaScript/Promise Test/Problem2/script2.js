function getData() {
    let p1 = fetch("https://fakerestapi.azurewebsites.net//api/v1/Books").then(function (response) {
        return response.json();
    })

    p1.then(function (date) {
        console.log(p1);
        let tbody = document.querySelector("tbody");
        tbody.innerHTML = "";
        let length = data.length;
        for (var i = 0; i < length; i++) {
            let tr = "<tr> <td>" + data[i].id + "</td> <td>" + data[i].title + "</td> <td>" + data[i].description + "</td> <td>" + data[i].pageCount + "</td> <td>" + data[i].excerpt + "</td> <td>" + data[i].publishDate + "</td> </tr>"
            tbody.innerHTML += tr;
        }

    }).catch(function (e) { })

}
