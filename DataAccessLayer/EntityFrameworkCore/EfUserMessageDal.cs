using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameworkCore
{
	public class EfUserMessageDal : GenericRepository<UserMessage>, IUserMessageDal
	{
		public List<UserMessage> GetUserMessageWithUsers()
		{
			using (var context = new Context())
			{
				return context.UserMessages.Include(x => x.User).ToList();
			}
		}
	}
}
