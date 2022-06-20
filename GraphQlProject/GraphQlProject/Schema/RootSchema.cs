﻿using GraphQlProject.Query;
using GraphQL.Utilities;
using System;
using Microsoft.Extensions.DependencyInjection;
using GraphQlProject.Mutation;

namespace GraphQlProject.Schema
{
    public class RootSchema : GraphQL.Types.Schema
    {
        public RootSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<RootQuery>();
            Mutation = serviceProvider.GetRequiredService<RootMutation>();
        }
    }
}
