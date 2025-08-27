﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Warehouse.Backend.Migrations;

/// <inheritdoc />
public partial class Initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "ExchangeCredentials",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                Exchange = table.Column<int>(type: "INTEGER", nullable: false),
                ApiKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                Passphrase = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                SecretKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                IsDemo = table.Column<bool>(type: "INTEGER", nullable: false),
                CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ExchangeCredentials", x => x.Id);
            });

        migrationBuilder.CreateIndex(
            name: "IX_ExchangeCredentials_Exchange",
            table: "ExchangeCredentials",
            column: "Exchange",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "ExchangeCredentials");
    }
}
