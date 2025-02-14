using OnlineVotingSystem.Areas.Identity.Data;
using System.Runtime.Intrinsics.X86;

namespace OnlineVotingSystem.ViewModel
{
    public class ConvertApplicationUser
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public bool IsVoter { get; set; }
        public string ProfileImage { get; set; }
        public List<ConvertApplicationUser> ApplicationUsers { get; set; } = new List<ConvertApplicationUser>();
        public ConvertApplicationUser()
        {

        }

        public static ConvertApplicationUser EditConvertModel(OnlineVotingSystemUser user)
        {
            ConvertApplicationUser vm = new ConvertApplicationUser();
            vm.Id = user.Id;
            vm.IsVoter = user.IsVoter;
            return vm;

        }
        
        public ConvertApplicationUser(List<OnlineVotingSystemUser> users)
        {
            foreach (var user in users) 
            {
                ApplicationUsers.Add(
                                    new ConvertApplicationUser
                                    {
                                        Id = user.Id,
                                        Email = user.Email,
                                        Name = user.Name,
                                        Mobile = user.Mobile,
                                        State = user.State,
                                        City = user.City,
                                        BirthDate = user.BirthDate,
                                        Address = user.Address,
                                        IsVoter = user.IsVoter,
                                        ProfileImage = user.ProfileImage

                                    });

            }
            
            
        }
    }
}
