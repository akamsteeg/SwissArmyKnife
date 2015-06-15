
namespace SwissArmyKnife.DataStructures
{
    /// <summary>
    /// A last in, first out data structure
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// The current, top most, item on the stack
        /// </summary>
        private StackItem _current;

        /// <summary>
        /// A lock for thread safety
        /// </summary>
        private readonly object _lock;

        /// <summary>
        /// Initializes a new instance of 
        /// the <see cref="Stack"/>
        /// </summary>
        public Stack()
        {
            this._lock = new object();
        }

        /// <summary>
        /// Push a new value onto the <see cref="Stack"/>
        /// </summary>
        /// <param name="value">
        /// The new value to push onto 
        /// the <see cref="Stack"/>
        /// </param>
        public virtual void Push(object value)
        {
            lock(this._lock)
            {
                var newItem = new StackItem()
                {
                    Parent = this._current,
                    Value = value,
                };

                this._current = newItem;
            }
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
            lock (this._lock)
            {
                object result = this._current?.Value;
                this._current = this._current?.Parent;

                return result;
            }
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
