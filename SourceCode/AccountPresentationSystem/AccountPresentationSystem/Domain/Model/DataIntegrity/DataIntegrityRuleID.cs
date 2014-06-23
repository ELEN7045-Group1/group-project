namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;


    public class DataIntegrityRuleID : IValueObject<DataIntegrityRuleID>
    {

        private readonly string id;

        public DataIntegrityRuleID(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                this.id = id;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public string IdString
        {
            get { return id; }
        }

        public bool SameValueAs(DataIntegrityRuleID other)
        {
            return other != null && id.Equals(other.id);
        }
    }
}