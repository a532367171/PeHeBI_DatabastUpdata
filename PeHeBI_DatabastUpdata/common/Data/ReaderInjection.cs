using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Omu.ValueInjecter;

namespace PeHeBI_DatabastUpdata.common.Data
{
    public class ReaderInjection : KnownSourceValueInjection<IDataReader>
    {
        protected override void Inject(IDataReader source, object target)
        {
            for (var i = 0; i < source.FieldCount; i++)
            {
                var activeTarget = target.GetProps().GetByName(source.GetName(i),true);
                if (activeTarget == null) continue;

                var value = source.GetValue(i);
                if (value == DBNull.Value) continue;


                if (value.GetType().Name == "Int64")
                    {
                     value = Convert.ToInt32(value);
                    }
                activeTarget.SetValue(target, value);
            }
        }
    }
}
