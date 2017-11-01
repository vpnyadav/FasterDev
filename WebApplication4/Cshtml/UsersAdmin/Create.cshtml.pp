﻿@model $rootnamespace$.Models.RegisterViewModel
@using Faster.Notification

@{
    ViewBag.Title = "Create";
    Layout = "~/Views/Shared/_LayoutGentelella.cshtml";
}


<div class="row">
    <div class="col-md-12 col-sm-12 col-xs-12">
        @if (TempData["Aftersave"] != null)
        {
            Notification ns = TempData["Aftersave"] as Notification;
            <script>
                $(document).ready(function () {
                    new PNotify({
                        title: '@ns.MsgHeader',
                        text: '@ns.MsgText',
                        type: '@ns.MsgType',
                        styling: 'bootstrap3'
                    });
                });
            </script>
        }
    </div>
    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h3 class="pull-left">
                    Create New Item
                </h3>
                <div class="pull-right">
                    <a href="@Url.Action("Index")" class="btn bg-blue"><i class="fa fa-arrow-circle-left"></i> back to list</a>
                    <ul class="nav navbar-right panel_toolbox">
                        <li>
                            <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="x_content">
                @using (Ajax.BeginForm(new AjaxOptions { UpdateTargetId = "divInterestDeatils" }))
                {
                    <div id="divInterestDeatils">

                        @Html.AntiForgeryToken()

                        <div class="form-horizontal">
                            @Html.ValidationSummary(true, "", new { @class = "text-danger" })
                            <div class="form-group">
                                @Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" })
                                <div class="col-md-10">
                                    @Html.TextBoxFor(m => m.Email, new { @class = "form-control" })
                                </div>
                            </div>
                            <div class="form-group">
                                @Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" })
                                <div class="col-md-10">
                                    @Html.PasswordFor(m => m.Password, new { @class = "form-control" })
                                </div>
                            </div>
                            <div class="form-group">
                                @Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" })
                                <div class="col-md-10">
                                    @Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" })
                                </div>
                            </div>
                            <div class="form-group">
                                <label class="col-md-2 control-label">
                                    Select User Role
                                </label>
                                <div class="col-md-10">
                                    @foreach (var item in (SelectList)ViewBag.RoleId)
                                    {
                                    <input type="checkbox" name="SelectedRoles" value="@item.Value" class="checkbox-inline" />
                                    @Html.Label(item.Value, new { @class = "control-label" })
                                    }
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <input type="submit" class="btn btn-default" value="Create" />
                                </div>
                            </div>
                        </div>
                    </div>
                }
            </div>
        </div>
    </div>
</div>


@section Scripts {
    @Scripts.Render("~/bundles/jqueryval")
}
