using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccountPresentationSystem.Domain.StatementHandler
{
    public class Statement
    {
         /// <summary>
        /// The identifier
        /// </summary>
        private readonly string scrapeddataobj;

        /// <summary>
        /// Initializes a new instance of the <see cref="Statement"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public Statement(string scrapeddataobj)
        {
            if (!string.IsNullOrEmpty(scrapeddataobj))
            {
                this.scrapeddataobj = scrapeddataobj;   
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}