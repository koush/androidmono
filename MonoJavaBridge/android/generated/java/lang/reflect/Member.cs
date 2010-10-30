namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.Member_))]
	public partial interface Member  : global::MonoJavaBridge.IJavaObject 
	{
		int getModifiers();
		global::java.lang.String getName();
		bool isSynthetic();
		global::java.lang.Class getDeclaringClass();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.Member))]
	internal sealed partial class Member_ : java.lang.Object, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Member_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21091;
		int java.lang.reflect.Member.getModifiers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Member_._getModifiers21091.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Member_._getModifiers21091 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getModifiers", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Member_._getModifiers21091);
		}
		internal static global::MonoJavaBridge.MethodId _getName21092;
		global::java.lang.String java.lang.reflect.Member.getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Member_._getName21092.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Member_._getName21092 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getName21092)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21093;
		bool java.lang.reflect.Member.isSynthetic()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Member_._isSynthetic21093.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Member_._isSynthetic21093 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "isSynthetic", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_._isSynthetic21093);
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21094;
		global::java.lang.Class java.lang.reflect.Member.getDeclaringClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Member_._getDeclaringClass21094.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Member_._getDeclaringClass21094 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getDeclaringClass21094)) as java.lang.Class;
		}
		static Member_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Member_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Member"));
		}
		internal static void InitJNI()
		{
		}
	}
}
