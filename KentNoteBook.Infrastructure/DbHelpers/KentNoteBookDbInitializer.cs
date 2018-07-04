﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KentNoteBook.Data;

namespace KentNoteBook.Infrastructure
{
	public static class KentNoteBookDbInitializer
	{
		public static void SeedData(this KentNoteBookDbContext db) {
			if ( !db.Users.Any() ) {
				db.Users.Add(new Data.Entities.User {
					Id = Guid.NewGuid(),
					Name = "Admin",
					NickName = "Admin",
					Password = "123456",
					Email = "admin@admin.com",
					Mobile = "13811111111",
					IsActive = true,
					Status = Status.Enabled
				});
			}

			db.SaveChanges();
		}
	}
}