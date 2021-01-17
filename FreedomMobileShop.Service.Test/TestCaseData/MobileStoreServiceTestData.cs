/// <summary>
/// Test data for mobile store service test methods
/// </summary>
namespace FreedomMobileShop.Service.Test.TestCaseData
{
    using FreedomMobileShop.Common.Constants;
    using FreedomMobileShop.Common.Helpers;
    using FreedomMobileShop.Entity.Entities;
    using System.Collections.Generic;
    using System.Net;
    using System.Threading.Tasks;

    public class MobileStoreServiceTestData
    {
        internal static ListResponse<Brand> GetAllBrandsSuccessResponse()
        {
            return new ListResponse<Brand>
            {
                Response = new List<Brand>
                {
                    new Brand
                    {
                       BrandID = 1,
                       Name ="ABC",
                       Company = "CDE",
                       Type="XX",
                       Description = "YYY"
                    },
                    new Brand
                    {
                       BrandID = 2,
                       Name ="DEF",
                       Company = "DSE",
                       Type="HHH",
                       Description = "jjj"
                    }
                },
                Message = Constant.RECORD_FOUND,
                StatusCode = HttpStatusCode.OK,
                Success = true
            };
        }

        internal static Task<IEnumerable<Brand>> GetAllBrandDataAsync()
        {
            return Task.Run(() => GetAllBrandData());
        }

        internal static IEnumerable<Brand> GetAllBrandData()
        {
            return new List<Brand>
            {
                new Brand
                {
                    BrandID = 1,
                    Name ="ABC",
                    Company = "CDE",
                    Type="XX",
                    Description = "YYY"
                },
                new Brand
                {
                    BrandID = 2,
                    Name ="DEF",
                    Company = "DSE",
                    Type="HHH",
                    Description = "jjj"
                }
            };
        }

        internal static Task<IEnumerable<Brand>> HandleNullResponseForGetAllBrands()
        {
            IEnumerable<Brand> data = new List<Brand>();
            return Task.Run(() => data);
        }

        internal static Task<IEnumerable<Brand>> HandleExceptionResponseForGetAllBrands()
        {
            return null;
        }

        internal static ListResponse<Mobile> GetMobilesByModelNameWithSuccessResponse()
        {
            return new ListResponse<Mobile>
            {
                Response = new List<Mobile>
                {
                    new Mobile
                    {
                       MobileId = 1,
                       MobileCompanyId = "AAA",
                       IMEINumber ="121-1212-1212",
                       Description ="Empty",
                       Name = "ABD",
                       Type = "TTT",
                       MobileModelId = "NNN"
                    },
                    new Mobile
                    {
                        MobileId = 2,
                        MobileCompanyId = "AAA",
                        IMEINumber = "121-1212-1212",
                        Description = "Empty",
                        Name = "ABD",
                        Type = "TTT",
                        MobileModelId = "NNN"
                    }
                },
                Message = Constant.RECORD_FOUND,
                StatusCode = HttpStatusCode.OK,
                Success = true
            };
        }

        internal static Task<IEnumerable<Mobile>> GetMobilesByModelNameAsync()
        {
            return Task.Run(() => GetAllMobileWithSameModel());
        }

        internal static IEnumerable<Mobile> GetAllMobileWithSameModel()
        {
            return new List<Mobile>
            {
                new Mobile
                {
                    MobileId = 1,
                    MobileCompanyId = "AAA",
                    IMEINumber ="121-1212-1212",
                    Description ="Empty",
                    Name = "ABD",
                    Type = "TTT",
                    MobileModelId = "NNN"
                },
                new Mobile
                {
                    MobileId = 2,
                    MobileCompanyId = "AAA",
                    IMEINumber = "121-1212-1212",
                    Description = "Empty",
                    Name = "ABD",
                    Type = "TTT",
                    MobileModelId = "NNN"
                }
            };
        }

        internal static Task<IEnumerable<Mobile>> HandleNullResponseForGetMobilesByModelName()
        {
            IEnumerable<Mobile> data = new List<Mobile>();
            return Task.Run(() => data);
        }

        internal static Task<IEnumerable<Mobile>> HandleExceptionResponseForGetMobilesByModelName()
        {
            return null;
        }
    }
}