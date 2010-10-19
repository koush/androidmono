namespace org.apache.http.conn.routing
{
	[global::MonoJavaBridge.JavaClass()]
	public static partial class HttpRouteDirectorConstants 
	{
		public static int UNREACHABLE
		{
			get
			{
				return -1;
			}
		}
		public static int COMPLETE
		{
			get
			{
				return 0;
			}
		}
		public static int CONNECT_TARGET
		{
			get
			{
				return 1;
			}
		}
		public static int CONNECT_PROXY
		{
			get
			{
				return 2;
			}
		}
		public static int TUNNEL_TARGET
		{
			get
			{
				return 3;
			}
		}
		public static int TUNNEL_PROXY
		{
			get
			{
				return 4;
			}
		}
		public static int LAYER_PROTOCOL
		{
			get
			{
				return 5;
			}
		}
	}
}
