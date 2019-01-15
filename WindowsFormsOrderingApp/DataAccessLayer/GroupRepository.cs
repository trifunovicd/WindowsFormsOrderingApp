using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GroupRepository
    {
        string connectionString = "Data Source=193.198.57.183; Initial Catalog = DotNet;User ID = vjezbe; Password = vjezbe";
        public List<Group> _groups = new List<Group>();
        public GroupRepository()
        {
            _groups = GetGroups();
        }
        public List<Group> GetGroups()
        {
            var groups = new List<Group>();
            using (DbConnection connection = new SqlConnection(connectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM Ordering_Groups";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groups.Add(new Group()
                        {
                            Id = (int)reader["Id"],
                            Naziv = (string)reader["Naziv"]
                        });
                    }
                }
            }
            return groups;
        }

        public List<string> GetGroupNames()
        {
            var groups = _groups.Select(g => g.Naziv).OrderBy(g => g).ToList();
            groups.Insert(0, "-- Odaberite grupu --");
            return groups;
        }

        public int GetGroupId(string groupName)
        {
            int groupId = _groups.Where(g => g.Naziv == groupName).Select(g => g.Id).FirstOrDefault();

            return groupId;
        }
    }
}
