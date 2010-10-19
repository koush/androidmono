namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Enumeration_))]
	public interface Enumeration  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasMoreElements();
		global::java.lang.Object nextElement();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Enumeration))]
	public sealed partial class Enumeration_ : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Enumeration_()
		{
			InitJNI();
		}
		internal Enumeration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreElements20232;
		 bool java.util.Enumeration.hasMoreElements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Enumeration_._hasMoreElements20232);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Enumeration_.staticClass, global::java.util.Enumeration_._hasMoreElements20232);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement20233;
		 global::java.lang.Object java.util.Enumeration.nextElement() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Enumeration_._nextElement20233)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Enumeration_.staticClass, global::java.util.Enumeration_._nextElement20233)) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Enumeration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Enumeration"));
			global::java.util.Enumeration_._hasMoreElements20232 = @__env.GetMethodIDNoThrow(global::java.util.Enumeration_.staticClass, "hasMoreElements", "()Z");
			global::java.util.Enumeration_._nextElement20233 = @__env.GetMethodIDNoThrow(global::java.util.Enumeration_.staticClass, "nextElement", "()Ljava/lang/Object;");
		}
	}
}
