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
		static Member_()
		{
			InitJNI();
		}
		internal Member_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21090;
		 int java.lang.reflect.Member.getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Member_._getModifiers21090);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getModifiers21090);
		}
		internal static global::MonoJavaBridge.MethodId _getName21091;
		 global::java.lang.String java.lang.reflect.Member.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getName21091)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getName21091)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21092;
		 bool java.lang.reflect.Member.isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_._isSynthetic21092);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._isSynthetic21092);
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21093;
		 global::java.lang.Class java.lang.reflect.Member.getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getDeclaringClass21093)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getDeclaringClass21093)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Member_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Member"));
			global::java.lang.reflect.Member_._getModifiers21090 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Member_._getName21091 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Member_._isSynthetic21092 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Member_._getDeclaringClass21093 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
		}
	}
}
