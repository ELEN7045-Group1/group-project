namespace AccountPresentationSystem.Domain.Model.DataIntegrity
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;


    public class DataIntegrityRule :IValueObject<DataIntegrityRule>
    {
        public DataIntegrityRule()
        {

        }

        public bool SameValueAs(DataIntegrityRule other)
        {
            return true;
        }
    }
}