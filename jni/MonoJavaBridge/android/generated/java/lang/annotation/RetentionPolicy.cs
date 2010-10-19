namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RetentionPolicy : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RetentionPolicy()
		{
			InitJNI();
		}
		internal RetentionPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _values15333;
		public static global::java.lang.annotation.RetentionPolicy[] values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.RetentionPolicy>(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._values15333)) as java.lang.annotation.RetentionPolicy[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf15334;
		public static global::java.lang.annotation.RetentionPolicy valueOf(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._valueOf15334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.RetentionPolicy;
		}
		internal static global::MonoJavaBridge.FieldId _SOURCE15335;
		public static global::java.lang.annotation.RetentionPolicy SOURCE
		{
			get
			{
				return default(global::java.lang.annotation.RetentionPolicy);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CLASS15336;
		public static global::java.lang.annotation.RetentionPolicy CLASS
		{
			get
			{
				return default(global::java.lang.annotation.RetentionPolicy);
			}
		}
		internal static global::MonoJavaBridge.FieldId _RUNTIME15337;
		public static global::java.lang.annotation.RetentionPolicy RUNTIME
		{
			get
			{
				return default(global::java.lang.annotation.RetentionPolicy);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.RetentionPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/RetentionPolicy"));
			global::java.lang.annotation.RetentionPolicy._values15333 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "values", "()[Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._valueOf15334 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;");
		}
	}
}
