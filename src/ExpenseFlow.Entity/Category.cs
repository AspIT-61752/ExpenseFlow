using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseFlow.Entity
{
    public class Category
    {
        #region Fields

        private int categoryId;
        private string categoryName;

        #endregion

        #region Constructors

        //public Category()
        //{
        //}

        public Category(int categoryId, string categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }

        #endregion

        #region Properties

        public int CategoryId { get => categoryId; set => categoryId = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        #endregion
    }
}
