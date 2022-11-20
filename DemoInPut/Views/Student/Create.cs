<h2>Create new Student</h2>
<form asp-action="Create">
    <label>Student ID</label>
    <input type="number" name="StudentId"  >
    <br>
    <br>
    <label>Student Name</label>
    <input type="text" name="StudentName"  >
    <br>
    <Br>
    <label> Age</label>
    <input type="number" name="Age"  >
    <br>

    
    <input type="submit" value="Send">
    
</form>
<h2>@ViewBag.Sinhvien</h2>