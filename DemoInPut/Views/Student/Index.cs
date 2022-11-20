<table class="table border">
    <tr>
        <th>
            <label>Student ID</label>
        </th>
        <th>
            <label>Student Name</label>
        </th>
         <th>
            <label>Age</label>
        </th>
    </tr>
    @foreach (var item in ViewData["Student"] as List<Student>)
    {
        <tr>
            <td>@item.StudentID</td>>
            <td>@item.StudentName</td>
            <td>@item.Age</td>
        </tr>
    }
</table>