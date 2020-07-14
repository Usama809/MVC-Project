﻿@ModelType _54_Login_Signup.Employee
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Employee</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Name)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Name)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Designation)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Designation)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Salary)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Salary)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.Id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
