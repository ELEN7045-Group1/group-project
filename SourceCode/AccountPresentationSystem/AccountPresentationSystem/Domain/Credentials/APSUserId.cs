namespace AccountPresentationSystem.Domain.Credentials
{
    using NDDDSample.Domain.Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class APSUserId : IValueObject<APSUserId>
    {
        private readonly string id;

        public APSUserId(string id)
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

        public bool SameValueAs(APSUserId other)
        {
            return other != null && id.Equals(other.id);
        }
    }
}