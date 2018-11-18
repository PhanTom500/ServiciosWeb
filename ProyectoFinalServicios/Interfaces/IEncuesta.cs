﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using Modelo;

namespace Interfaces
{
    [ServiceContract]
    public interface IEncuesta
    {
        [OperationContract]
        List<EncuestaModel> Listar();
    }
}
