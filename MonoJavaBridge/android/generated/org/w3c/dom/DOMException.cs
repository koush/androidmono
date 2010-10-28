namespace org.w3c.dom
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DOMException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DOMException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DOMException34350;
		public DOMException(short arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.w3c.dom.DOMException.staticClass, global::org.w3c.dom.DOMException._DOMException34350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _code34351;
		public short code
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetShortField(this.JvmHandle, _code34351);
			}
			set
			{
			}
		}
		public static short INDEX_SIZE_ERR
		{
			get
			{
				return 1;
			}
		}
		public static short DOMSTRING_SIZE_ERR
		{
			get
			{
				return 2;
			}
		}
		public static short HIERARCHY_REQUEST_ERR
		{
			get
			{
				return 3;
			}
		}
		public static short WRONG_DOCUMENT_ERR
		{
			get
			{
				return 4;
			}
		}
		public static short INVALID_CHARACTER_ERR
		{
			get
			{
				return 5;
			}
		}
		public static short NO_DATA_ALLOWED_ERR
		{
			get
			{
				return 6;
			}
		}
		public static short NO_MODIFICATION_ALLOWED_ERR
		{
			get
			{
				return 7;
			}
		}
		public static short NOT_FOUND_ERR
		{
			get
			{
				return 8;
			}
		}
		public static short NOT_SUPPORTED_ERR
		{
			get
			{
				return 9;
			}
		}
		public static short INUSE_ATTRIBUTE_ERR
		{
			get
			{
				return 10;
			}
		}
		public static short INVALID_STATE_ERR
		{
			get
			{
				return 11;
			}
		}
		public static short SYNTAX_ERR
		{
			get
			{
				return 12;
			}
		}
		public static short INVALID_MODIFICATION_ERR
		{
			get
			{
				return 13;
			}
		}
		public static short NAMESPACE_ERR
		{
			get
			{
				return 14;
			}
		}
		public static short INVALID_ACCESS_ERR
		{
			get
			{
				return 15;
			}
		}
		public static short VALIDATION_ERR
		{
			get
			{
				return 16;
			}
		}
		public static short TYPE_MISMATCH_ERR
		{
			get
			{
				return 17;
			}
		}
		static DOMException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.DOMException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/DOMException"));
			global::org.w3c.dom.DOMException._DOMException34350 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.DOMException.staticClass, "<init>", "(SLjava/lang/String;)V");
			global::org.w3c.dom.DOMException._code34351 = @__env.GetFieldIDNoThrow(global::org.w3c.dom.DOMException.staticClass, "code", "S");
		}
		internal static void InitJNI()
		{
		}
	}
}
