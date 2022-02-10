using System.ComponentModel;

namespace Infrastructure
{
    public enum Roles
    {
        /// <summary>
        /// Admin of System
        /// </summary>
        [Description("Admin")]
        Admin = 0,
        /// <summary>
        /// Create reporte from dataod system ex:log , sales,...
        /// </summary>
        [Description("Reporter")]
        Reporter = 1,
        /// <summary>
        /// Buyer
        /// </summary>
        [Description("Customer")]
        Customer = 2,
        /// <summary>
        /// Writer Product
        /// </summary>
        [Description("Writer")]
        Writer = 3,
        /// <summary>
        /// User BlockUser
        /// </summary>
        [Description("BlockUser")]
        BlockUser = 4,
        /// <summary>
        /// Transferor
        /// </summary>
        [Description("Transferor")]
        Transferor = 5,
        /// <summary>
        /// User
        /// </summary>
        [Description("User")]
        User = 6,
    }
}
