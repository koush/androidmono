namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class EnglishReasonPhraseCatalog : java.lang.Object, ReasonPhraseCatalog
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected EnglishReasonPhraseCatalog(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getReason(int arg0, java.util.Locale arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "getReason", "(ILjava/util/Locale;)Ljava/lang/String;", ref global::org.apache.http.impl.EnglishReasonPhraseCatalog._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected EnglishReasonPhraseCatalog() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.EnglishReasonPhraseCatalog._m1.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.EnglishReasonPhraseCatalog._m1 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, global::org.apache.http.impl.EnglishReasonPhraseCatalog._m1);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _INSTANCE7498;
		public static global::org.apache.http.impl.EnglishReasonPhraseCatalog INSTANCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, _INSTANCE7498)) as org.apache.http.impl.EnglishReasonPhraseCatalog;
			}
		}
		static EnglishReasonPhraseCatalog()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/EnglishReasonPhraseCatalog"));
			global::org.apache.http.impl.EnglishReasonPhraseCatalog._INSTANCE7498 = @__env.GetStaticFieldIDNoThrow(global::org.apache.http.impl.EnglishReasonPhraseCatalog.staticClass, "INSTANCE", "Lorg/apache/http/impl/EnglishReasonPhraseCatalog;");
		}
	}
}
