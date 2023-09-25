﻿using OpenAI.ObjectModels.RequestModels;

namespace AIServices.Functions
{
    public interface IUmbracoOpenAIFunction
    {
        string Name { get; }

        FunctionDefinition CreateDefinition();

        string ExecuteFunction(string? arguments);
    }
}
