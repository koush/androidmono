namespace java.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StringTokenizer : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StringTokenizer()
		{
			InitJNI();
		}
		protected StringTokenizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreElements20878;
		public virtual bool hasMoreElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer._hasMoreElements20878);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreElements20878);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement20879;
		public virtual global::java.lang.Object nextElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextElement20879)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextElement20879)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _countTokens20880;
		public virtual int countTokens() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.StringTokenizer._countTokens20880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._countTokens20880);
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreTokens20881;
		public virtual bool hasMoreTokens() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer._hasMoreTokens20881);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._hasMoreTokens20881);
		}
		internal static global::MonoJavaBridge.MethodId _nextToken20882;
		public virtual global::java.lang.String nextToken() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextToken20882)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken20882)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextToken20883;
		public virtual global::java.lang.String nextToken(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.StringTokenizer._nextToken20883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._nextToken20883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer20884;
		public StringTokenizer(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer20884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer20885;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1, bool arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer20885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _StringTokenizer20886;
		public StringTokenizer(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.StringTokenizer.staticClass, global::java.util.StringTokenizer._StringTokenizer20886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.StringTokenizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/StringTokenizer"));
			global::java.util.StringTokenizer._hasMoreElements20878 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreElements", "()Z");
			global::java.util.StringTokenizer._nextElement20879 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextElement", "()Ljava/lang/Object;");
			global::java.util.StringTokenizer._countTokens20880 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "countTokens", "()I");
			global::java.util.StringTokenizer._hasMoreTokens20881 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "hasMoreTokens", "()Z");
			global::java.util.StringTokenizer._nextToken20882 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "()Ljava/lang/String;");
			global::java.util.StringTokenizer._nextToken20883 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "nextToken", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.util.StringTokenizer._StringTokenizer20884 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.util.StringTokenizer._StringTokenizer20885 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			global::java.util.StringTokenizer._StringTokenizer20886 = @__env.GetMethodIDNoThrow(global::java.util.StringTokenizer.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
