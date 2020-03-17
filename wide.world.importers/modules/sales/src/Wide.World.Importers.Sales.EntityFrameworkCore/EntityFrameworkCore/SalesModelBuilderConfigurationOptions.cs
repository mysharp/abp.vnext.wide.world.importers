﻿using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Wide.World.Importers.Sales.EntityFrameworkCore
{
    public class SalesModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public SalesModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}