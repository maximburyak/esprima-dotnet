using System.Collections.Generic;
using Newtonsoft.Json;

namespace Esprima.Ast
{
    public class FunctionExpression : Node,
        IFunction,
        Expression,
        PropertyValue
    {
        public Identifier Id { get; set; }
        public IEnumerable<INode> Params { get; set; }
        public BlockStatement Body { get; set; }
        public bool Generator { get; set; }
        public bool Expression { get; set; }

        [JsonIgnore]
        public HoistingScope HoistingScope { get; }

        public FunctionExpression(
            Identifier id,
            IEnumerable<INode> parameters,
            BlockStatement body,
            bool generator,
            HoistingScope hoistingScope
            )
        {
            Type = Nodes.FunctionExpression;
            Id = id;
            Params = parameters;
            Body = body;
            Generator = generator;
            Expression = false;
            HoistingScope = hoistingScope;

        }
    }
}