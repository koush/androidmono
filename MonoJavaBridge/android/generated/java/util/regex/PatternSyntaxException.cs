namespace java.util.regex
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PatternSyntaxException : java.lang.IllegalArgumentException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PatternSyntaxException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.PatternSyntaxException.staticClass, "getMessage", "()Ljava/lang/String;", ref global::java.util.regex.PatternSyntaxException._m0) as java.lang.String;
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int getIndex()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.regex.PatternSyntaxException.staticClass, "getIndex", "()I", ref global::java.util.regex.PatternSyntaxException._m1);
		}
		public new global::java.lang.String Description
		{
			get
			{
				return getDescription();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::java.lang.String getDescription()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.PatternSyntaxException.staticClass, "getDescription", "()Ljava/lang/String;", ref global::java.util.regex.PatternSyntaxException._m2) as java.lang.String;
		}
		public new global::java.lang.String Pattern
		{
			get
			{
				return getPattern();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getPattern()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.util.regex.PatternSyntaxException.staticClass, "getPattern", "()Ljava/lang/String;", ref global::java.util.regex.PatternSyntaxException._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PatternSyntaxException(java.lang.String arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.regex.PatternSyntaxException._m4.native == global::System.IntPtr.Zero)
				global::java.util.regex.PatternSyntaxException._m4 = @__env.GetMethodIDNoThrow(global::java.util.regex.PatternSyntaxException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.regex.PatternSyntaxException.staticClass, global::java.util.regex.PatternSyntaxException._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static PatternSyntaxException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.regex.PatternSyntaxException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/regex/PatternSyntaxException"));
		}
	}
}
