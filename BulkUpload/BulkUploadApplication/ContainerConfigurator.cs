using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BulkUploadLogics.Implementations;
using BulkUploadLogics.Interfaces;
using BulkUpload.Implementations;
using BulkUpload.Interfaces;

namespace BulkUploadApplication
{
    public static class ContainerConfigurator
    {
        public static ContainerBuilder Configure()
        {
            var iocContainer = new ContainerBuilder();
            iocContainer.RegisterType<SaveImage>().As<ISaveImage>();
            iocContainer.RegisterType<RetrieveImage>().As<IRetrieveImage>();
            iocContainer.RegisterType<RetrieveImage>().As<IGetAllId>();
            return iocContainer;
        }
    }
}
