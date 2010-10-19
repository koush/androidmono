namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.lang.reflect.Member_))]
	public interface Member  : global::MonoJavaBridge.IJavaObject 
	{
		int getModifiers();
		global::java.lang.String getName();
		bool isSynthetic();
		global::java.lang.Class getDeclaringClass();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.lang.reflect.Member))]
	public sealed partial class Member_ : java.lang.Object, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Member_()
		{
			InitJNI();
		}
		internal Member_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers15450;
		 int java.lang.reflect.Member.getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Member_._getModifiers15450);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getModifiers15450);
		}
		internal static global::MonoJavaBridge.MethodId _getName15451;
		 global::java.lang.String java.lang.reflect.Member.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getName15451)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getName15451)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic15452;
		 bool java.lang.reflect.Member.isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_._isSynthetic15452);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._isSynthetic15452);
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass15453;
		 global::java.lang.Class java.lang.reflect.Member.getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getDeclaringClass15453)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getDeclaringClass15453)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Member_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Member"));
			global::java.lang.reflect.Member_._getModifiers15450 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Member_._getName15451 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Member_._isSynthetic15452 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Member_._getDeclaringClass15453 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
		}
	}
}
