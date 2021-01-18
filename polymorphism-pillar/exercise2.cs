using System;

namespace ExerciseTwo
{
    // DATABASE CONNECTION

    public abstract class DbConnection
    {
        private readonly string _connectionString;
        protected readonly TimeSpan _timeout; 

        public DbConnection(string connection)
        {
            if (string.IsNullOrWhiteSpace(connection))
                throw new ArgumentNullException("The connection string cannot be a null value.");
    
            Random random = new Random();

            this._timeout = TimeSpan.FromMilliseconds(random.Next());
            this._connectionString = connection;   
        }

        public abstract void Open();
        public abstract void Close();
    }

    public class SqlConnection : DbConnection
    {
        private readonly DateTime _started;
        private bool _isOpen;

        public SqlConnection (string connection)
            : base (connection)
        {
            this._started = DateTime.Now;
        }

        public override void Open()
        {
            if (this._isOpen)
                throw new InvalidOperationException("SqlConnection is already opened.");
            DateTime now = DateTime.Now;
            TimeSpan duration = now - _started;
            if (duration.TotalMinutes > _timeout.TotalMinutes)
                throw new NotImplementedException("Couldn't open SqlConnection within timeout.");
            this._isOpen = true;
            System.Console.WriteLine("SqlConnection was opened.");
        }

        public override void Close()
        {
            if (!this._isOpen)
                throw new InvalidOperationException("SqlConnection is not opened.");
            this._isOpen = false;
            System.Console.WriteLine("SqlConnection was closed.");
        }
    }

    public class OracleConnection : DbConnection
    {
        private readonly DateTime _started;
        private bool _isOpen;

        public OracleConnection (string connection)
            : base (connection)
        {
            this._started = DateTime.Now;
        }

        public override void Open()
        {
            if (this._isOpen)
                throw new InvalidOperationException("OracleConnection is already opened.");
            DateTime now = DateTime.Now;
            TimeSpan duration = now - _started;
            if (duration.TotalMinutes > _timeout.TotalMinutes)
                throw new NotImplementedException("Couldn't open OracleConnection within timeout.");
            this._isOpen = true;
            System.Console.WriteLine("OracleConnection was opened.");
        }

        public override void Close()
        {
            if (!this._isOpen)
                throw new InvalidOperationException("OracleConnection is not opened.");
            this._isOpen = false;
            System.Console.WriteLine("OracleConnection was closed.");
        }
    }

    // DATABASE COMMAND

    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _instruction;
        private bool _isValid;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null || string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentNullException("Database Command received a null value.");
            
            this._instruction = instruction;
            this._dbConnection = connection;
        }

        public void SendToDatabase()
        {
            System.Console.WriteLine("Sending the instruction '{0}' to the database.", _instruction);
            this._isValid = true;
        }

        public void Execute()
        {
            if (!this._isValid)
                throw new InvalidOperationException("The command is not in a valid state.");
            _dbConnection.Open();
            System.Console.WriteLine("Running instruction...");
            _dbConnection.Close();
            this._isValid = false;
        }
    }

    // MAIN PROGRAM

    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection one = new SqlConnection("hello");
            OracleConnection two = new OracleConnection("world");

            DbCommand three = new DbCommand(one, "greet strangers");
            DbCommand four = new DbCommand(two, "conquer the planet");

            three.SendToDatabase();
            three.Execute();

            four.SendToDatabase();
            four.Execute();
        }
    }
}
