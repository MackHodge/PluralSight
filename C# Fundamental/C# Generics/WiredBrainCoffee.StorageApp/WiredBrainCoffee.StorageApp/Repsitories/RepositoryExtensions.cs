namespace WiredBrainCoffee.StorageApp.Repsitories
{
    public static class RepositoryExtensions
    {
        public static void Addbatch<T>(this IWriteRepsitory<T> Repository, T[] items)  
        {
            foreach (T item in items)
            {
                Repository.Add(item);
            }
            Repository.Save();
        }
    }
}
