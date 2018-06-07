using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebConvertor.Services
{
    public class ConverterServices
    {
        private readonly ConverterContext context;

        public ConverterServices(ConverterContext context)
        {
            this.context = context;
        }

    }
}
