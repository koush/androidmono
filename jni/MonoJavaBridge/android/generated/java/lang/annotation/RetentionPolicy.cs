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
		internal static global::MonoJavaBridge.MethodId _values20973;
		public static global::java.lang.annotation.RetentionPolicy[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.RetentionPolicy>(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._values20973)) as java.lang.annotation.RetentionPolicy[];
		}
		internal static global::MonoJavaBridge.MethodId _valueOf20974;
		public static global::java.lang.annotation.RetentionPolicy valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._valueOf20974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.RetentionPolicy;
		}
		internal static global::MonoJavaBridge.FieldId _SOURCE20975;
		public static global::java.lang.annotation.RetentionPolicy SOURCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _SOURCE20975)) as java.lang.annotation.RetentionPolicy;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CLASS20976;
		public static global::java.lang.annotation.RetentionPolicy CLASS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _CLASS20976)) as java.lang.annotation.RetentionPolicy;
			}
		}
		internal static global::MonoJavaBridge.FieldId _RUNTIME20977;
		public static global::java.lang.annotation.RetentionPolicy RUNTIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _RUNTIME20977)) as java.lang.annotation.RetentionPolicy;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.RetentionPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/RetentionPolicy"));
			global::java.lang.annotation.RetentionPolicy._values20973 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "values", "()[Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._valueOf20974 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._SOURCE20975 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "SOURCE", "Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._CLASS20976 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "CLASS", "Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._RUNTIME20977 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "RUNTIME", "Ljava/lang/annotation/RetentionPolicy;");
		}
	}
}
