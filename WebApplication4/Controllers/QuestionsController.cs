using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;

using System.Text.RegularExpressions;
using Microsoft.AspNet.Identity;
using Faster.Notification;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class QuestionsController : Controller
    {
        private demo4Entities db = new demo4Entities();

        // GET: Questions
        public async Task<ActionResult> Index()
        {
            return View(await db.Questions.Where(s => s.IsDelete == false).ToListAsync());
        }

        // GET: Questions/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // GET: Questions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Title,Questions,Vote,View,Date,Answer1,AcceptedAnswer,IsDelete,AddedDate,ModifiedDate,IP,IsActive,CUserID,MUserID")] Question question)
        {
		    
			 question.AddedDate = DateTime.Now;
            question.ModifiedDate = DateTime.Now;
            question.IP = Request.UserHostAddress;
            question.IsActive = true;
            question.IsDelete = false;
            question.CUserID = User.Identity.GetUserId();
            question.MUserID = User.Identity.GetUserId();

            if (ModelState.IsValid)
            {
			 Notification Notification=new Notification();
			 try
			 {
                                db.Questions.Add(question);
                                await db.SaveChangesAsync();
                				Notification.MsgText="Saved SuccessFully";
				Notification.MsgHeader="Success";
			    Notification.MsgType="success"; //0 Success,1 error,2 warning
			    TempData["Aftersave"] = Notification;
                return RedirectToAction("Create");
             }
			 catch(Exception ex)
			 {
			        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    string msg = rgx.Replace(ex.Message.ToString(), "");
                    Notification.MsgText = msg.Replace("'", "").ToString();
                    Notification.MsgHeader = "Error"; //0 Success,1 fail,2 warning
                    Notification.MsgType = "error"; //0 Success,1 error,2 warning
                    TempData["Aftersave"] = Notification;
                    return View(question);
			 }

                
            }

            return View(question);
        }

        // GET: Questions/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Title,Questions,Vote,View,Date,Answer1,AcceptedAnswer,IsDelete,AddedDate,ModifiedDate,IP,IsActive,CUserID,MUserID")] Question question)
        {

		    question.ModifiedDate = DateTime.Now;
            question.IP = Request.UserHostAddress;
            question.MUserID = User.Identity.GetUserId();

            if (ModelState.IsValid)
            {

			 Notification Notification=new Notification();
			 try
			  {
                db.Entry(question).State = EntityState.Modified;
                                await db.SaveChangesAsync();
                
				Notification.MsgText="Updated SuccessFully";
				Notification.MsgHeader="Success";
			    Notification.MsgType="success"; //0 Success,1 error,2 warning
			    TempData["Aftersave"] = Notification;
			  }
			  catch(Exception ex)
			  {
			        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    string msg = rgx.Replace(ex.Message.ToString(), "");
                    Notification.MsgText = msg.Replace("'", "").ToString();
                    Notification.MsgHeader = "Error"; //0 Success,1 fail,2 warning
                    Notification.MsgType = "error"; //0 Success,1 error,2 warning
                    TempData["Aftersave"] = Notification;
			  }

            }

           
             return RedirectToAction("Index");
        
		}

        // GET: Questions/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Question question = await db.Questions.FindAsync(id);
            if (question == null)
            {
                return HttpNotFound();
            }
            return View(question);
        }

        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
		   Notification Notification=new Notification();
			 try
			  {
											Question question = await db.Questions.FindAsync(id);
				
				  question.IsDelete = true;
					db.Entry( question).State = System.Data.Entity.EntityState.Modified;
           
											await db.SaveChangesAsync();
				
			    Notification.MsgText="Data Deleted SuccessFully";
				Notification.MsgHeader="Success";
			    Notification.MsgType="success"; //0 Success,1 error,2 warning
			    TempData["Aftersave"] = Notification;
			  }
			  catch(Exception ex)
			  {
			        Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                    string msg = rgx.Replace(ex.Message.ToString(), "");
                    Notification.MsgText = msg.Replace("'", "").ToString();
                    Notification.MsgHeader = "Error"; //0 Success,1 fail,2 warning
                    Notification.MsgType = "error"; //0 Success,1 error,2 warning
                    TempData["Aftersave"] = Notification;
			  }

			  return RedirectToAction("Index");
			  
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
