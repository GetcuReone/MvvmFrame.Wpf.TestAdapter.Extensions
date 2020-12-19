using GetcuReone.MvvmFrame.Wpf.TestAdapter.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetcuReone.MvvmFrame.Wpf.TestAdapter
{
    /// <summary>
    /// Helper for asserts.
    /// </summary>
    public static class AssertHelper
    {
        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TFuncOut"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TFuncOut"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TFuncOut"/> is null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput, TFuncOut>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, TFuncOut> func, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TFuncOut).Name} is not null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TFuncOut).Name} is null.";
                Assert.IsNotNull(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TFuncOut"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TFuncOut"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TFuncOut"/> is null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput, TFuncOut>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, TFuncOut> func, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TFuncOut).Name} is not null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TFuncOut).Name} is null.";
                Assert.IsNotNull(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TFuncOut"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TFuncOut"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TFuncOut"/> is not null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput, TFuncOut>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, TFuncOut> func, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TFuncOut).Name} is null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TFuncOut).Name} is not null.";
                Assert.IsNotNull(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TFuncOut"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TFuncOut"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TFuncOut"/> is not null.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput, TFuncOut>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, TFuncOut> func, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TFuncOut).Name} is null.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TFuncOut).Name} is not null.";
                Assert.IsNotNull(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<bool, bool> AndIsTrue<TInput>(this GivenBlock<TInput, bool> givenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<bool, bool> AndIsTrue<TInput>(this GivenAsyncBlock<TInput, bool> givenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsTrue<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsTrue<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<bool, bool> AndIsFalse<TInput>(this GivenBlock<TInput, bool> givenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<bool, bool> AndIsFalse<TInput>(this GivenAsyncBlock<TInput, bool> givenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsFalse<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, bool> func, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndIsFalse<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, bool> func, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput, TExpectedValue>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput, TExpectedValue>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput>(this GivenBlock<TInput, TOutput> givenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput>(this GivenAsyncBlock<TInput, TOutput> givenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput, TExpectedValue>(this GivenBlock<TInput, TOutput> givenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="givenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static GivenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput, TExpectedValue>(this GivenAsyncBlock<TInput, TOutput> givenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return givenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsNotNull<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsNotNull<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsNull<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsNull<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> ThenIsTrue<TInput>(this WhenBlock<TInput, bool> whenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> ThenIsTrue<TInput>(this WhenAsyncBlock<TInput, bool> whenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsTrue<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TInput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsTrue<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> ThenIsFalse<TInput>(this WhenBlock<TInput, bool> whenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="whenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> ThenIsFalse<TInput>(this WhenAsyncBlock<TInput, bool> whenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsFalse<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, Func<TOutput, bool> func, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenIsFalse<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, Func<TOutput, bool> func, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreEqual<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreEqual<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreEqual<TInput, TOutput, TExpectedValue>(this WhenBlock<TInput, TOutput> whenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreEqual<TInput, TOutput, TExpectedValue>(this WhenAsyncBlock<TInput, TOutput> whenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreNotEqual<TInput, TOutput>(this WhenBlock<TInput, TOutput> whenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreNotEqual<TInput, TOutput>(this WhenAsyncBlock<TInput, TOutput> whenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreNotEqual<TInput, TOutput, TExpectedValue>(this WhenBlock<TInput, TOutput> whenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="whenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> ThenAreNotEqual<TInput, TOutput, TExpectedValue>(this WhenAsyncBlock<TInput, TOutput> whenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return whenBlock.Then(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNotNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsNotNull<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is not null.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is null.";
                Assert.IsNotNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsNull(object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is null.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not null.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsNull<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is null.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {typeof(TOutput).Name} is not null.";
                Assert.IsNull(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> AndIsTrue<TInput>(this ThenBlock<TInput, bool> thenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> AndIsTrue<TInput>(this ThenAsyncBlock<TInput, bool> thenBlock, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsTrue<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsTrue(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsTrue<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsTrue(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> AndIsFalse<TInput>(this ThenBlock<TInput, bool> thenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <param name="thenBlock"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<bool, bool> AndIsFalse<TInput>(this ThenAsyncBlock<TInput, bool> thenBlock, string blockName = "Check result is false.", string errorMessage = "Result is not false.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(result, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsFalse<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.IsFalse(bool)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="blockName">Block name.</param>
        /// <param name="errorMessage">Error message.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndIsFalse<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, Func<TOutput, bool> func, string blockName = "Check result is true.", string errorMessage = "Result is not true.")
        {
            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage;
                Assert.IsFalse(func(result), innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput, TExpectedValue>(this ThenBlock<TInput, TOutput> thenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreEqual<TInput, TOutput, TExpectedValue>(this ThenAsyncBlock<TInput, TOutput> thenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is not equals.";
                Assert.AreEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput>(this ThenBlock<TInput, TOutput> thenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are not equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput>(this ThenAsyncBlock<TInput, TOutput> thenBlock, TOutput expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(result, expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput, TExpectedValue>(this ThenBlock<TInput, TOutput> thenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }

        /// <summary>
        /// Check <see cref="Assert.AreNotEqual(object, object)"/>.
        /// </summary>
        /// <typeparam name="TInput"></typeparam>
        /// <typeparam name="TOutput"></typeparam>
        /// <typeparam name="TExpectedValue"></typeparam>
        /// <param name="thenBlock"></param>
        /// <param name="func"></param>
        /// <param name="expectedValue">Expected value.</param>
        /// <param name="blockName">Block name. Default 'Check result <typeparamref name="TOutput"/> is are equal.'.</param>
        /// <param name="errorMessage">Error message. Default 'Result <typeparamref name="TOutput"/> is not equals.'.</param>
        /// <returns></returns>
        public static ThenBlock<TOutput, TOutput> AndAreNotEqual<TInput, TOutput, TExpectedValue>(this ThenAsyncBlock<TInput, TOutput> thenBlock, Func<TOutput, TExpectedValue> func, TExpectedValue expectedValue, string blockName = null, string errorMessage = null)
        {
            blockName = blockName ?? $"Check result {typeof(TOutput).Name} is are not equal.";

            return thenBlock.And(blockName, result =>
            {
                string innerErrorMessage = errorMessage ?? $"Result {result.GetType().Name} is equals.";
                Assert.AreNotEqual(func(result), expectedValue, innerErrorMessage);
                return result;
            });
        }
    }
}
