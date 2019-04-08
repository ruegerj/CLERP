using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Database.Entities.Abstract
{
    #region Enums used within the Db

    /// <summary>
    /// Different Roles covered in this application
    /// </summary>
    public enum RoleType
    {
        SysAdmin,
        Logistic,
        HeadOfLogistic,
        Finance,
        HeadOfFinance,
        Purchase,
        HeadOfPurchase,
        Sale,
        HeadOfSales,
        Management,
        Administration,
        HR,
        HeadOfHr,
        Production,
        HeadOfProduction
    }

    /// <summary>
    /// Different states a product can have
    /// </summary>
    public enum ProductState
    {
        InStock,
        Reserved,
        Sold,
        Defect
    }

    #endregion
}
