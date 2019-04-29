using CLERP.Domain.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Domain.Pipe.Assembler
{
    public interface IAssembler<TIn, TOut> 
        where TIn : class
        where TOut : class
    {
        TOut Assemble(TIn dto);
        TIn Dessemble(TOut model);
    }
}
