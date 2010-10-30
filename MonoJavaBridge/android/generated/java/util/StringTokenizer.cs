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
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreElements26825);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement26826;
		public virtual global::java.lang.Object nextElement()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextElement26826)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _countTokens26827;
		public virtual int countTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._countTokens26827);
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreTokens26828;
		public virtual bool hasMoreTokens()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreTokens26828);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26829;
		public virtual global::java.lang.String nextToken()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken26829)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken26830;
		public virtual global::java.lang.String nextToken(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken26830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26831;
		public StringTokenizer(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26832;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer26833;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer26833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static StringTokenizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.StringTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/StringTokenizer"));
			global::java.util.StringTokenizer._hasMoreElements26825 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreElements", "()Z");
			global::java.util.StringTokenizer._nextElement26826 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextElement", "()Ljava/lang/Object;");
			global::java.util.StringTokenizer._countTokens26827 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "countTokens", "()I");
			global::java.util.StringTokenizer._hasMoreTokens26828 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreTokens", "()Z");
			global::java.util.StringTokenizer._nextToken26829 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "()Ljava/lang/String;");
			global::java.util.StringTokenizer._nextToken26830 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.StringTokenizer._StringTokenizer26831 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.StringTokenizer._StringTokenizer26832 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::java.util.StringTokenizer._StringTokenizer26833 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
