using System.Collections.Generic;

namespace Controller_Estimator
{
    public class PropertyView
    {
        double propertyValue;
        public double PropertyValue { get => propertyValue; set => propertyValue = value; }

        List<int> expertAssessments;
        public List<int> ExpertAssessments { get => expertAssessments; set => expertAssessments = value; }

        bool isReversed;
        public bool IsReversed { get => isReversed; set => isReversed = value; }

        string propertyName;
        public string PropertyName { get => propertyName; set => propertyName = value; }

        string groupName;
        public string GroupName { get => groupName; set => groupName = value; }

        string controllerName;
        public string ControllerName { get => controllerName; set => controllerName = value; }

        public PropertyView(bool isReversed, string propertyName, string groupName)
        {
            IsReversed = isReversed;
            PropertyName = propertyName;
            GroupName = groupName;
            if (IsReversed)
            {
                PropertyName = propertyName + "*";
            }
            else PropertyName = propertyName;
        }




        

    }
}
