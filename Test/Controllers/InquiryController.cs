using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using Test_DataAccess;
using Test_DataAccess.Repository.IRepository;
using Test_Models;
using Test_Utility;

namespace Test.Controllers
{
    public class InquiryController : Controller
    {
        private readonly IInquiryHeaderRepository _inqHRepo;
        private readonly IInquiryDetailRepository _inqDRepo;

        public InquiryController(IInquiryDetailRepository inqDRepo,
            IInquiryHeaderRepository inqHRepo)
        {
            _inqDRepo = inqDRepo;
            _inqHRepo = inqHRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

