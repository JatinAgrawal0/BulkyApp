using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bulky.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Bulky.DataAccess.Data;
using Bulky.Models;

namespace Bulky.DataAccess.Repository
{
    public class OrderHeaderRepository :  Repository<OrderHeader>, IOrderHeaderRepository
    {
       private ApplicationDbContext _db;
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(OrderHeader obj)
        {
            _db.jatin_OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderStatus ,string? paymentStatus = null){
            var orderFromDb = _db.jatin_OrderHeaders.FirstOrDefault(u=>u.OrderHeaderId == id);
            if(orderFromDb != null)
            {
                orderFromDb.OrderStatus = orderStatus;
                if(!string.IsNullOrEmpty(paymentStatus))
                {
                    orderFromDb.PaymentStatus = paymentStatus;
                }

            }
        }

        public void UpdateStripePaymentID(int id,string sessionId,string paymentIntentId){
            var orderFromDb = _db.jatin_OrderHeaders.FirstOrDefault(u=>u.OrderHeaderId == id);
            if(!string.IsNullOrEmpty(sessionId))
            {
                orderFromDb.SessionId = sessionId;
            }
            if(!string.IsNullOrEmpty(paymentIntentId))
            {
                orderFromDb.PaymentIntentId = paymentIntentId;
                orderFromDb.PaymentDate = DateTime.Now;
                
            }
        }
    }
}