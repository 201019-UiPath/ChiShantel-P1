function GetAllProducts()
{
    fetch('https://localhost:44372/Location/GetAllProducts')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#products tbody tr').forEach(element => element.remove()); 
        let table = document.querySelector('#products tbody'); 
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); 
            let cell0 = row.insertCell(0);
            cell0.innerHTML = result[i].productid;

            let cell1 = row.insertCell(1);
            cell1.innerHTML = result[i].name;

            let cell2 = row.insertCell(2);
            cell2.innerHTML = result[i].cost;

        }
    });
}