namespace org.w3c.dom.ls
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LSException : java.lang.RuntimeException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LSException()
		{
			InitJNI();
		}
		protected LSException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _LSException34888;
		public LSException(short arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.w3c.dom.ls.LSException.staticClass, global::org.w3c.dom.ls.LSException._LSException34888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _code34889;
		public short code
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetShortField(this.JvmHandle, _code34889);
			}
			set
			{
			}
		}
		public static short PARSE_ERR
		{
			get
			{
				return 81;
			}
		}
		public static short SERIALIZE_ERR
		{
			get
			{
				return 82;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.w3c.dom.ls.LSException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/w3c/dom/ls/LSException"));
			global::org.w3c.dom.ls.LSException._LSException34888 = @__env.GetMethodIDNoThrow(global::org.w3c.dom.ls.LSException.staticClass, "<init>", "(SLjava/lang/String;)V");
			global::org.w3c.dom.ls.LSException._code34889 = @__env.GetFieldIDNoThrow(global::org.w3c.dom.ls.LSException.staticClass, "code", "S");
		}
	}
}
