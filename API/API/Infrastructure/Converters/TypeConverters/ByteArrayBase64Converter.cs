using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Converters.TypeConverters
{
    /// <summary>
    /// Converts byte array to a base64 string
    /// </summary>
    public class ByteArrayBase64Converter : ITypeConverter<byte[], string>
    {
        public string Convert(byte[] source, string destination, ResolutionContext context)
        {
            return System.Convert.ToBase64String(source);
        }
    }
}
