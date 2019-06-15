using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Configurations.Seed
{
    /// <summary>
    /// Class containing hardcoded seed data for shelves
    /// </summary>
    public static class ShelfSeedData
    {
        public static Guid StorageHouse1Guid = new Guid("45B9B2E3-3FD7-4000-950A-781241C33656");
        public static Guid StorageHouse2Guid = new Guid("F722D8D7-405A-42FB-BDDA-4C69D648C3AB");

        public static Dictionary<Guid, string> ShelvesStorageHouse1Data = new Dictionary<Guid, string>()
        {
            { new Guid("28B762F2-9C41-4C0C-8546-5953861674E6"), "1A" },
            { new Guid("663FBE6A-91AF-49FB-94C3-700E1CB607FF"), "1B" },
            { new Guid("354F67F3-FAF9-4481-AA0E-497FAC62213F"), "1C" },
            { new Guid("5FBCF43E-E593-4F3B-B320-00384DB60D92"), "2A" },
            { new Guid("A8694E9A-B0E5-4FF9-BE07-2ABD77D288C1"), "2B" },
            { new Guid("D67A4D75-50A8-4291-B8C8-A278EA48900B"), "2C" },
            { new Guid("887B444E-BA8B-47C4-BBFA-05340D9B062E"), "3A" },
            { new Guid("C7C5EDD9-6CA6-43C8-883C-C61ABE66577E"), "3B" },
            { new Guid("3112EF18-8910-4E7F-9F2B-18DDE9B3C3EE"), "3C" },
            { new Guid("F3ED3308-7CA6-4789-B94D-41C9E1F239D5"), "3D" }
        };

        public static Dictionary<Guid, string> ShelvesStorageHouse2Data = new Dictionary<Guid, string>()
        {
            { new Guid("FBF32C64-DA20-463A-A6BC-2801F58C5215"), "1A" },
            { new Guid("699ABB29-FA4C-4DAC-98C3-5E23E29B5483"), "1B" },
            { new Guid("D4542C33-19FA-42D1-B62F-1742C0F4EFDF"), "1C" },
            { new Guid("FA18798D-911D-41BE-9F03-7FB89E4D7B17"), "2A" },
            { new Guid("936C889E-D905-476B-960A-41F0B7A81F6F"), "2B" },
            { new Guid("0FBC6908-74DC-4698-BB1B-BAD9774F0D0C"), "2C" },
            { new Guid("73DBD9E0-632F-4A20-B771-2E828EAA0AC3"), "3A" },
            { new Guid("9B71CD37-5A91-42E1-8597-81C4AF2F836B"), "3B" },
            { new Guid("E39A9714-E03A-41FE-B8B4-E2A2A76B9789"), "3C" },
            { new Guid("03853F6F-E1FE-4291-AC94-08F7BCADEAA3"), "3D" }
        };


    }
}
