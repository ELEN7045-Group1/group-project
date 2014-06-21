using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace AccountPresentationSystem.Infrastructure
{
    public class MessageObjectWrapper
    {
        public MessageObjectWrapper(object input)
        {
            MessageObject = input;
        }

        private object MessageObject;

        private void EnumerateProperties(StringBuilder builder, object target)
        {
            var type = target.GetType();
            var properties = from p in type.GetProperties()
                             where type.Assembly != typeof(System.Int16).Assembly &&
                             type.Assembly != typeof(System.Int32).Assembly &&
                             type.Assembly != typeof(System.Int64).Assembly &&
                             type.Assembly != typeof(System.Boolean).Assembly &&
                             type.Assembly != typeof(System.Byte).Assembly &&
                             type.Assembly != typeof(System.Char).Assembly &&
                             type.Assembly != typeof(System.DateTime).Assembly &&
                             type.Assembly != typeof(System.Decimal).Assembly &&
                             type.Assembly != typeof(System.Double).Assembly &&
                             type.Assembly != typeof(System.Guid).Assembly &&
                             type.Assembly != typeof(System.SByte).Assembly &&
                             type.Assembly != typeof(System.Single).Assembly &&
                             type.Assembly != typeof(System.UInt16).Assembly &&
                             type.Assembly != typeof(System.UInt32).Assembly &&
                             type.Assembly != typeof(System.UInt64).Assembly &&
                                 p.CanRead &&
                                 !p.IsSpecialName &&
                                 p.GetIndexParameters().Length == 0
                             select p;

            foreach (var property in properties)
            {
                object value = null;

                var getMethod = property.GetGetMethod();
                if (getMethod.ReturnType.IsArray)
                {
                    var arrayObject = getMethod.Invoke(target, null);
                    if (arrayObject != null)
                    {
                        foreach (object element in (Array)arrayObject)
                        {
                            foreach (PropertyInfo arrayObjPinfo in element.GetType().GetProperties())
                            {
                                value = arrayObjPinfo.GetGetMethod().Invoke(element, null);
                            }
                        }
                    }
                }
                else
                {
                    value = property.GetValue(target, null);
                }

                builder.AppendFormat("{0} = {1} | ", property.Name, value == null ? "NULL" : value);

                if (value != null)
                    EnumerateProperties(builder, value);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Object: name: {0} | ", MessageObject.GetType().FullName);

            EnumerateProperties(sb, this.MessageObject);

            sb.Append("End");

            return sb.ToString();
        }
    }
}