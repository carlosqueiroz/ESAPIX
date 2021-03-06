﻿#region

using VMS.TPS.Common.Model.API;

#endregion

namespace ESAPIX.Constraints
{
    public abstract class AbstractPlanQualityConstraint : IConstraint
    {
        public delegate void StatusUpdateHandler(double progress, string status);

        public virtual string Value { get; protected set; }
        public abstract string Name { get; }

        public virtual string FullName
        {
            get { return Name; }
        }

        public abstract ConstraintResult CanConstrain(PlanningItem pi);

        public abstract ConstraintResult Constrain(PlanningItem pi);

        public event StatusUpdateHandler StatusChanged;

        public void OnStatusChanged(double progress, string status)
        {
            StatusChanged?.Invoke(progress, status);
        }
    }
}