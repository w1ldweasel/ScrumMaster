string query1 = "SELECT count(*) FROM [User] WHERE [Account] = '" + account + "' AND [Password] = '" + password + "'";
string query2 = String.Format("SELECT count(*) FROM [User] WHERE [Account] = '{0}' AND [Password] = '{1}'", account, password);
string query3 = 0;
string query4 = 1;