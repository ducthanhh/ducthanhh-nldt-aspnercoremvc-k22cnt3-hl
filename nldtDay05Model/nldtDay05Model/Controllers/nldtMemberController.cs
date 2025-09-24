using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using nldtDay05Model.Models;

namespace nldtDay05Model.Controllers
{
    
        public class nldtMemberController : Controller
        {
            static List<nldtMember> members = new List<nldtMember>()
        {
            new nldtMember { nldtMemberId = Guid.NewGuid().ToString(), nldtMemberUserName = "nldthung", nldtMemberFullNameName = "Trịnh Văn Chung", nldtMemberPassword = "A123@12", nldtMemberEmail = "chungtrinhj@gmail.com" },
            new nldtMember { nldtMemberId = Guid.NewGuid().ToString(), nldtMemberUserName = "tvanh",   nldtMemberFullNameName = "Trần Văn Anh",   nldtMemberPassword = "B123@34", nldtMemberEmail = "anhtran@gmail.com" },
            new nldtMember { nldtMemberId = Guid.NewGuid().ToString(), nldtMemberUserName = "nthao",   nldtMemberFullNameName = "Nguyễn Thị Thảo", nldtMemberPassword = "C123@56", nldtMemberEmail = "thaonguyen@gmail.com" },
            new nldtMember { nldtMemberId = Guid.NewGuid().ToString(), nldtMemberUserName = "pvnam",   nldtMemberFullNameName = "Phạm Văn Nam",   nldtMemberPassword = "D123@78", nldtMemberEmail = "nampham@gmail.com" },
            new nldtMember { nldtMemberId = Guid.NewGuid().ToString(), nldtMemberUserName = "ltmai",   nldtMemberFullNameName = "Lê Thị Mai",     nldtMemberPassword = "E123@90", nldtMemberEmail = "maile@gmail.com" }
        };
            public IActionResult Index()
            {
                // scaffolding

                return View(members);
            }
            // Get nldtCreate
            public IActionResult nldtCreate()
            {
                return View();
            }

            // POST nldtCreate
            [HttpPost]
            public IActionResult nldtCreate(nldtMember model)
            {
                var member = new nldtMember();
                member.nldtMemberId = Guid.NewGuid().ToString();
                member.nldtMemberFullNameName = model.nldtMemberFullNameName;
                member.nldtMemberUserName = model.nldtMemberUserName;
                member.nldtMemberPassword = model.nldtMemberPassword;
                member.nldtMemberEmail = model.nldtMemberEmail;

                members.Add(member);

                return RedirectToAction("Index");
            }

            // Get nldtEdit
            [HttpGet]
            public IActionResult nldtEdit(string id)
            {
                var model = members.Where(x => x.nldtMemberId == id).FirstOrDefault();
                return View(model);
            }
            [HttpPost]
            public IActionResult nldtEdit(string id, nldtMember model)
            {
                members.Where(x => x.nldtMemberId == id).FirstOrDefault().nldtMemberFullNameName = model.nldtMemberFullNameName;
                members.Where(x => x.nldtMemberId == id).FirstOrDefault().nldtMemberUserName = model.nldtMemberUserName;
                members.Where(x => x.nldtMemberId == id).FirstOrDefault().nldtMemberPassword = model.nldtMemberPassword;
                members.Where(x => x.nldtMemberId == id).FirstOrDefault().nldtMemberEmail = model.nldtMemberEmail;

                return RedirectToAction("Index");
            }

            // Details
            [HttpGet]
            public IActionResult nldtDetails(string id)
            {
                var model = members.Where(x => x.nldtMemberId == id).FirstOrDefault();
                return View(model);
            }

            // nldtDelete
            [HttpGet]
            public IActionResult nldtDelete(string id)
            {
                var model = members.Where(x => x.nldtMemberId == id).FirstOrDefault();
                return View(model);
            }
            [HttpPost]
            public IActionResult nldtDelete(string id, nldtMember model)
            {
                // Tìm thành viên theo nldtMemberId
                var member = members.FirstOrDefault(m => m.nldtMemberId == id);
                if (member != null)
                {
                    members.Remove(member); // Xóa khỏi danh sách
                }
                return RedirectToAction("Index");
            }
            public IActionResult nldtGetMember()
            {
                var nldtMember = new nldtMember();
                nldtMember.nldtMemberId = Guid.NewGuid().ToString();
                nldtMember.nldtMemberUserName = "nldt";
                nldtMember.nldtMemberFullNameName = "nguyen le duc thanh ";
                nldtMember.nldtMemberPassword = "A123@12";
                nldtMember.nldtMemberEmail = "thanhhj@gmail.com";

                ViewBag.nldtMember = nldtMember;

                return View();
            }
        public IActionResult nldtListMembers()
        {
            return View(members);
        }
    }
    }

