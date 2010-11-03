namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringTokenizer : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool hasMoreElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, "hasMoreElements", "()Z", ref global::java.util.StringTokenizer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.StringTokenizer.staticClass, "nextElement", "()Ljava/lang/Object;", ref global::java.util.StringTokenizer._m1) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int countTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.StringTokenizer.staticClass, "countTokens", "()I", ref global::java.util.StringTokenizer._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool hasMoreTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, "hasMoreTokens", "()Z", ref global::java.util.StringTokenizer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.StringTokenizer.staticClass, "nextToken", "()Ljava/lang/String;", ref global::java.util.StringTokenizer._m4) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String nextToken(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.StringTokenizer.staticClass, "nextToken", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.StringTokenizer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public StringTokenizer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._m6.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._m6 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._m7.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._m7 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._m8.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._m8 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static StringTokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.StringTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/StringTokenizer"));
		}
	}
}
