using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BulkUploadLogics.Interfaces;
using System;
using BulkUpload.Interfaces;
using BulkUpload.Implementations;
using System.Collections.Generic;
using BulkUpload;

namespace BulkUploadLogics.Implementations
{
    public class SaveImage : ISaveImage
    {
        private readonly IRetrieveImage _retrieveImage;

        private readonly IGetAllId _getAllId;

        public SaveImage(IRetrieveImage retrieveImage, IGetAllId getAllId)
        {
            this._retrieveImage = retrieveImage;
            this._getAllId = getAllId;
        }

        /// <summary>
        /// Save one image to the disk.
        /// </summary>
        public bool PullImage()
        {
            var imageDetails = _retrieveImage.RetrieveFixedData();
            byte[] bytes = imageDetails.IMG;
            string strBase64 = Convert.ToBase64String(bytes);

            return SaveFile(strBase64);
        }

        /// <summary>
        /// Save all the image to the disk.
        /// </summary>
        public async void PullAllImage()
        {
            List<int> imgId = _getAllId.GetId();
            var task = imgId.Select(PullMultipleFile).ToList();

            var result = await Task.WhenAll(task);
        }

        /// <summary>
        /// Saving file to the local disk.
        /// </summary>
        private static bool SaveFile(string imageString)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["FilePath"];

                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                string imageName = DateTime.Now.ToFileTime().ToString() + ".jpg";
                string imagePath = Path.Combine(path, imageName);

                byte[] imageBytes = Convert.FromBase64String(imageString);

                File.WriteAllBytes(imagePath, imageBytes);

                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Asynchronously save all the images to the disk.
        /// </summary>
        private Task<bool> PullMultipleFile(int id)
        {
            BULK_UPLOAD imageDetails = _retrieveImage.RetrieveAllData(id);
            byte[] bytes = imageDetails.IMG;
            string strBase64 = Convert.ToBase64String(bytes);

            if(SaveFile(strBase64))
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }            
        }
    }
}
