﻿using Infraestructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public interface IRepositoryReservaAreasComunes
    {
        IEnumerable<RESERVA_AREA_COMUN> GetAreasComunes();
        RESERVA_AREA_COMUN GetReservaById(int id);
        RESERVA_AREA_COMUN Save(RESERVA_AREA_COMUN area);
    }
}