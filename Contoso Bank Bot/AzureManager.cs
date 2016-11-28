using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.WindowsAzure.MobileServices;
using Contoso_Bank_Bot.Models;
using System.Threading.Tasks;

namespace Contoso_Bank_Bot
{
    public class AzureManager
    {
        private static AzureManager instance;
        private MobileServiceClient client;

        private IMobileServiceTable<User> userTable;

        private AzureManager()
        {
            this.client = new MobileServiceClient("http://contosobankasc132.azurewebsites.net");
            this.userTable = this.client.GetTable<User>();
        }

        public MobileServiceClient AzureClient
        {
            get { return client; }
        }

        public static AzureManager AzureManagerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AzureManager();
                }

                return instance;
            }
        }

        public async Task<List<User>> GetUser()
        {
            return await this.userTable.ToListAsync();
        }

        public async Task AddUser(User user)
        {
            await this.userTable.InsertAsync(user);
        }

        public async Task UpdateUser(User user)
        {
            await this.userTable.UpdateAsync(user);
        }

        public async Task DeleteUser(User user)
        {
            await this.userTable.DeleteAsync(user);
        }
    }
}