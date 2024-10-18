﻿namespace VacanGio.Repositories
{
    public interface IRepoLettura<T>
    {
        T? GetById(int id);
        IEnumerable<T> GetAll();
    }
}
