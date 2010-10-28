namespace java.util
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.Enumeration_))]
	public partial interface Enumeration  : global::MonoJavaBridge.IJavaObject 
	{
		bool hasMoreElements();
		global::java.lang.Object nextElement();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.Enumeration))]
	internal sealed partial class Enumeration_ : java.lang.Object, Enumeration
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Enumeration_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasMoreElements26171;
		bool java.util.Enumeration.hasMoreElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.Enumeration_._hasMoreElements26171);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.Enumeration_.staticClass, global::java.util.Enumeration_._hasMoreElements26171);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement26172;
		global::java.lang.Object java.util.Enumeration.nextElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.Enumeration_._nextElement26172)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.Enumeration_.staticClass, global::java.util.Enumeration_._nextElement26172)) as java.lang.Object;
		}
		static Enumeration_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.Enumeration_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/Enumeration"));
			global::java.util.Enumeration_._hasMoreElements26171 = @__env.GetMethodIDNoThrow(global::java.util.Enumeration_.staticClass, "hasMoreElements", "()Z");
			global::java.util.Enumeration_._nextElement26172 = @__env.GetMethodIDNoThrow(global::java.util.Enumeration_.staticClass, "nextElement", "()Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
