namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Types : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Types(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static int BIT
		{
			get
			{
				return -7;
			}
		}
		public static int TINYINT
		{
			get
			{
				return -6;
			}
		}
		public static int SMALLINT
		{
			get
			{
				return 5;
			}
		}
		public static int INTEGER
		{
			get
			{
				return 4;
			}
		}
		public static int BIGINT
		{
			get
			{
				return -5;
			}
		}
		public static int FLOAT
		{
			get
			{
				return 6;
			}
		}
		public static int REAL
		{
			get
			{
				return 7;
			}
		}
		public static int DOUBLE
		{
			get
			{
				return 8;
			}
		}
		public static int NUMERIC
		{
			get
			{
				return 2;
			}
		}
		public static int DECIMAL
		{
			get
			{
				return 3;
			}
		}
		public static int CHAR
		{
			get
			{
				return 1;
			}
		}
		public static int VARCHAR
		{
			get
			{
				return 12;
			}
		}
		public static int LONGVARCHAR
		{
			get
			{
				return -1;
			}
		}
		public static int DATE
		{
			get
			{
				return 91;
			}
		}
		public static int TIME
		{
			get
			{
				return 92;
			}
		}
		public static int TIMESTAMP
		{
			get
			{
				return 93;
			}
		}
		public static int BINARY
		{
			get
			{
				return -2;
			}
		}
		public static int VARBINARY
		{
			get
			{
				return -3;
			}
		}
		public static int LONGVARBINARY
		{
			get
			{
				return -4;
			}
		}
		public static int NULL
		{
			get
			{
				return 0;
			}
		}
		public static int OTHER
		{
			get
			{
				return 1111;
			}
		}
		public static int JAVA_OBJECT
		{
			get
			{
				return 2000;
			}
		}
		public static int DISTINCT
		{
			get
			{
				return 2001;
			}
		}
		public static int STRUCT
		{
			get
			{
				return 2002;
			}
		}
		public static int ARRAY
		{
			get
			{
				return 2003;
			}
		}
		public static int BLOB
		{
			get
			{
				return 2004;
			}
		}
		public static int CLOB
		{
			get
			{
				return 2005;
			}
		}
		public static int REF
		{
			get
			{
				return 2006;
			}
		}
		public static int DATALINK
		{
			get
			{
				return 70;
			}
		}
		public static int BOOLEAN
		{
			get
			{
				return 16;
			}
		}
		public static int ROWID
		{
			get
			{
				return -8;
			}
		}
		public static int NCHAR
		{
			get
			{
				return -15;
			}
		}
		public static int NVARCHAR
		{
			get
			{
				return -9;
			}
		}
		public static int LONGNVARCHAR
		{
			get
			{
				return -16;
			}
		}
		public static int NCLOB
		{
			get
			{
				return 2011;
			}
		}
		public static int SQLXML
		{
			get
			{
				return 2009;
			}
		}
		static Types()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Types.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Types"));
		}
	}
}
