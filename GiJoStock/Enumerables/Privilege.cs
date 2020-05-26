using System.ComponentModel;

namespace GiJoStock
{
    public enum Privilege
    {
        [Description("Permiso para Módulo de Productos")]
        ProductModule,

        [Description("Permiso para Módulo de Entrada")]
        EntryModule,

        [Description("Permiso para Módulo de Facturación")]
        InvoiceModule,

        [Description("Permiso para Módulo de Historico")]
        HistoryModule,

        [Description("Permiso para Módulo de Usuario")]
        UserModule,

        [Description("Permiso para Módulo de Mantenimiento")]
        MaintenanceModule,

        [Description("Permiso para Módulo de Reporte")]
        ReportModule,

        [Description("Permiso para Módulo de Inventario")]
        InventoryModule,

        [Description("Permiso para Crear Usuarios")]
        CreateUser,

        [Description("Permiso para Editar Usuarios")]
        EditUser,
        
        [Description("Cambiar Contraseña de Usuario")]
        ResetPassword,

        [Description("Acceso para agregar producto")]
        CreateProduct,

        [Description("Agregar [categoría|almacén|suplidor|cliente]")]
        CreateEntity,

        [Description("Inhabilitar [categoría|almacén|suplidor|cliente|producto]")]
        DisableEntity,

        //[Description("Acceso realizar transferencia de Stock entre almacenes")]
        //TransferWarehouse,
    }
}