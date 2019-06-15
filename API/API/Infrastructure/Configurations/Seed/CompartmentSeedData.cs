using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CLERP.API.Infrastructure.Configurations.Seed
{
    /// <summary>
    /// Class containing hardcoded seed data for shelves
    /// </summary>
    public static class CompartmentSeedData
    {
        public const int StorageHouseRowAmount = 2;
        public const int StorageHouseColumnAmount = 5;

        #region Storage House 1

        public static Dictionary<string, Guid[,]> ShelfCompartmentsStorageHouse1Guids = new Dictionary<string, Guid[,]>()
        {
           { "1A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                   {
                        new Guid("ABB6045D-8399-4AB8-A01F-342AFF9EF97C"),
                        new Guid("A1982928-FDFE-418B-9048-7B9E852F4FC0"),
                        new Guid("DD428EC6-C2D8-4F7B-8FE0-D47498902D18"),
                        new Guid("849FBD0C-2E62-4F3C-AE99-E1EB577ED26E"),
                        new Guid("F333233F-C5DF-4118-9159-2C24EC00A4CE")
                   },
                   {
                        new Guid("3C39D84C-D2E9-45B3-AD2D-81E4F63CF28B"),
                        new Guid("EE51EBEE-70CD-4FF9-88A1-3872DE9EEF00"),
                        new Guid("E3EEBE0D-FFAA-41AC-A782-202BE34EDB0E"),
                        new Guid("0C9E45F9-A850-4EF0-BED5-58DC09EAA9FE"),
                        new Guid("12E0D393-E838-4D21-94BB-89A720E62CE6")
                   }
               }
           },
           { "1B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("1F37B217-E851-4199-8887-F5C3794E64C5"),
                        new Guid("E3ADE2A4-11B6-4F80-9B24-AAA33CCAFCEB"),
                        new Guid("FBC48B45-0A28-4A79-9FE9-A9435B5074F9"),
                        new Guid("B78F78A4-CFB6-4289-B97D-AF9B6218D16C"),
                        new Guid("C080FF0C-E992-4248-90A8-CC31E2FABAB8")
                   },
                   {
                        new Guid("9102DDC6-F15A-40E7-B670-7DDA6B8D7FD6"),
                        new Guid("8E54B763-F88E-4C1E-B9F0-8E0DA0420214"),
                        new Guid("9C817C17-DCF1-4BAA-87AF-9DCBFC765F14"),
                        new Guid("52FBC5F8-91C6-40B5-A9CF-69D1DD692FFA"),
                        new Guid("9FB887B5-2E40-4621-AEC8-C8D998330E87")
                   }
               }
           },
           { "1C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("D22FB7A0-AB28-48D2-8400-91ED84CD0BD4"),
                        new Guid("54C97D29-5C17-4217-A8E7-2C480210ED8F"),
                        new Guid("26509F76-2AB3-400C-B4BC-D2F6136A7AD6"),
                        new Guid("29621792-B943-42EA-BC11-084B0EF56CBA"),
                        new Guid("AB06E10E-6F58-471E-A2CA-E7D91A1114DD")
                   },
                   {
                        new Guid("1567881C-E8FA-46A8-AFA8-91E5CB970FF1"),
                        new Guid("4790DF97-E274-49B0-8471-97711FADEFB0"),
                        new Guid("7F7239D0-DA05-4875-B239-B7B5E3E2B4F0"),
                        new Guid("592364F4-B466-4318-BA08-4AFCBA6DEC4D"),
                        new Guid("D299ECB8-3F26-4FE2-A186-DE7764578D7E")
                   }
               }
           },
           { "2A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("B17516F5-F632-4F5B-B15D-C51A3F966A81"),
                        new Guid("F9B1CFA9-7A7A-4E09-932A-D6473B70C946"),
                        new Guid("582BE26B-732F-488F-B57D-2A9313FB051A"),
                        new Guid("A609A908-300A-4648-B144-AA627656F010"),
                        new Guid("7B9415C3-3BC6-442F-99DE-AAFA58CC331D")
                   },
                   {
                        new Guid("AA83B936-26C0-473C-A75C-5A296290BBD6"),
                        new Guid("397863B2-262E-4CFC-A2AA-1B7B05BB4667"),
                        new Guid("F1742AA9-2CB0-4146-B73A-9848D23E6863"),
                        new Guid("AF087E5E-92CD-40CD-B824-9AF679DE52BA"),
                        new Guid("3C0C6C17-FF10-49A1-8A42-3CE397178FE8")
                   }
               }
           },
           { "2B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("5811D942-9753-45B3-91D5-A38F8164E35D"),
                        new Guid("34339738-5BE1-452B-8AA8-D3D9CBA65D90"),
                        new Guid("F2C06824-1307-4417-93CD-F222EE28DD68"),
                        new Guid("C318F729-F995-4ABD-BC0A-D65F01492C23"),
                        new Guid("EA216318-FAF1-4F19-87DF-12F54D13CCF4")
                   },
                   {
                        new Guid("D4F5DE42-A168-4204-AAEF-98081BF10940"),
                        new Guid("B1BB0EAF-BA89-4583-A95C-EE933390AD63"),
                        new Guid("12F7F8AD-E81C-4F29-8BD0-FF6735691B48"),
                        new Guid("D20BA6AF-3029-4EC5-A2AF-61554CE4AF09"),
                        new Guid("2CDE2B2C-CFEC-409B-901D-F041A1034DBC")
                   }
               }
           },
           { "2C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                    {
                        new Guid("6DFA3CDD-B8DF-49AC-B712-31F220E247A7"),
                        new Guid("77134C25-81B6-4496-902F-2B94D78066B6"),
                        new Guid("B4A10C77-1C2E-45A4-9C5E-B6030A991A8A"),
                        new Guid("720D0ABB-431F-42A2-B80C-256F08C758E4"),
                        new Guid("661CEDAF-5C5A-4743-9141-CAE445D18760")
                    },
                    {
                        new Guid("9A597BAC-BDCF-4E59-98E5-809E99E21686"),
                        new Guid("38368942-6561-41E7-BAD8-144BCBE66BB7"),
                        new Guid("0C03E343-4E18-4403-BCC2-EB846998B007"),
                        new Guid("455A6CB9-28F0-4723-8C64-DF3F5A1CBAB3"),
                        new Guid("5B0A219C-9313-40B5-8844-7B5EB180BB0F")
                    }
               }
           },
           { "3A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("F8238885-1EE2-4195-9AA3-F86C27CB7589"),
                        new Guid("04B614EE-0214-4EBB-B2B8-B02AFC8F4C18"),
                        new Guid("94D7E3CF-EF7D-4CD3-9B7A-8EB7D4F893B1"),
                        new Guid("69D5EA8C-6B0D-4D08-AFED-60C30BEED9C0"),
                        new Guid("3C2C6FE8-A896-4163-B22B-E02E2C7783C4")
                    },
                    {
                        new Guid("53B320CC-8C82-40CD-9F8D-6AC6105917F2"),
                        new Guid("F3112842-E13A-4417-B088-0BBC3AA00D97"),
                        new Guid("F1670D96-082C-4D75-8D0C-9CD49772403D"),
                        new Guid("93114664-981B-464D-BC5D-B6FB840FE3FB"),
                        new Guid("995B64B1-EFF5-455C-B26E-F3852EEFDC36")
                    }
               }
           },
           { "3B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("0976F23E-47AE-4844-A3ED-1C536B497C95"),
                        new Guid("2C015CF2-C36F-4F8D-BF7F-CA91EF2BAA7E"),
                        new Guid("EFF45C57-65E6-4099-A482-051C873BD2A3"),
                        new Guid("90206926-8FF1-4329-ADB5-E44A3CF618F6"),
                        new Guid("2BF06A9D-A765-42D8-A980-EEE0A3F8C8C8")
                    },
                    {
                        new Guid("8ADD5C06-9E4F-4626-84EE-F3EA5F629718"),
                        new Guid("99A7CA27-D1E3-4D68-885E-9D06007B54BA"),
                        new Guid("8083EBC5-41AC-447F-ABBA-C61BB41CCE52"),
                        new Guid("8F088067-57AE-47FB-AB91-6FC4CD1FFFF0"),
                        new Guid("133BC0EC-644A-4887-A879-AC4609A2D4DB")
                    }
               }
           },
           { "3C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("92A1BF89-6AB3-481A-9031-7FBC2C704541"),
                        new Guid("52BDEB13-DB27-4908-AD8A-BC2B7E22F8B6"),
                        new Guid("7DF6EB3A-3D19-46D0-8216-07B550D8E88A"),
                        new Guid("F177977E-CC7F-4D01-9DDE-D39C083232FB"),
                        new Guid("E5FD37EB-E7A2-48BA-B752-8C7888592878")
                    },
                    {
                        new Guid("A0889075-2987-4B62-ADF0-6EE9E4FC0405"),
                        new Guid("93649C1B-175C-449C-91AC-460F96E23615"),
                        new Guid("7FDF2929-56D0-4AE0-AEB2-0CFD76B16E50"),
                        new Guid("648A06A1-3710-44E1-841A-350C9247F89D"),
                        new Guid("66D85773-8A7E-4407-B215-EA587F5F719E")
                    }
               }
           },
           { "3D", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("1D4F480E-6BE1-4011-AECD-E49AC9E613A7"),
                        new Guid("75F0BD0F-2212-4206-A20B-2DCE1CBAE11D"),
                        new Guid("5E2BCBEC-E2D8-4CA0-8DEB-7EA9136B1E62"),
                        new Guid("EAE4A4A9-B64B-4836-B6C2-E43CEF20B8A4"),
                        new Guid("BD02B247-FC67-4869-8CC8-27D0B2B40128")
                    },
                    {
                        new Guid("1991719B-3A99-4AF9-9967-1A16427DF931"),
                        new Guid("E8E57A28-6DEB-4F48-8500-95C476D5D129"),
                        new Guid("60BAFF62-6865-46F3-A5DF-29EC03D25910"),
                        new Guid("B1D627A1-944C-42DC-8F0E-284A6199302F"),
                        new Guid("BBBFB1E8-EEA9-4794-A951-FFB7BC6E99ED")
                    }
               }
           }
       };

        #endregion

        #region Storage House 2

        public static Dictionary<string, Guid[,]> ShelfCompartmentsStorageHouse2Guids = new Dictionary<string, Guid[,]>()
        {
           { "1A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                   {
                        new Guid("0EA7552A-94BF-42F6-A24C-EFF710506FD8"),
                        new Guid("5113D883-C0F8-4B2B-B2B9-7B63F27CB75F"),
                        new Guid("A3B01218-20F9-4910-8002-6C182CACAE54"),
                        new Guid("42DC0A36-7452-40D9-B209-3132A80CDD70"),
                        new Guid("F8043CB7-123B-42ED-9D84-916327E51288")
                   },
                   {
                        new Guid("52335787-B378-4ADE-A58A-71A9CBB81DFC"),
                        new Guid("7F56412B-00CB-4F15-A810-F30E5A477724"),
                        new Guid("ED013250-F02F-43A5-8AB5-B6D197159D20"),
                        new Guid("F2DC1A47-E658-4F78-8117-A9ACBFD416CE"),
                        new Guid("ACC497C3-C111-45AC-8F40-36B2B572D5B7")
                   }
               }
           },
           { "1B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("51DBBFE2-6982-44BA-B87B-1B6BB3CCFD9F"),
                        new Guid("2FDCCAAE-0557-49AE-8397-31A20024CF59"),
                        new Guid("F3710E61-316A-4324-8014-A091FBC97F0F"),
                        new Guid("38424167-E621-4E79-B224-91FCF67F353C"),
                        new Guid("29DFACEC-8BBB-4606-9FFA-EC6FF0CD8C8B")
                   },
                   {
                        new Guid("A8DF6E04-4852-4491-9A65-144DC4E9B414"),
                        new Guid("A519A173-166B-460F-AE47-18E5F11EDEDF"),
                        new Guid("92C7728B-D7BC-4E99-8D85-12102C21BD42"),
                        new Guid("89DA5DE3-D9FE-4009-A972-9B4584845293"),
                        new Guid("96991278-73AE-4BB9-9200-6769D7F991D7")
                   }
               }
           },
           { "1C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("5C44D385-DEDD-4D65-B676-A901A50FC119"),
                        new Guid("FC6EC2A2-AF8E-4C27-95D3-7A46B9FA3E21"),
                        new Guid("EAAE9D52-C90E-4616-A4F6-B92AB0205C0B"),
                        new Guid("9A2B070D-2FD9-4433-8CCD-F8C51420F961"),
                        new Guid("C9F9B4DC-E5D9-466C-8A76-F8F4D74925A3")
                   },
                   {
                        new Guid("4D055871-7725-4E96-B9FB-5A695612E8C7"),
                        new Guid("6F772471-E6EF-44D2-8AA5-94028AE806E8"),
                        new Guid("BAD3FA7A-7601-43B4-8640-02EDC286EA5B"),
                        new Guid("FD3AC05D-E526-4228-80AA-45A07854AB12"),
                        new Guid("C5714C92-0DAB-48D1-8037-8A518A291970")
                   }
               }
           },
           { "2A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("54202658-D8CB-4E6B-AB55-DF5F93724ACC"),
                        new Guid("6BD6B0DB-F6EF-4938-8870-438B65560639"),
                        new Guid("551CDF8B-A45B-4774-BABF-0DAD29198BAC"),
                        new Guid("657750AA-8DC5-4FE5-8C01-FEF4126B5A1A"),
                        new Guid("27968E60-1510-4EDA-807C-2A9485906A81")
                   },
                   {
                        new Guid("F57AE8DB-4A8B-4C77-9B32-FBA1F72634A9"),
                        new Guid("627122B2-37FB-4A4E-BD79-2C845CD2DBF3"),
                        new Guid("2AF20C16-5F32-47A9-9D02-9758FB5F5A84"),
                        new Guid("6036338D-296B-4B70-8F86-3D3B4C698FCE"),
                        new Guid("3B10F4C9-14E1-4A59-99A5-A6CA8984D771")
                   }
               }
           },
           { "2B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                   {
                        new Guid("D9A55745-5576-40F0-AF0E-EAB4410D3649"),
                        new Guid("008AA56B-3022-4387-B036-2572B6BB3CD7"),
                        new Guid("515CD0CC-BF65-478E-B484-C73EDFFE5B05"),
                        new Guid("2ACCFA6B-2930-4068-9F05-8481786D71E4"),
                        new Guid("6B252ADB-E3CE-492A-91D3-915A7AF7485D")
                   },
                   {
                        new Guid("4FDA7C05-4F9A-42D6-B6EB-97135CA6DF26"),
                        new Guid("41E82162-E790-4FAB-85DA-6D452A7B14C2"),
                        new Guid("E1973445-0A84-4D2F-AA7F-78FCBF27FD8C"),
                        new Guid("3497B4B3-F2F5-4E0B-BDA4-6939CC114DB8"),
                        new Guid("5DA6CA7E-A856-41D9-934C-56D19020362F")
                   }
               }
           },
           { "2C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
                {
                    {
                        new Guid("CC58DA2B-C410-426A-AD75-7E08DAC356DA"),
                        new Guid("CFB7D7CA-8FDB-4F0A-91A8-1659B9141D8B"),
                        new Guid("2E50FF2E-AA12-48A1-B33A-C6D561C7403C"),
                        new Guid("4E94D52F-7D66-4902-9C03-9493C5865490"),
                        new Guid("C9732827-F424-4EC7-8E75-3599703FD208")
                    },
                    {
                        new Guid("F448E854-F675-486C-95AA-7138C41CA649"),
                        new Guid("95790344-033A-4DAD-9C9F-4A21EA848B04"),
                        new Guid("1754A10C-152F-4D70-95C6-AF1ADB5E201A"),
                        new Guid("19A3E7D8-E9EC-4A0B-974B-2C24D0704D8A"),
                        new Guid("71EDCD72-584B-4E94-8314-2C7A658118C3")
                    }
               }
           },
           { "3A", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("5315718A-DF30-4FC6-99AF-6AAA0856E427"),
                        new Guid("CECFE71D-0437-4F6B-B6C6-1FC210BCE884"),
                        new Guid("D46A80D7-7F6C-47AE-B040-9CD9A0B6C04C"),
                        new Guid("C3EC4BAE-1E37-42C2-AE4F-A4267F616056"),
                        new Guid("95527624-7CDF-4EA5-8229-6D6ECAC5C4B7")
                    },
                    {
                        new Guid("539FF638-523C-4B97-8A84-0896B7F74E2B"),
                        new Guid("2780D08C-4F16-41F7-A244-E2D5ADD26A54"),
                        new Guid("7F05DFA5-C6AF-4C34-A27D-A312AC187654"),
                        new Guid("C7AF06A7-A597-40D7-9481-8E04B07A3229"),
                        new Guid("9FE28A4C-8760-468C-B897-706FF1EE3D19")
                    }
               }
           },
           { "3B", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("79854E89-3695-46C4-9E9F-C417D0E5F1E7"),
                        new Guid("ED29F160-5612-42AD-8843-D17BFE31BE15"),
                        new Guid("CCF7A3C3-F4BB-4584-8BBC-E5C0F31298B5"),
                        new Guid("53BC9ACE-F44E-4C00-88A7-66D456C6245C"),
                        new Guid("944C5459-A140-4541-B4F2-444F50862919")
                    },
                    {
                        new Guid("BC09338D-A2AC-44F8-927D-3992C927B40A"),
                        new Guid("D22EF290-38C9-4D91-B624-186B945FA21C"),
                        new Guid("187B66A4-FFCD-4552-99F5-44078991EFA6"),
                        new Guid("3F5FB9FE-E052-4CCC-9C55-CF05C6F31BAE"),
                        new Guid("19027AA6-D013-436E-864C-CD4E23104CC6")
                    }
               }
           },
           { "3C", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("5EF487EB-CBE3-4F3A-AD88-39CFAC44D0DE"),
                        new Guid("3BAFB4DB-F870-4540-9493-6B26387EC25A"),
                        new Guid("35BB99C0-E353-469A-A28F-5AF1AA31AE73"),
                        new Guid("BDCE802E-3F4F-4262-A3D6-420156A7E61B"),
                        new Guid("18289F04-544E-4F02-B38B-1FCB0007E818")
                    },
                    {
                        new Guid("BA9F89B3-0ADD-4DD8-B365-7681BA3E7E2C"),
                        new Guid("69368AC4-2784-4725-AA69-6F2CAEE201A0"),
                        new Guid("8DEAA195-BA88-416C-B257-199E9FE42335"),
                        new Guid("4605D1DE-E9FF-427E-97AA-4AAD9D87A151"),
                        new Guid("D5EF4118-A5D8-4713-8651-4815A239E91B")
                    }
               }
           },
           { "3D", new Guid[StorageHouseRowAmount, StorageHouseColumnAmount]
               {
                    {
                        new Guid("62676589-B3A9-4B71-814B-8085925C512A"),
                        new Guid("54A2A82A-94FB-432E-A450-F18D8501348F"),
                        new Guid("151DF737-0A37-4703-AC94-3E5F4D5394BD"),
                        new Guid("49B83555-D6D8-4157-B611-8428EB14C312"),
                        new Guid("17BC84F6-B363-45B5-8262-9F9456CCE1D2")
                    },
                    {
                        new Guid("B08FFF39-BBC6-4FD7-A329-54A3237CBC9A"),
                        new Guid("73CD40B1-0F93-489C-8EC3-4D6EF49C3C85"),
                        new Guid("961C48BF-E0A7-49EF-8382-1902FEAA2E32"),
                        new Guid("BDE9EC32-18B1-4B1D-8772-7FD743E59211"),
                        new Guid("9FAC9502-FE81-4826-9A87-A7EDAF242A46")
                    }
               }
           }
       };

        #endregion
    }
}
