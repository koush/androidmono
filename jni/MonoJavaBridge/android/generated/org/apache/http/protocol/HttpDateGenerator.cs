namespace org.apache.http.protocol
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpDateGenerator : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpDateGenerator()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getCurrentDate33888;
		public virtual global::java.lang.String getCurrentDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpDateGenerator._getCurrentDate33888)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.protocol.HttpDateGenerator.staticClass, global::org.apache.http.protocol.HttpDateGenerator._getCurrentDate33888)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _HttpDateGenerator33889;
		public HttpDateGenerator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.protocol.HttpDateGenerator.staticClass, global::org.apache.http.protocol.HttpDateGenerator._HttpDateGenerator33889);
			Init(@__env, handle);
		}
		public static global::java.lang.String PATTERN_RFC1123
		{
			get
			{
				return "EEE, dd MMM yyyy HH:mm:ss zzz";
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMT33891;
		public static global::java.util.TimeZone GMT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.protocol.HttpDateGenerator.staticClass, _GMT33891)) as java.util.TimeZone;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.protocol.HttpDateGenerator.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/protocol/HttpDateGenerator"));
			global::org.apache.http.protocol.HttpDateGenerator._getCurrentDate33888 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpDateGenerator.staticClass, "getCurrentDate", "()Ljava/lang/String;");
			global::org.apache.http.protocol.HttpDateGenerator._HttpDateGenerator33889 = @__env.GetMethodIDNoThrow(global::org.apache.http.protocol.HttpDateGenerator.staticClass, "<init>", "()V");
			global::org.apache.http.protocol.HttpDateGenerator._GMT33891 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.protocol.HttpDateGenerator.staticClass, "GMT", "Ljava/util/TimeZone;");
		}
	}
}
