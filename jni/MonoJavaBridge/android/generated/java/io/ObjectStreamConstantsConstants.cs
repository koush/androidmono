namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public static partial class ObjectStreamConstantsConstants 
	{
		public static short STREAM_MAGIC
		{
			get
			{
				return -21267;
			}
		}
		public static short STREAM_VERSION
		{
			get
			{
				return 5;
			}
		}
		public static byte TC_BASE
		{
			get
			{
				return 112;
			}
		}
		public static byte TC_NULL
		{
			get
			{
				return 112;
			}
		}
		public static byte TC_REFERENCE
		{
			get
			{
				return 113;
			}
		}
		public static byte TC_CLASSDESC
		{
			get
			{
				return 114;
			}
		}
		public static byte TC_OBJECT
		{
			get
			{
				return 115;
			}
		}
		public static byte TC_STRING
		{
			get
			{
				return 116;
			}
		}
		public static byte TC_ARRAY
		{
			get
			{
				return 117;
			}
		}
		public static byte TC_CLASS
		{
			get
			{
				return 118;
			}
		}
		public static byte TC_BLOCKDATA
		{
			get
			{
				return 119;
			}
		}
		public static byte TC_ENDBLOCKDATA
		{
			get
			{
				return 120;
			}
		}
		public static byte TC_RESET
		{
			get
			{
				return 121;
			}
		}
		public static byte TC_BLOCKDATALONG
		{
			get
			{
				return 122;
			}
		}
		public static byte TC_EXCEPTION
		{
			get
			{
				return 123;
			}
		}
		public static byte TC_LONGSTRING
		{
			get
			{
				return 124;
			}
		}
		public static byte TC_PROXYCLASSDESC
		{
			get
			{
				return 125;
			}
		}
		public static byte TC_ENUM
		{
			get
			{
				return 126;
			}
		}
		public static byte TC_MAX
		{
			get
			{
				return 126;
			}
		}
		public static int baseWireHandle
		{
			get
			{
				return 8257536;
			}
		}
		public static byte SC_WRITE_METHOD
		{
			get
			{
				return 1;
			}
		}
		public static byte SC_BLOCK_DATA
		{
			get
			{
				return 8;
			}
		}
		public static byte SC_SERIALIZABLE
		{
			get
			{
				return 2;
			}
		}
		public static byte SC_EXTERNALIZABLE
		{
			get
			{
				return 4;
			}
		}
		public static byte SC_ENUM
		{
			get
			{
				return 16;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SUBSTITUTION_PERMISSION19332;
		public static global::java.io.SerializablePermission SUBSTITUTION_PERMISSION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.SerializablePermission>(@__env.GetStaticObjectField(global::java.io.ObjectStreamConstants_.staticClass, _SUBSTITUTION_PERMISSION19332)) as java.io.SerializablePermission;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SUBCLASS_IMPLEMENTATION_PERMISSION19333;
		public static global::java.io.SerializablePermission SUBCLASS_IMPLEMENTATION_PERMISSION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.SerializablePermission>(@__env.GetStaticObjectField(global::java.io.ObjectStreamConstants_.staticClass, _SUBCLASS_IMPLEMENTATION_PERMISSION19333)) as java.io.SerializablePermission;
			}
		}
		public static int PROTOCOL_VERSION_1
		{
			get
			{
				return 1;
			}
		}
		public static int PROTOCOL_VERSION_2
		{
			get
			{
				return 2;
			}
		}
	}
}
