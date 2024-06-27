namespace DesignPattern.Composite
{
    public abstract class MenuComponent
    {
        /// <summary>
        /// Meal 及 Menu 都會使用
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public virtual string GetName()
        {
            // 回傳 null 也可以
            throw new NotSupportedException();
        }

        /// <summary>
        /// 只有 Meal 會使用
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public virtual int GetPrice()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// 只有 Meal 會使用
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// 只有 Menu 會使用
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// 只有 Menu 會使用
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// 只有 Menu 會使用
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public virtual MenuComponent GetChild(int index)
        {
            throw new NotSupportedException();
        }

        /// <summary>
        /// Meal 及 Menu 都會使用
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
