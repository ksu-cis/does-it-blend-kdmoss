using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended.
    /// </summary>
    interface IBlendable
    {
        /// <summary>
        /// Blends an item.
        /// </summary>
        /// <returns>A string describing the blended item.</returns>
        string Blend();
    }
}
