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
		private static global::MonoJavaBridge.MethodId _m0;
		int java.lang.reflect.Member.getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Member_.staticClass, "getModifiers", "()I", ref global::java.lang.reflect.Member_._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		global::java.lang.String java.lang.reflect.Member.getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Member_.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.Member_._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		bool java.lang.reflect.Member.isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Member_.staticClass, "isSynthetic", "()Z", ref global::java.lang.reflect.Member_._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		global::java.lang.Class java.lang.reflect.Member.getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Member_.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.reflect.Member_._m3) as java.lang.Class;
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
