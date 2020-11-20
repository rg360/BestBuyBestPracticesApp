using System;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace BestBuyBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");
            IDbConnection conn = new MySqlConnection(connString);
        }
    }
}


/*
 Exercise 1: We’ll start with Departments

DONE - Ignore appsettings.json file in .gitignore and commit 
DONE - Windows: gitignore
DONE - Windows: Show all files
DONE - Windows: create appsettings.json

DONE - Create appsettings.json in netcoreapp folder
DONE - Check git status to make sure appsettings is ignored
DONE - Add MySql.Data Nuget Package
DONE - Add the Dapper Nuget package
DONE - Add the Microsoft.Extensions.Configuration.Json Nuget package
----------
DONE - Make sure your config code is in your main method
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");
IDbConnection conn = new MySqlConnection(connString);
DONE - Create Department class
DONE - Create IDepartmentRepository interface
DONE - Create DapperDepartmentRepository class
DONE - Create GetAllDepartments Method
DONE - Create InsertDepartment Method
*/
