using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using StockManagementSystem.DAL;
using StockManagementSystem.Models;

namespace StockManagementSystem.BLL
{ 
    
    public class CategorySetupManager
    {
        readonly CategorySetupRepository _categoryRepository = new CategorySetupRepository();

        public bool IsSave(Category category)
        {
            bool isSave = _categoryRepository.IsSave(category);
            return isSave;
        }

        public bool IsExist(Category category)
        {
            bool isExist = _categoryRepository.IsExist(category);
            return isExist;
        }

        public bool UpdateCategories(Category category)
        {
            bool isUpdate = _categoryRepository.UpdateCategories(category);
            return isUpdate;
        }

        public DataTable ShowCategories()
        {
            DataTable isShowCategory = _categoryRepository.ShowCategories();
            return isShowCategory;
        }
    }
}
