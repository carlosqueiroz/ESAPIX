using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Dynamic;
using X = ESAPIX.Facade.XContext;

namespace ESAPIX.Facade.Types
{
    public class OptimizationOptionsIMRT : ESAPIX.Facade.Types.OptimizationOptionsBase
    {
        public OptimizationOptionsIMRT() { _client = new ExpandoObject(); }
        public OptimizationOptionsIMRT(dynamic client) { _client = client; }
        public OptimizationOptionsIMRT(System.Int32 maxIterations, ESAPIX.Facade.Types.OptimizationOption initialState, System.Int32 numberOfStepsBeforeIntermediateDose, ESAPIX.Facade.Types.OptimizationConvergenceOption convergenceOption, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(_client = VMSConstructor.Instance.ConstructOptimizationOptionsIMRT(maxIterations, initialState, numberOfStepsBeforeIntermediateDose, convergenceOption, mlcId)); }
        public OptimizationOptionsIMRT(System.Int32 maxIterations, ESAPIX.Facade.Types.OptimizationOption initialState, ESAPIX.Facade.Types.OptimizationConvergenceOption convergenceOption, ESAPIX.Facade.Types.OptimizationIntermediateDoseOption intermediateDoseOption, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(_client = VMSConstructor.Instance.ConstructOptimizationOptionsIMRT(maxIterations, initialState, convergenceOption, intermediateDoseOption, mlcId)); }
        public OptimizationOptionsIMRT(System.Int32 maxIterations, ESAPIX.Facade.Types.OptimizationOption initialState, ESAPIX.Facade.Types.OptimizationConvergenceOption convergenceOption, System.String mlcId) { X.Instance.CurrentContext.Thread.Invoke(_client = VMSConstructor.Instance.ConstructOptimizationOptionsIMRT(maxIterations, initialState, convergenceOption, mlcId)); }
        public ESAPIX.Facade.Types.OptimizationConvergenceOption ConvergenceOption
        {
            get
            {
                if (_client is ExpandoObject) { return _client.ConvergenceOption; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<ESAPIX.Facade.Types.OptimizationConvergenceOption>((sc) => { return (ESAPIX.Facade.Types.OptimizationConvergenceOption)local._client.ConvergenceOption; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.ConvergenceOption = value; }
            }
        }
        public System.Int32 NumberOfStepsBeforeIntermediateDose
        {
            get
            {
                if (_client is ExpandoObject) { return _client.NumberOfStepsBeforeIntermediateDose; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.NumberOfStepsBeforeIntermediateDose; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.NumberOfStepsBeforeIntermediateDose = value; }
            }
        }
        public System.Int32 MaximumNumberOfIterations
        {
            get
            {
                if (_client is ExpandoObject) { return _client.MaximumNumberOfIterations; }
                var local = this;
                return X.Instance.CurrentContext.GetValue<System.Int32>((sc) => { return local._client.MaximumNumberOfIterations; });
            }
            set
            {
                if (_client is ExpandoObject) { _client.MaximumNumberOfIterations = value; }
            }
        }
    }
}