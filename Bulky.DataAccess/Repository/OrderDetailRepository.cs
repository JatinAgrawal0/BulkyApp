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
    public class OrderDetailRepository :  Repository<OrderDetail>, IOrderDetailRepository
    {
       private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


       

        public void Update(OrderDetail obj)
        {
            _db.jatin_OrderDetails.Update(obj);
        }
    }
}