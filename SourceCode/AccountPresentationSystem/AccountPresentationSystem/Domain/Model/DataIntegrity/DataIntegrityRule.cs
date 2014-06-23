namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;


    public class DataIntegrityRule :IEntity<DataIntegrityRule>
    {
        public virtual bool SameIdentityAs(DataIntegrityRule other)
        {
            return true;
        }
    }
}