using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace PPP_Project.Common.Expression
{
    public class ExpressionHelper<T>
    {
        private MemberExpression GetMemberExpression(Expression<Func<T, object>> aType)
        {
            var l_Entity = Activator.CreateInstance(typeof(T));

            MemberExpression l_LogicalExpression;

            switch (aType.Body.NodeType)
            {
                case ExpressionType.Convert:
                case ExpressionType.ConvertChecked:
                    // intialize unary expression which is non string type
                    var l_LogicalUnaryExpression = aType.Body as UnaryExpression;
                    l_LogicalExpression = ((l_LogicalUnaryExpression != null) ? l_LogicalUnaryExpression.Operand : null) as MemberExpression;
                    break;
                default:
                    // intialize expression which is string type 
                    l_LogicalExpression = aType.Body as MemberExpression;
                    break;
            }
            return l_LogicalExpression;
        }

        public virtual string GetFieldName(Expression<Func<T, object>> aPhysicalName)
        {
            return GetMemberExpression(aPhysicalName).Member.Name;
        }

        public A GetMemberAttribute<A>(Expression<Func<T, object>> aPhysicalName) where A : Attribute
        {
            A l_Target = null;

            object[] l_attrs;

            var l_Type = GetMemberExpression(aPhysicalName);

            l_attrs = GetMemberExpression(aPhysicalName).Member.GetCustomAttributes(typeof(A), false);

            foreach (var attr in l_attrs)
                l_Target = (A)attr;


            return l_Target;
        }

        public A GetClassAttribute<A>(Type aType) where A : Attribute
        {
            A l_Target = null;

            var l_attrs = aType.GetCustomAttributes(typeof(A), false);

            foreach (var att in l_attrs)
            {
                l_Target = (A)att;
            }

            return l_Target;
        }
    }
}