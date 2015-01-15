<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CRUDADO.Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Books CRUD Application</title>
    <style>
     a  { font-weight:700; color:red;font-size:12pt}
    </style>
</head>
<body>
<h2>Books CRUD Application</h2>
This application shows how to perform Create, Retrieve, Update and Delete operations on BOOKS table through ADO.NET. 
<p />
ASP.NET pages access the BOOKS table through SQL using ADO.NET.
<p />

<a href="addbook.aspx">Add New Book</a>
<p />
<a href="updatebook.aspx">Update Book</a>
<p />
<a href="deletebook.aspx">Delete Book</a>
<p />
<a href="listbooks.aspx">List Books</a>
</body>
</html>

