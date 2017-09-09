﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ShaderGen
{
    public class ShaderFunction
    {
        public string Name { get; }
        public TypeReference ReturnType { get; }
        public ParameterDefinition[] Parameters { get; }
        public bool IsEntryPoint => Type != ShaderFunctionType.Normal;
        public ShaderFunctionType Type { get; }

        public ShaderFunction(
            string name,
            TypeReference returnType,
            ParameterDefinition[] parameters,
            ShaderFunctionType type)
        {
            Name = name;
            ReturnType = returnType;
            Parameters = parameters;
            Type = type;
        }

        public ShaderFunction WithReturnType(TypeReference returnType)
        {
            return new ShaderFunction(Name, returnType, Parameters, Type);
        }
    }
}
