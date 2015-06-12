using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwissArmyKnife.DataStructures
{
    /// <summary>
    /// A stack
    /// </summary>
    public class Stack
    {
        private StackItem _current;

        /// <summary>
        /// Push a new value onto the <see cref="Stack"/>
        /// </summary>
        /// <param name="value">
        /// The new value to push onto 
        /// the <see cref="Stack"/>
        /// </param>
        public virtual void Push(object value)
        {
            var newItem = new StackItem()
            {
                Parent = this._current,
                Value = value,
            };

            this._current = newItem;
        }

        /// <summary>
        /// Pop the current item from
        /// the <see cref="Stack"/>
        /// </summary>
        /// <returns>
        /// The topmost value on
        /// the <see cref="Stack"/>
        /// </returns>
        public virtual object Pop()
        {
            object result = this._current?.Value;
            this._current = this._current?.Parent;

            return result;
        }
    }

    /// <summary>
    /// Represents an item on the <see cref="Stack"/>
    /// </summary>
    internal class StackItem
    {
        /// <summary>
        /// The parent of the current item
        /// </summary>
        public StackItem Parent
        {
            get;
            set;
        }

        /// <summary>
        /// The value of the item
        /// </summary>
        public object Value
        {
            get;
            set;
        }
    }
}
