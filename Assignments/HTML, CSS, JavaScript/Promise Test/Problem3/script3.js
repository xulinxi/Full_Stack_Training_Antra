function getData() {
    let p1 = fetch("https://fakerestapi.azurewebsites.net//api/v1/Authors").then(function (response) {
        return response.json();
    })

    p1.then(function (date) {
        console.log(p1);
        let tbody = document.querySelector("tbody");
        tbody.innerHTML = "";
        let length = data.length;
        for (var i = 0; i < length; i++) {
            let tr = "<tr> <td>" + data[i].id + "</td> <td>" + data[i].firstName + "</td> <td>" + data[i].lastName +  "</td> </tr>"
            tbody.innerHTML += tr;
        }

    }).catch(function (e) { })

}
