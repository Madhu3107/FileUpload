using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkUpload.Interfaces
{
    public interface IRetrieveImage
    {
        /// <summary>
        /// Retrieve One data from Db.
        /// The element ID can be configurable via config.
        /// </summary>
        BULK_UPLOAD RetrieveFixedData();

        /// <summary>
        /// Retrieves data corresponding to the specified Id.
        /// </summary>
        BULK_UPLOAD RetrieveAllData(int imgId);
    }
}
