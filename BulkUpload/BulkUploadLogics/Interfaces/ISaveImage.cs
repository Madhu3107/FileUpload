using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkUploadLogics.Interfaces
{
    public interface ISaveImage
    {
        /// <summary>
        /// Save one image to the disk.
        /// </summary>
        bool PullImage();

        /// <summary>
        /// Save all the image to the disk.
        /// </summary>
        void PullAllImage();
    }
}
