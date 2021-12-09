﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBMVC.Models;
using WEBMVC.Data;

namespace WEBMVC.Services
{
    public class SellerService
    {
        private readonly WEBMVCContext _context;

        public SellerService(WEBMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
