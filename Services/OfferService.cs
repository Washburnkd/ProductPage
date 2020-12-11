﻿using System;
using System.Collections.Generic;
using System.Linq;
using ProductPage.Data;
using ProductPage.Models;

namespace ProductPage
{
    public class OfferService
    {
        private PinitgoDbContext _context;
        public OfferService(PinitgoDbContext context)
        {
            _context = context;
        }

        public OfferModel GetOffer(int oid)
        {
            var o = new OfferModel();
            o.OID = oid;
            o.Selections = _context.Selections.Where(m => m.OID == oid).ToList();
            o.XForms = _context.XForms.Where(m => m.OID == oid).ToList();
            o.Uploads = _context.Uploads.ToList();
            o.SelectionOptions = _context.SelectionOptions.Where(m => m.OID == oid).ToList();
            o.OItems = _context.OItems.Where(m => m.OID == oid).ToList();
            o.XFormSelections = _context.XFormSelections.Where(m => m.OID == oid).ToList();
            return o;
        }

        public bool SaveXForms(List<XForm> xforms)
        {
            // not the best way to do this, but good enough for now.
            foreach(var x in xforms)
            {
                // this would be better IF WE sent all the data values.
                // _context.XForms.Update(x);
                var found = _context.XForms.FirstOrDefault(m => m.XID == x.XID);
                found.Top = x.Top;
                found.Left = x.Left;
                found.Width = x.Width;
                found.Height = x.Height;
                found.Rotation = x.Rotation;
                found.Transparency = x.Transparency;
                _context.XForms.Update(found);
                _context.SaveChanges();
            }

            return true;
        }

        public bool RemoveXForms(int xid)
        {
            var found = _context.XForms.FirstOrDefault(m => m.XID==xid);
            _context.XForms.Remove(found);
            _context.SaveChanges();

            return true;
        }

        public bool AddXForms(int uid, int oid)
        {
            var n = new XForm();
            n.OID = oid;
            n.UID = uid;
            n.AID = 1;
            n.Top = 100;
            n.Left = 100;
            n.Width = 100;
            n.Height = 100;
            n.Rotation = 0;
            n.Transparency = 1;
            _context.XForms.Add(n);
            var result = _context.SaveChanges();
            return result==1;
        }
    }
}