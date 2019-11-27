using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using BulkUpload.Interfaces;

namespace BulkUpload.Implementations
{
    public class RetrieveImage : IRetrieveImage, IGetAllId
    {
        /// <summary>
        /// Retrieve One data from Db.
        /// The element ID can be configurable via config.
        /// </summary>
        public BULK_UPLOAD RetrieveFixedData()
        {
            int fileId = int.Parse(ConfigurationManager.AppSettings["SingleFile"]);
            BulkUploadDBContext db = new BulkUploadDBContext();
            BULK_UPLOAD output = db.BULK_UPLOAD.Where(img => img.IMG_ID == fileId).FirstOrDefault();
            return output;
        }

        /// <summary>
        /// Retrieves data corresponding to the specified Id.
        /// </summary>
        public BULK_UPLOAD RetrieveAllData(int imgId)
        {
            BulkUploadDBContext db = new BulkUploadDBContext();
            BULK_UPLOAD output = db.BULK_UPLOAD.Where(img => img.IMG_ID == imgId).FirstOrDefault();

            return output;
        }

        /// <summary>
        /// Retrieves all the image id from database.
        /// </summary>
        public List<int> GetId()
        {
            BulkUploadDBContext db = new BulkUploadDBContext();
            List<int> imgId = db.BULK_UPLOAD.Select(x => x.IMG_ID).ToList();

            return imgId;
        }
    }
}
