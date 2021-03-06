﻿using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace TaskList2.Abstractions
{
    public interface ILoginProvider
    {
        MobileServiceUser RetrieveTokenFromSecureStore();

        void StoreTokenInSecureStore(MobileServiceUser user);

        void RemoveTokenFromSecureStore();

        Task<MobileServiceUser> LoginAsync(MobileServiceClient client);
    }
}
