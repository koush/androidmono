namespace dalvik.annotation
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::dalvik.annotation.TestTarget_))]
	public partial interface TestTarget : java.lang.annotation.Annotation
	{
		global::java.lang.String methodName();
		global::java.lang.String conceptName();
		global::java.lang.Class[] methodArgs();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::dalvik.annotation.TestTarget))]
	internal sealed partial class TestTarget_ : java.lang.Object, TestTarget
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal TestTarget_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _methodName18337;
		global::java.lang.String dalvik.annotation.TestTarget.methodName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._methodName18337.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._methodName18337 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "methodName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._methodName18337)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _conceptName18338;
		global::java.lang.String dalvik.annotation.TestTarget.conceptName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._conceptName18338.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._conceptName18338 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "conceptName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._conceptName18338)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _methodArgs18339;
		global::java.lang.Class[] dalvik.annotation.TestTarget.methodArgs()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._methodArgs18339.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._methodArgs18339 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "methodArgs", "()[Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._methodArgs18339)) as java.lang.Class[];
		}
		internal static global::MonoJavaBridge.MethodId _equals18340;
		bool java.lang.annotation.Annotation.equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._equals18340.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._equals18340 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._equals18340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString18341;
		global::java.lang.String java.lang.annotation.Annotation.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._toString18341.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._toString18341 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._toString18341)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode18342;
		int java.lang.annotation.Annotation.hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._hashCode18342.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._hashCode18342 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "hashCode", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._hashCode18342);
		}
		internal static global::MonoJavaBridge.MethodId _annotationType18343;
		global::java.lang.Class java.lang.annotation.Annotation.annotationType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::dalvik.annotation.TestTarget_._annotationType18343.native == global::System.IntPtr.Zero)
				global::dalvik.annotation.TestTarget_._annotationType18343 = @__env.GetMethodIDNoThrow(global::dalvik.annotation.TestTarget_.staticClass, "annotationType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::dalvik.annotation.TestTarget_._annotationType18343)) as java.lang.Class;
		}
		static TestTarget_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::dalvik.annotation.TestTarget_.staticClass = @__env.NewGlobalRef(@__env.FindClass("dalvik/annotation/TestTarget"));
		}
		internal static void InitJNI()
		{
		}
	}
}
