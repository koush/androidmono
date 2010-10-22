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
		internal static global::MonoJavaBridge.MethodId _getModifiers20972;
		 int java.lang.reflect.Member.getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Member_._getModifiers20972);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getModifiers20972);
		}
		internal static global::MonoJavaBridge.MethodId _getName20973;
		 global::java.lang.String java.lang.reflect.Member.getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getName20973)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getName20973)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic20974;
		 bool java.lang.reflect.Member.isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_._isSynthetic20974);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._isSynthetic20974);
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20975;
		 global::java.lang.Class java.lang.reflect.Member.getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_._getDeclaringClass20975)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Member_.staticClass, global::java.lang.reflect.Member_._getDeclaringClass20975)) as java.lang.Class;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Member_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Member"));
			global::java.lang.reflect.Member_._getModifiers20972 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Member_._getName20973 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Member_._isSynthetic20974 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Member_._getDeclaringClass20975 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Member_.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
		}
	}
}
