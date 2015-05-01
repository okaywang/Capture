using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PacketAnalyst.Utility;
using System.Windows.Forms;

namespace PacketAnalyst.DataAccess
{
    public class XMLPersistence : IPersistence
    {
        private string _fileName;
        private XDocument _xdoc;

        public XMLPersistence()
        {
            _fileName = System.IO.Path.GetFullPath(@"..\..\AppData\Rules.xml");  // System.IO.Directory.GetCurrentDirectory() + "\\AppData\\Rules.xml";
            _xdoc = XDocument.Load(_fileName);
        }

        public void CreateRule(FilterRule ruleModel)
        {
            if (ruleModel.Id == 0)
            {
                var rules = this.GetAllRules();
                var maxId = 0;
                if (rules.Length != 0)
                {
                    maxId = rules.Select(i => i.Id).Max();
                }
                ruleModel.Id = maxId + 1;
            }

            var currentRuleElement = new XElement("rule", 
                    new XElement("id", ruleModel.Id), 
                    new XElement("value", ruleModel.Value),
                    new XElement("description", ruleModel.Description));

            var rulesElement = _xdoc.Element("rules");
            var ruleElement = rulesElement.Elements("rule"); 
            if (ruleElement.Any())
            {
                ruleElement.Last().AddAfterSelf(currentRuleElement);
            }
            else
            {
                rulesElement.Add(currentRuleElement);
            }
           
            _xdoc.Save(_fileName);
        }

        public void DeleteRule(int id)
        {
            _xdoc.Element("rules")
            .Elements("rule")
            .Where(i => ((XElement)i.FirstNode).Value == id.ToString())
            .Remove();

            _xdoc.Save(_fileName);
        }

        public FilterRule[] GetAllRules()
        {
            var rules = from rule in _xdoc.Descendants("rule")
                        select new FilterRule
                        {
                            Id = Int32.Parse((rule.FirstNode as XElement).Value),
                            Value = (rule.Nodes().ToList()[1] as XElement).Value,
                            Description = (rule.LastNode as XElement).Value
                        };

            return rules.ToArray();
        }
    }
}
