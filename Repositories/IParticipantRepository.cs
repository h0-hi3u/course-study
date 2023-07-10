using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IParticipantRepository
    {
        List<Participant> GetParticipants();
        int NumberStudentInGroup(int groupID);
        List<Participant> GetGroupsJoined(int userID);
        void AddParticipant(Participant participant);
        void DeleteParticipant(Participant participant);
        List<User> GetListUserInGroup(int groupID);
        List<Group> GetListByUserId(int userId);
        List<Participant> GetParticipantsInGroupPending(int groupID, int status);
        List<Participant> GetParticipantsInGroupAccepted(int groupID, int status);
        void UpdateParticipant(int userID, int groupID, int status);
    }
}
