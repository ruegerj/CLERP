using CLERP.Business.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.Business.Pipe.Assembler
{
    /// <summary>
    /// Base class for any Assembler
    /// An assembler decouples the domain models from the api interface
    /// </summary>
    /// <typeparam name="TIn">Type of Dto object (Request or Response) which has to be assembled/dessembled</typeparam>
    /// <typeparam name="TOut">Type of the domain model the Dto has to be assembled/dessembled to/from</typeparam>
    public abstract class AssemblerBase<TIn, TOut> : IAssembler<TIn, TOut>
        where TIn : class
        where TOut : EntityBase
    {
        /// <summary>
        /// Implementations convert the passed object/dto with type <see cref="TIn"/> to a domain model with type <see cref="TOut"/>
        /// </summary>
        /// <param name="dto">Object which has to be converted to a domain model</param>
        /// <returns>The new assembled domain model object</returns>
        public abstract TOut Assemble(TIn dto);

        /// <summary>
        /// Implementations convert the passed domain model with type <see cref="TOut"/> to a Dto (Response or Request) with type <see cref="TIn"/>
        /// </summary>
        /// <param name="dto">Object which has to be converted to a Dto</param>
        /// <returns>The new assembled Dto object</returns>
        public abstract TIn Dessemble(TOut model);
    }
}
