using BusinessObjects.DBContext;
using BusinessObjects.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects;

public class UserDAO
{
    GroupStudyContext _context = new GroupStudyContext();
    //-----------------------------------------
    // Apply Singleton patter
    private UserDAO() { }
    private static UserDAO instance = null;
    private static object instanceLock = new object();
    public static UserDAO Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
            }

            return instance;
        }
    }

    //----------------------------------------
    // Get user list
    public List<User> GetUsers() => _context.Users.Include(x => x.Role).ToList();

    // Get user by id
    public User GetUser(int id)
    {
        var user = _context.Users.SingleOrDefault(x => x.UserId == id);
        return user;
    }

    // Get user by email
    public User GetUserByEmail(string email)
    {
        var user = _context.Users.SingleOrDefault(x => x.Email == email);
        return user;
    }
    //--------------------------------------
    // Add new user
    public void AddNew(User newUser)
    {
        var user = GetUserByEmail(newUser.Email);
        if (user == null)
        {
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }
        else
        {
            throw new Exception("User already exist");
        }
    }
    
    //Update user
    public void Update(User newUser)
    {
        var user = GetUser(newUser.UserId);
        if (user != null)
        {
            _context.ChangeTracker.Clear();
            _context.Users.Update(newUser);
            _context.SaveChanges();
        }
        else
        {
            throw new Exception("User does not exist");
        }
    }

    // Delete user 
    public void Delete(int id)
    {
        var user = GetUser(id);
        if (user != null)
        {
            _context.Remove(user);
            _context.SaveChanges();
        }
        else {
            throw new Exception("User does not exist"); 
        }
    }
}
