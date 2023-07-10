using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class ParticipantDAO
    {
        GroupStudyContext _context = new GroupStudyContext();
        //----------------------------------------------------
        // Singleton
        public static ParticipantDAO instance = null;
        public static object instanceLock = new object();
        private ParticipantDAO() { }
        public static ParticipantDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ParticipantDAO();
                }
                return instance;
            }
        }
        // Get all Participant
        public List<Participant> GetParticipants() => _context.Participants.ToList();
        // Number student in group by groupID
        public int NumberStudentInGroup(int groupID) => GetParticipants().Where(p => p.GroupId == groupID).Count();

        // Get list Participant by userID
        public List<Participant> GetGroupsJoined(int userID)
        {
            List<Participant> list =  GetParticipants().Where(p => p.UserId == userID).ToList();
            return list;
        }
        // add Participant
        public void AddParticipant(Participant participant)
        {   
                _context.Participants.Add(participant);
                _context.SaveChanges();          
        }
        // Update status participant by userID, groupID
        public void UpdateParticipant(int userID, int groupID, int status)
        {
            Participant partcipant = _context.Participants.SingleOrDefault(p => p.UserId == userID && p.GroupId == groupID);
            if (partcipant != null)
            {
                partcipant.Status = status;
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Can not update participant");
            }
        }
        public void DeleteParticipant(Participant participant)
        {
            var p = _context.Participants.SingleOrDefault(p => p.GroupId == participant.GroupId && p.UserId == participant.UserId);
            if (p != null)
            {
                _context.ChangeTracker.Clear();
                _context.Participants.Remove(participant);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Participant does not exist.");
            }
        }
    
        //Get listUser in Group
        public List<User> GetListUserInGroup(int groupID)
        {
            var list = _context.Participants.Where(x => x.GroupId == groupID).Select(x => x.User).ToList();
            return list;
        }

        //  Get group by userId
        public List<Group> GetListByUserId(int userId)
        {
            var list = _context.Participants.Where(x => x.UserId == userId && x.Status == 1).Select(x => x.Group).ToList(); 
            return list;
        }
        // Get list participant Peding by GroupID
        public List<Participant> GetParticipantsInGroupPeding(int groupID, int status)
        {
            var list = _context.Participants.Where(p => p.GroupId == groupID && p.Status == status).ToList();
            return list;
        }
        // Get list participant accepted by GroupID
        public List<Participant> GetParticipantsInGroupAccepted(int groupID, int status)
        {
            var list = _context.Participants.Where(p => p.GroupId == groupID && p.Status != status).ToList();
            return list;
        }
    }
}
