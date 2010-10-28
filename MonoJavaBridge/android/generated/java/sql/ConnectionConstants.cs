namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public static partial class ConnectionConstants 
	{
		public static int TRANSACTION_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int TRANSACTION_READ_UNCOMMITTED
		{
			get
			{
				return 1;
			}
		}
		public static int TRANSACTION_READ_COMMITTED
		{
			get
			{
				return 2;
			}
		}
		public static int TRANSACTION_REPEATABLE_READ
		{
			get
			{
				return 4;
			}
		}
		public static int TRANSACTION_SERIALIZABLE
		{
			get
			{
				return 8;
			}
		}
	}
}
