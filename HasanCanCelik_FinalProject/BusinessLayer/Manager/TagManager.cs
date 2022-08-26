using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Manager
{
    public class TagManager
    {
        Repository<Tag> tagrepo = new Repository<Tag>();
        public List<Tag> GetAll()
        {
            return tagrepo.List();
        }
        public int BLAdd(Tag c)
        {
            return tagrepo.Insert(c);
        }
        public int BLDell(int p)
        {
            if (p != 0)
            {
                Tag tag = tagrepo.Find(x => x.TagID == p);
                return tagrepo.Delete(tag);
            }
            else
            {
                return -1;
            }
        }
        public int BLUpdate(Tag p)
        {
            Tag tag = tagrepo.Find(x => x.TagID == p.TagID);
            tag.TagName = p.TagName;
            return tagrepo.Update(tag);
        }
    }
}
