using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace PeHeBI_DatabastUpdata.common.Data
{
    public class SetParamsValues_SQLite : KnownTargetValueInjection<SQLiteCommand>
    {
        private IEnumerable<string> ignoredFields = new string[] { };
        private string prefix = string.Empty;

        public SetParamsValues_SQLite Prefix(string p)
        {
            prefix = p;
            return this;
        }

        public SetParamsValues_SQLite IgnoreFields(params string[] fields)
        {
            ignoredFields = fields.AsEnumerable();
            return this;
        }

        protected override void Inject(object source, ref SQLiteCommand cmd)
        {
            if (source == null) return;
            var sourceProps = source.GetInfos().ToList();

            foreach (var prop in sourceProps)
            {
                if (prop.GetCustomAttributes(true).Length > 0)
                {
                    int k = prop.GetCustomAttributes(true).OfType<DbFieldAttribute>()
                                                .Count(dbFieldAttribute => !dbFieldAttribute.IsDbField);

                    if (k > 0)
                        continue;
                }

                if (ignoredFields.Contains(prop.Name.ToLower())) continue;

                var value = prop.GetValue(source, null) ?? DBNull.Value;
                cmd.Parameters.AddWithValue("@" + prefix + prop.Name, value);
            }
        }
    }
}
