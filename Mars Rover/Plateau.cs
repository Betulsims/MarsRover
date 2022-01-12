using System;

namespace Mars_Rover
{
    public class Plateau : IPlateau
    {
        #region Private Methods
        private Int32 xAxis;

        private Int32 yAxis;
        #endregion

        #region Public Methods
        public Int32 XAxis
        {
            get { return xAxis; }
            set
            {
                if (xAxis != value)
                {
                    xAxis = value;                    
                }
            }
        }

        public Int32 YAxis
        {
            get { return yAxis; }
            set
            {
                if (yAxis != value)
                {
                    yAxis = value;
                }
            }
        }

        public void ValidatePlateauCoordinates()
        {
            var validation = XAxis < 0 || YAxis < 0 ? false : true;
            if (!validation)
                throw new Exception($"Invalid Plateau Coordinates: {XAxis} {YAxis}");
        }
        #endregion
    }
}
