namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpDateGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpDateGenerator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String CurrentDate
		{
			get
			{
				return getCurrentDate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getCurrentDate()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.protocol.HttpDateGenerator.staticClass, "getCurrentDate", "()Ljava/lang/String;", ref global::org.apache.http.protocol.HttpDateGenerator._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public HttpDateGenerator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.protocol.HttpDateGenerator._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.protocol.HttpDateGenerator._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpDateGenerator.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpDateGenerator.staticClass, global::org.apache.http.protocol.HttpDateGenerator._m1);
			Init(@__env, handle);
		}
		public static global::java.lang.String PATTERN_RFC1123
		{
			get
			{
				return "EEE, dd MMM yyyy HH:mm:ss zzz";
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMT7570;
		public static global::java.util.TimeZone GMT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.protocol.HttpDateGenerator.staticClass, _GMT7570)) as java.util.TimeZone;
			}
		}
		static HttpDateGenerator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpDateGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpDateGenerator"));
			global::org.apache.http.protocol.HttpDateGenerator._GMT7570 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.protocol.HttpDateGenerator.staticClass, "GMT", "Ljava/util/TimeZone;");
		}
	}
}
