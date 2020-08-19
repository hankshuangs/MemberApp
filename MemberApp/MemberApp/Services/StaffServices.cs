using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MemberApp.Models;
using MemberApp.RestClient;

namespace MemberApp.Services
{
    class StaffServices
    {
        public async Task<List<Staff>> GetStaffAsync()
        {
            RestClient<Staff> restClient = new RestClient<Staff>();
            var StaffsList = await restClient.GetAsync();
            return StaffsList;
        }

        public async Task<bool> PostStaffAsync(Staff Staff)
        {
            RestClient<Staff> restClient = new RestClient<Staff>();
            var IsSuccessStatusCode = await restClient.PostAsync(Staff);
            return IsSuccessStatusCode;
        }

        public async Task<bool> PutStaffAsync(int id, Staff Staff)
        {
            RestClient<Staff> restClient = new RestClient<Staff>();
            var IsSuccessStatusCode = await restClient.PutAsync(id, Staff);
            return IsSuccessStatusCode;
        }

        public async Task<bool> DeleteStaffAsync(int id)
        {
            RestClient<Staff> restClient = new RestClient<Staff>();
            var IsSuccessStatusCode = await restClient.DeleteAsync(id);
            return IsSuccessStatusCode;
        }

        //public async Task<List<Staff>> GetStaffByKeywordAsync(string keyword)
        //{
        //    RestClient<Staff> restClient = new RestClient<Staff>();
        //    var StaffsList = await restClient.GetByKeywordAsAsync(keyword);
        //    return StaffsList;
        //}

        public async Task<List<Staff>> GetStaffAsync(string keyword)
        {
            RestClient<Staff> restClient = new RestClient<Staff>();
            var StaffsList = await restClient.GetStaffAsAsync(keyword);
            return StaffsList;
        }
    }
}
