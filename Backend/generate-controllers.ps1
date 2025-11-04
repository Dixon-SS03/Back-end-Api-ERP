$models = @("Usuario", "Role", "Horario", "Pago", "Asistencia","Categoria","DatosEmpleado","DetalleFactura","Presupuesto","Inventario","Nomina","Producto","Puesto","Factura") 
foreach ($model in $models) {
    dotnet aspnet-codegenerator controller `
      -name "${model}sController" `
      -api `
      -m $model `
      -dc AppDbContext `
      -outDir Controllers
}
