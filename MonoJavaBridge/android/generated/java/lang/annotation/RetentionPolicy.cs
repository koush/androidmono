namespace java.lang.annotation
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class RetentionPolicy : java.lang.Enum
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RetentionPolicy(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.annotation.RetentionPolicy[] values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.RetentionPolicy._m0.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.RetentionPolicy._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "values", "()[Ljava/lang/annotation/RetentionPolicy;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.RetentionPolicy>(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._m0)) as java.lang.annotation.RetentionPolicy[];
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.annotation.RetentionPolicy valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.annotation.RetentionPolicy._m1.native == global::System.IntPtr.Zero)
				global::java.lang.annotation.RetentionPolicy._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/annotation/RetentionPolicy;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.CallStaticObjectMethod(java.lang.annotation.RetentionPolicy.staticClass, global::java.lang.annotation.RetentionPolicy._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.RetentionPolicy;
		}
		internal static global::MonoJavaBridge.FieldId _SOURCE6408;
		public static global::java.lang.annotation.RetentionPolicy SOURCE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _SOURCE6408)) as java.lang.annotation.RetentionPolicy;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CLASS6409;
		public static global::java.lang.annotation.RetentionPolicy CLASS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _CLASS6409)) as java.lang.annotation.RetentionPolicy;
			}
		}
		internal static global::MonoJavaBridge.FieldId _RUNTIME6410;
		public static global::java.lang.annotation.RetentionPolicy RUNTIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.annotation.RetentionPolicy>(@__env.GetStaticObjectField(global::java.lang.annotation.RetentionPolicy.staticClass, _RUNTIME6410)) as java.lang.annotation.RetentionPolicy;
			}
		}
		static RetentionPolicy()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.annotation.RetentionPolicy.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/annotation/RetentionPolicy"));
			global::java.lang.annotation.RetentionPolicy._SOURCE6408 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "SOURCE", "Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._CLASS6409 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "CLASS", "Ljava/lang/annotation/RetentionPolicy;");
			global::java.lang.annotation.RetentionPolicy._RUNTIME6410 = @__env.GetStaticFieldIDNoThrow(global::java.lang.annotation.RetentionPolicy.staticClass, "RUNTIME", "Ljava/lang/annotation/RetentionPolicy;");
		}
	}
}
