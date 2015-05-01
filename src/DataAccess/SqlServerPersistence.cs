using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PacketAnalyst.Utility;

namespace PacketAnalyst.DataAccess
{
    public class SqlServerPersistence : IPersistence
    {
        public void CreateRule(Utility.FilterRule rule)
        {
            var filterRule = new DC.filter_rule
            {
                Id = rule.Id,
                Value = rule.Value,
                Notes = rule.Description,
                CreateUserId = "001"
            };
            using (DC.DataClasses1DataContext db = new DC.DataClasses1DataContext())
            {
                db.filter_rules.InsertOnSubmit(filterRule);
                db.SubmitChanges();
            }
        }

        public void DeleteRule(int id)
        {
            using (DC.DataClasses1DataContext db = new DC.DataClasses1DataContext())
            { 
                var entity = db.filter_rules.SingleOrDefault(i =>i .Id == id);
                db.filter_rules.DeleteOnSubmit(entity);
                db.SubmitChanges();
            }
        }

        public Utility.FilterRule[] GetAllRules()
        { 
            using (DC.DataClasses1DataContext db = new DC.DataClasses1DataContext())
            {
                var filter_rules = db.filter_rules.ToArray();
                
                var rules = new FilterRule[filter_rules.Length];
              
                for (int i = 0; i < filter_rules.Length; i++)
                {
                    rules[i] = new FilterRule();
                    rules[i].Id = filter_rules[i].Id;
                    rules[i].Value = filter_rules[i].Value;
                    rules[i].Description = filter_rules[i].Notes;
                }

                return rules;
            }
        }
    }
}
