function GetAllLocations()
{
    fetch('https://localhost:44372/Location/GetAllLocations')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#locations tbody tr').forEach(element => element.remove()); 
        let table = document.querySelector('#locations tbody'); 
        for (let i=0; i<result.length; i++) 
        {
            let row = table.insertRow(table.rows.length); 
            let cell0 = row.insertCell(0);
            cell0.innerHTML = result[i].name;

            let selectcell = row.insertCell(1);
            selectcell.innerHTML = '<input type="button" value="Select" class="btn btn-info" id="location'+i+'">';

        }
    });
}