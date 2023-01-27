using Microsoft.Extensions.Options;
using System;

namespace BloggerWay.Shared.Utilities.Extensions.Helpers.Abstract
{
    public interface IWritableOptions<out T> : IOptionsSnapshot<T> where T : class, new()
    {
        void Update(Action<T> applyChanges);
    }
}
