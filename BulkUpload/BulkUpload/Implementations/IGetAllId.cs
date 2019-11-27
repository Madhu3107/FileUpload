using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkUpload.Implementations
{
    public interface IGetAllId
    {
        /// <summary>
        /// Retrieves all the image id from database.
        /// </summary>
        List<int> GetId();
    }
}
