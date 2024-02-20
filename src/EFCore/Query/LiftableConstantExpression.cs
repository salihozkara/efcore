// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Query;

/// <summary>
///     A node containing an expression expressing how to obtain a constant value, which may get lifted out of an expression tree.
/// </summary>
/// <remarks>
///     <para>
///         When the expression tree is compiled, the constant value can simply be evaluated beforehand, and a
///         <see cref="ConstantExpression" /> expression can directly reference the result.
///     </para>
///     <para>
///         When the expression tree is translated to source code instead (in query pre-compilation), the expression can be rendered out
///         separately, to be assigned to a variable, and this node is replaced by a reference to that variable.
///     </para>
/// </remarks>
[DebuggerDisplay("{Microsoft.EntityFrameworkCore.Query.ExpressionPrinter.Print(this), nq}")]
public class LiftableConstantExpression : Expression, IPrintableExpression
{
    /// <summary>
    /// TODO
    /// </summary>
    public LiftableConstantExpression(
        LambdaExpression resolverExpression,
        string variableName,
        Type type)
    {
        ResolverExpression = resolverExpression;
        VariableName = char.ToLower(variableName[0]) + variableName[1..];
        Type = type;
    }

    /// <summary>
    /// TODO
    /// </summary>
    public LambdaExpression ResolverExpression { get; }

    /// <summary>
    /// TODO
    /// </summary>
    public string VariableName { get; }

    /// <summary>
    /// TODO
    /// </summary>
    public override Type Type { get; }

    /// <summary>
    /// TODO
    /// </summary>
    public override ExpressionType NodeType
        => ExpressionType.Extension;

    // TODO: Complete other expression stuff (equality, etc.)

    /// <inheritdoc />
    public void Print(ExpressionPrinter expressionPrinter)
        => expressionPrinter.Append($"[Constant: {expressionPrinter.PrintExpression(ResolverExpression)}]");
}
