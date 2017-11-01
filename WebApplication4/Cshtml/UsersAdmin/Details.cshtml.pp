﻿@model $rootnamespace$.Models.ApplicationUser

@{
    ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_LayoutGentelella.cshtml";
}


<div class="row">
    <div class="col-md-12 col-sm-12 col-xs-12">
        <div class="x_panel">
            <div class="x_title">
                <h3 class="pull-left">
                    Details Discription
                </h3>
                <div class="pull-right">
                    <a href="@Url.Action("Index")" class="btn bg-blue"><i class="fa fa-arrow-circle-left"></i> back to list</a>
                    <a name="Refresh" href="@Url.Action("Edit",new { id = Model.Id })" class="btn bg-blue">
                        <i class="fa fa-edit" aria-hidden="true"></i>
                        Edit This Record
                    </a>
                    <ul class="nav navbar-right panel_toolbox">
                        <li>
                            <a class="collapse-link"><i class="fa fa-chevron-up"></i></a>
                        </li>
                        <li>
                            <a class="close-link"><i class="fa fa-close"></i></a>
                        </li>
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="x_content">
                <div class="dl-details">
                    <dl class="dl-horizontal">
                        <dt>
                            @Html.DisplayNameFor(model => model.UserName)
                        </dt>
                        <dd>
                            @Html.DisplayFor(model => model.UserName)
                        </dd>
                        </dl>
                </div>
            </div>
        </div>
    </div>
</div>
