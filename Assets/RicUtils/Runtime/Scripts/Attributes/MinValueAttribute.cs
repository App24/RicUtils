using UnityEngine;

namespace RicUtils.Attributes
{
    public class MinValueAttribute : PropertyAttribute
    {
        public readonly float X, Y, Z, W;

        public MinValueAttribute(float value) : this(value, value, value, value)
        {

        }

        public MinValueAttribute(float x, float y) : this(x, y, 0)
        {

        }

        public MinValueAttribute(float x, float y, float z) : this(x, y, z, 0)
        {
        }

        public MinValueAttribute(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }
    }
}
