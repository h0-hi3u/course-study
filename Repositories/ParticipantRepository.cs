using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        void IParticipantRepository.AddParticipant(Participant participant) => ParticipantDAO.Instance.AddParticipant(participant);

        void IParticipantRepository.DeleteParticipant(Participant participant) => ParticipantDAO.Instance.DeleteParticipant(participant);

        List<Participant> IParticipantRepository.GetGroupsJoined(int userID) => ParticipantDAO.Instance.GetGroupsJoined(userID);

        List<Participant> IParticipantRepository.GetParticipants() => ParticipantDAO.Instance.GetParticipants();

        int IParticipantRepository.NumberStudentInGroup(int groupID) => ParticipantDAO.Instance.NumberStudentInGroup(groupID);

        List<User> IParticipantRepository.GetListUserInGroup(int groupID) => ParticipantDAO.Instance.GetListUserInGroup(groupID);

        public List<Group> GetListByUserId(int userId) => ParticipantDAO.Instance.GetListByUserId(userId);

        List<Participant> IParticipantRepository.GetParticipantsInGroupPending(int groupID, int status) => ParticipantDAO.Instance.GetParticipantsInGroupPeding(groupID, status);

        List<Participant> IParticipantRepository.GetParticipantsInGroupAccepted(int groupID, int status) => ParticipantDAO.Instance.GetParticipantsInGroupAccepted(groupID, status);

        void IParticipantRepository.UpdateParticipant(int userID, int groupID, int status) => ParticipantDAO.Instance.UpdateParticipant(userID, groupID, status);
    }
}
