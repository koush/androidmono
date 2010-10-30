namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringTokenizer : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StringTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreElements26825;
		public virtual bool hasMoreElements()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, "hasMoreElements", "()Z", ref global::java.util.StringTokenizer._hasMoreElements26825);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement26826;
		public virtual global::java.lang.Object nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.StringTokenizer.staticClass, "nextElement", "()Ljava/lang/Object;", ref global::java.util.StringTokenizer._nextElement26826) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _countTokens26827;
		public virtual int countTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.StringTokenizer.staticClass, "countTokens", "()I", ref global::java.util.StringTokenizer._countTokens26827);
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreTokens26828;
		public virtual bool hasMoreTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, "hasMoreTokens", "()Z", ref global::java.util.StringTokenizer._hasMoreTokens26828);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26829;
		public virtual global::java.lang.String nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.StringTokenizer.staticClass, "nextToken", "()Ljava/lang/String;", ref global::java.util.StringTokenizer._nextToken26829) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26830;
		public virtual global::java.lang.String nextToken(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.StringTokenizer.staticClass, "nextToken", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.util.StringTokenizer._nextToken26830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26831;
		public StringTokenizer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._StringTokenizer26831.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._StringTokenizer26831 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26832;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._StringTokenizer26832.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._StringTokenizer26832 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26833;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.StringTokenizer._StringTokenizer26833.native == global::System.IntPtr.Zero)
				global::java.util.StringTokenizer._StringTokenizer26833 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static StringTokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.StringTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/StringTokenizer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
