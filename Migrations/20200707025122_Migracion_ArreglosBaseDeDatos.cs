using Microsoft.EntityFrameworkCore.Migrations;

namespace SegundoParcial.Migrations
{
    public partial class Migracion_ArreglosBaseDeDatos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                table: "ProyectosDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "ProyectoId",
                table: "ProyectosDetalle",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TareaId",
                table: "ProyectosDetalle",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Tarea" },
                values: new object[] { 1, "Analisis" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Tarea" },
                values: new object[] { 2, "Dise;o" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Tarea" },
                values: new object[] { 3, "Desarrollo" });

            migrationBuilder.InsertData(
                table: "Tareas",
                columns: new[] { "TareaId", "Tarea" },
                values: new object[] { 4, "Prueba" });

            migrationBuilder.CreateIndex(
                name: "IX_ProyectosDetalle_TareaId",
                table: "ProyectosDetalle",
                column: "TareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                table: "ProyectosDetalle",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectosDetalle_Tareas_TareaId",
                table: "ProyectosDetalle",
                column: "TareaId",
                principalTable: "Tareas",
                principalColumn: "TareaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                table: "ProyectosDetalle");

            migrationBuilder.DropForeignKey(
                name: "FK_ProyectosDetalle_Tareas_TareaId",
                table: "ProyectosDetalle");

            migrationBuilder.DropIndex(
                name: "IX_ProyectosDetalle_TareaId",
                table: "ProyectosDetalle");

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tareas",
                keyColumn: "TareaId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "TareaId",
                table: "ProyectosDetalle");

            migrationBuilder.AlterColumn<int>(
                name: "ProyectoId",
                table: "ProyectosDetalle",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_ProyectosDetalle_Proyectos_ProyectoId",
                table: "ProyectosDetalle",
                column: "ProyectoId",
                principalTable: "Proyectos",
                principalColumn: "ProyectoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
